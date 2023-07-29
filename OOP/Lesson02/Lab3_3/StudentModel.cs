using System.Collections.Generic;

namespace Lab3_3
{
    public class StudentModel
    {
        // Khởi tạo tập hợp chưa các sinh viên
        private List<Student> students;

        // Khai báo method StudentModel:
        public StudentModel()
        {
            this.students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Bùi Minh Thành",
                    Age = 22
                },
                new Student()
                {
                    Id = 2,
                    Name = "Trịnh Văn Chung",
                    Age = 45
                },
                new Student()
                {
                    Id = 3,
                    Name = "Đàm Quốc Dân",
                    Age = 21
                },
            };
        }

        // Các phương thức overloading
        #region 
        // Phương thức trả về danh sách sinh viên 
        public List<Student> GetListStudent()
        {
            return this.students;
        }

        // Phương thức trả về sinh viên theo id 
        public Student GetStudentById(int id)
        {
            Student st = null;
            foreach (var item in this.students)
            {
                if (item.Id == id)
                {
                    st = item;
                    break;
                }
            }
            return st;
        }

        // Phương thức trả về sinh viên có độ tuổi từ x đến y
        public List<Student> GetStudentByAge(byte x, byte y)
        {
            var result = new List<Student>();

            foreach (var item in this.students)
            {
                if (item.Age >= x && item.Age <= y)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        #endregion
    }
}
