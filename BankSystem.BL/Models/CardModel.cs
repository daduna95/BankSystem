using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.BL.Models
{
    public class CardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal Bonus { get; set; }
        public decimal DailyLimit { get; set; }
        public Color Color { get; set; }
    }
}
