using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Infrastructure.Infrastructure
{
    public static class StaticBaseWorkouts
    {
        public static readonly Dictionary<string, List<string>> Days = new()
        {
            {
                "ChestShoulders", new List<string>
                {
                    "Wyciskanie hantli skos górny", "Rozpiętki na maszynie", "Rozpiętki na ławce", "Wyciskanie hantli na barki", "Dipy na klate", "Ściąganie linek", "Unoszenie hantli bokiem", "Reverse na maszynie rozpiętki",
                }
            },
            {
                "BackBiceps", new List<string>
                {
                    "Podciąganie", "Wiosłowanie sztangą", "Uginanie na biceps", "Face pull"
                }
            },
            {
                "LegsAbsTriceps", new List<string>
                {
                    "Przysiady", "Martwy ciąg", "Brzuszki", "Wyciskanie francuskie"
                }
            }
        };
    }
}
