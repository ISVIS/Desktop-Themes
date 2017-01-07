// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace Isvis.Windows.Themes
{
    public class Property : INotifyPropertyChanged
    {
        private readonly object instance;

        private readonly DependencyPropertyDescriptor property;

        public Property(object instance, DependencyPropertyDescriptor property)
        {
            var descriptor = instance as ICustomTypeDescriptor;
            this.instance = descriptor != null ? descriptor.GetPropertyOwner(property) : instance;

            this.property = property;
            this.property.AddValueChanged(this.instance, this.NotifyPropertyChanged);
            this.NotifyPropertyChanged("PropertyType");
        }

        public string Category
        {
            get { return this.property.Category; }
        }

        public string Description
        {
            get { return this.property.Description; }
        }

        public string Name
        {
            get { return this.property.DependencyProperty.Name; }
        }

        public Type Type
        {
            get { return this.property.PropertyType; }
        }

        public object Value
        {
            get { return this.property.GetValue(this.instance); }

            set
            {
                var current = this.property.GetValue(this.instance);
                if (value.Equals(current))
                {
                    return;
                }

                if (value.Equals(string.Empty))
                {
                    value = null;
                }

                try
                {
                    var propertyType = this.property.PropertyType;
                    if (value == null || propertyType == typeof (object))
                    {
                        this.property.SetValue(this.instance, value);
                    }
                    else
                    {
                        var converter = TypeDescriptor.GetConverter(this.property.PropertyType);
                        this.property.SetValue(this.instance, converter.ConvertFrom(value));
                    }
                }
                catch (Exception)
                {
                }

                this.NotifyPropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(object sender, EventArgs e)
        {
            this.NotifyPropertyChanged("Value");
        }

        private void NotifyPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}