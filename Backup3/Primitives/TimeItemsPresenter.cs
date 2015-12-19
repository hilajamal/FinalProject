using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows;
using System.Windows.Controls;

namespace Schedule.Primitives
{
    public class TimeItemsPresenter : MultiSelector
    {
        static TimeItemsPresenter()
        {
            // Override default styles
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(TimeItemsPresenter), new FrameworkPropertyMetadata(typeof(TimeItemsPresenter)));

            FrameworkElementFactory fact = new FrameworkElementFactory(typeof(TimePanel));
            Binding startBinding = new Binding() 
            { 
                Path = new PropertyPath(TimePanel.ItemStartProperty),
                RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor) 
                { 
                    AncestorType = typeof(TimeItemsPresenter) 
                },
                NotifyOnTargetUpdated = true
            };
            fact.SetBinding(TimePanel.ItemStartProperty, startBinding);

            Binding endBinding = new Binding()
            {
                Path = new PropertyPath(TimePanel.ItemEndProperty),
                RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor)
                {
                    AncestorType = typeof(TimeItemsPresenter)
                },
                NotifyOnTargetUpdated = true

            };
            fact.SetBinding(TimePanel.ItemEndProperty, endBinding);

            ItemsPanelTemplate defaultValue = new ItemsPanelTemplate(fact);
            defaultValue.Seal();
            ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(TimeItemsPresenter), new FrameworkPropertyMetadata(defaultValue));
        }

        public TimeItemsPresenter()
        {

        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        protected override void ClearContainerForItemOverride(DependencyObject element, object item)
        {
            base.ClearContainerForItemOverride(element, item);
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TimeItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TimeItem();
        }

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            if (!(item is TimeItem))
            {
                // Iets met databinding doen
                Binding startBinding = new Binding("Start");
                Binding endBinding = new Binding("End");
                startBinding.Source = item;
                endBinding.Source = item;
                BindingOperations.SetBinding(element, TimePanel.ItemStartProperty, startBinding);
                BindingOperations.SetBinding(element, TimePanel.ItemEndProperty, endBinding);
            }
        }

        public TimeItemSize ItemSize
        {
            get { return (TimeItemSize)GetValue(ItemSizeProperty); }
            set { SetValue(ItemSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemSizeProperty =
            DependencyProperty.Register("ItemSize", typeof(TimeItemSize), typeof(TimeItemsPresenter),
            new FrameworkPropertyMetadata(TimeItemSize.OneHour)
            {
                AffectsArrange = true,
                AffectsMeasure = true
            }
            );
    }
}
