namespace Cell
{
    public class Cell<T>
    {
        public T? Data { get; private set; }

        public void SetValue(T pobjectValue)
        {
            Data = pobjectValue;
        }

        public Cell()
        {
            Data = default;
        }

        public Cell(T pobjValue)
        {
            Data = pobjValue;
        }

        public void Clear()
        {
            Data = default;
        }
    }
}