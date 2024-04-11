namespace RecycleElementBug
{
    
    public class ItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate AlarmTemplate { get; set; }
        public DataTemplate RegularTemplate { get; set; }
        public DataTemplate WarningTemplate { get; set; }
        public DataTemplate InfoTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            string type = item.GetType().Name;

            switch (type)
            {
                case "Alarm": return AlarmTemplate;
                case "Regular": return RegularTemplate;
                case "Warning": return WarningTemplate;
                case "Info": return InfoTemplate;
                default: return RegularTemplate;
            }
        }
    }
}
