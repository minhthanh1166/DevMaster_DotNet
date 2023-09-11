namespace Lab04.Models.DataModels
{
    public class PeopleData
    {
        public static List<People> ListPeoples = new List<People>()
        {
            new People()
            {
                    Id = 1,
                    Name = "Nguyen Thi Doan Trang",
                    Email = "nguyenthidoantrang@gmail.com",
                    Phone = "0829936692",
                    Address = "Quynh Phu, Thai Binh",
                    Avatar = "/images/avatars/Nguyen Thi Doan Trang.jpg",
                    Bio = "Toi la mot nguoi nang dong, nhiet huyet",
                    Birthday = new DateTime(1967, 06, 11),
                    Gender = 2,
            }
        };

        public static List<People> GetPeople()
        {
            return ListPeoples;
        }

        public static People GetPeopleById(int id)
        {
            if (id > 0)
            {
                var people = GetPeople().FirstOrDefault(x => x.Id == id);
                return people;
            }
            return null;
        }

        public static bool Add(People people)
        {
            if (people != null)
            {
                ListPeoples.Add(people);
                return true;
            }
            return false;
        }

        public static bool Edit(int id, People newPeople)
        {
            // Tìm kiếm phần tử có Id tương ứng trong danh sách
            int indexToEdit = ListPeoples.FindIndex(p => p.Id == id);

            // Nếu không tìm thấy phần tử, trả về false để chỉ ra không có sự chỉnh sửa nào xảy ra
            if (indexToEdit == -1)
            {
                return false;
            }

            // Thực hiện chỉnh sửa thông tin của phần tử tìm thấy
            ListPeoples[indexToEdit] = newPeople;

            // Trả về true để chỉ ra đã có sự chỉnh sửa thành công
            return true;
        }

        public static bool Delete(int id)
        {
            if (ListPeoples.Remove(GetPeopleById(id)))
            {
                return true;
            }
            return false;
        }
    }
}
