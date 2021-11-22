namespace BlazorDeployDemo.Shared
{
    public class Setting
    {
        public string Value { get; set; } = "";

        public Setting(string value)
        {
            Value = value;
        }

        public Setting()
        {

        }
    }
}
