using System;

namespace Sesson04_DeMo
{
    internal interface IStoreable
    {
        void Read();
        void Write(Object data);
    }

    class Document : IStoreable
    {
        #region
        public void Read()
        {
            Console.WriteLine("Đọc dữ liệu");
        }

        public void Write(object obj)
        {
            Console.WriteLine("Ghi nội dung gì: " + obj + " vào tài liệu");
        }

        #endregion
    }
}
