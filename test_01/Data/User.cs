using test_01.Models;

namespace test_01.Data
{
    public class User
    {
        public List<UserViewModel> Users { get; } = new()
        {
            new UserViewModel
            {
                id = 1,
                Name = "John Doe",
                Username = "johndoe",
                Email = "john.doe@example.com",
                Phone = "555-0101",
                Website = "johndoe.com"
            },
            new UserViewModel
            {
                id = 2,
                Name = "Jane Smith",
                Username = "janesmith",
                Email = "jane.smith@example.com",
                Phone = "555-0102",
                Website = "janesmith.dev"
            },
            new UserViewModel
            {
                id = 3,
                Name = "Michael Johnson",
                Username = "mjohnson",
                Email = "michael.johnson@example.com",
                Phone = "555-0103",
                Website = "mjohnson.io"
            },
            new UserViewModel
            {
                id = 4,
                Name = "Emily Davis",
                Username = "emilyd",
                Email = "emily.davis@example.com",
                Phone = "555-0104",
                Website = "emilyd.dev"
            },
            new UserViewModel
            {
                id = 5,
                Name = "William Brown",
                Username = "wbrown",
                Email = "william.brown@example.com",
                Phone = "555-0105",
                Website = "wbrown.net"
            },
            new UserViewModel
            {
                id = 6,
                Name = "Olivia Wilson",
                Username = "oliviaw",
                Email = "olivia.wilson@example.com",
                Phone = "555-0106",
                Website = "oliviawilson.com"
            },
            new UserViewModel
            {
                id = 7,
                Name = "James Taylor",
                Username = "jamest",
                Email = "james.taylor@example.com",
                Phone = "555-0107",
                Website = "jamestaylor.org"
            },
            new UserViewModel
            {
                id = 8,
                Name = "Sophia Martinez",
                Username = "sophiam",
                Email = "sophia.martinez@example.com",
                Phone = "555-0108",
                Website = "sophiam.dev"
            },
            new UserViewModel
            {
                id = 9,
                Name = "Daniel Anderson",
                Username = "danderson",
                Email = "daniel.anderson@example.com",
                Phone = "555-0109",
                Website = "dananderson.com"
            },
            new UserViewModel
            {
                id = 10,
                Name = "Isabella Thomas",
                Username = "isabellat",
                Email = "isabella.thomas@example.com",
                Phone = "555-0110",
                Website = "isabellathomas.io"
            }
        };
    }
}