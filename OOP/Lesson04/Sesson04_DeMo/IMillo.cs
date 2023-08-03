using System;

namespace Sesson04_DeMo
{
    internal interface IMillo
    {
        void Buid();
    }

    internal interface IAsia
    {
        void Model();
    }

    internal interface IVietNam : IMillo, IAsia
    {
        void BuildMidel();
    }

    internal class KhunNam : IVietNam
    {
        public void Buid()
        {
            Console.WriteLine("Kiến trúc");
        }

        public void BuildMidel()
        {
            Console.WriteLine("Văn hóa");
        }

        public void Model()
        {
            Console.WriteLine("Hàn quốc");
        }
    }
}
