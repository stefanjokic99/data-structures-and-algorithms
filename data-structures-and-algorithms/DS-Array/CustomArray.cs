using System.Text;

namespace data_structures_and_algorithms.DS_Array
{
    public sealed class CustomArray
    {
        public int Length { get; private set; }
        public object[] Data { get; private set; }

        public CustomArray()
        {
            Length = 0;
            Data = new object[1];
        }

        public object this[int index]
        {
            get { return Data[index]; }
            set 
            {
                if (index >= Length)
                {
                    throw new Exception("Undefined value in array.");
                }

                Data[index] = value;
            }
        }

        public object Get(int index) 
        {
            return Data[index];
        }

        // Pushing items at last index
        public object[] Push(object item) 
        {
            // In first attempt Data.Leng is 1, but Length of array is 0
            if (Data.Length == Length) 
            {
                object[] temp = new object[Length]; // creates a temp array
                Array.Copy(Data, temp, Length); // copies all data to temp array
                Data = new object[Length + 1];
                Array.Copy(temp, Data, Length);
            }

            Data[Length] = item;
            Length++;

            return Data;
        }

        public object Pop() 
        {
            object poped = Data[Length - 1];
            Data[Length - 1] = null; // nulling out the last item
            Length--;

            return poped;
        }

        public object Delete(int index)
        { 
            object itemToDelete = Data[index];
            ShiftItems(index);

            return itemToDelete;

        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < Length; i++) 
            {
                result.Append(Data[i]);
                result.Append(", ");
            }

            return result.ToString();
        }


        private void ShiftItems(int index)
        {
            for (int i = index; i < Length - 1; i++) 
            {
                Data[i] = Data[i + 1];

            }

            Data[Length - 1] = null;
            Length--;
        }

    }
}
