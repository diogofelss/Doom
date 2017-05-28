namespace Doom.Domain.FrameWork.Strings
{
    public class PassWordString
    {
        private string _value;

        public PassWordString(string value)
        {
            _value = value;
        }

        public static implicit operator PassWordString(string value)
        {
            // While not technically a requirement; see below why this is done.
            if (value == null)
                return null;

            return new PassWordString(value);
        }

        public bool IsNullOrWhiteSpace
        {
            get { return string.IsNullOrWhiteSpace(_value); }
        }
    }
}
