using vdi.dto.Request;

namespace vdi.Helper
{
    public class ProgramHelper
    {
        public static string SplitAndReverse(string input) {


            int mid = input.Length / 2;


            if (input.Length % 2 == 0)
            {
                string left = new string(  input.Substring(0, mid).Reverse().ToArray());

                string right = new string(input.Substring(mid).Reverse().ToArray());
                
                return left + right;    
            }
            else {

                string middle = input[mid].ToString();
                string left = new string(input.Substring(0, mid).Reverse().ToArray());
                string right = new string(input.Substring(mid+1).Reverse().ToArray());
                return left + middle + right;
            }

        }


        public static int[] anagramChecker(AnagramRequest request) {


            return request.FirstWords.Select((word, index) =>
            {
                string sortedFirst = new string(word.OrderBy(c => c).ToArray());
                string sortedSecond = new string(request.SecondWords[index].OrderBy(c => c).ToArray());
                return sortedFirst == sortedSecond ? 1 : 0;
            }).ToArray();
        }


        public static (double discount, double totalPay) CalculateDiscount(string customerType, int rewardPoints, double totalBelanja)
        {
            double discount = customerType switch
            {
                "platinum" when rewardPoints is >= 100 and <= 300 => totalBelanja * 0.5 + 35,
                "platinum" when rewardPoints is >= 301 and <= 500 => totalBelanja * 0.5 + 50,
                "platinum" when rewardPoints > 500 => totalBelanja * 0.5 + 68,
                "gold" when rewardPoints is >= 100 and <= 300 => totalBelanja * 0.25 + 25,
                "gold" when rewardPoints is >= 301 and <= 500 => totalBelanja * 0.25 + 34,
                "gold" when rewardPoints > 500 => totalBelanja * 0.25 + 52,
                "silver" when rewardPoints is >= 100 and <= 300 => totalBelanja * 0.1 + 12,
                "silver" when rewardPoints is >= 301 and <= 500 => totalBelanja * 0.1 + 27,
                "silver" when rewardPoints > 500 => totalBelanja * 0.1 + 39,
                _ => 0
            };

            double totalPay = totalBelanja - discount;
            return (discount, totalPay);
        }
    }
}
