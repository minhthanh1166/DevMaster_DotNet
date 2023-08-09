namespace Lab04_7
{
    internal abstract class NhanVien
    {
        protected string Ten { get; set; }
        protected string DiaChi { get; set; }

        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}
