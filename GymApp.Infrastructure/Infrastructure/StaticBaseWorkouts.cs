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
                    "Wyciskanie sztangi", "Wyciskanie hantli", "Rozpiętki", "Wyciskanie na barki"
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
