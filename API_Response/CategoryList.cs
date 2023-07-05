using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIResponse
{
    public partial class CategoryList
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool CanListAuctions { get; set; }
        public bool CanListClassifieds { get; set; }
        public bool CanRelist { get; set; }
        public long DefaultDuration { get; set; }
        public long[] AllowedDurations { get; set; }
        public Fees Fees { get; set; }
        public long FreePhotoCount { get; set; }
        public long MaximumPhotoCount { get; set; }
        public Charity[] Charities { get; set; }
        public Promotion[] Promotions { get; set; }
        public object[] EmbeddedContentOptions { get; set; }
        public long MaximumTitleLength { get; set; }
        public long AreaOfBusiness { get; set; }
        public long DefaultRelistDuration { get; set; }
        public bool CanHaveSecondCategory { get; set; }
        public bool CanBeSecondCategory { get; set; }
        public bool CanUseCounterOffers { get; set; }
    }

    public partial class Charity
    {
        public long CharityType { get; set; }
        public Uri ImageSource { get; set; }
        public Uri DarkModeImageSource { get; set; }
        public string Description { get; set; }
        public string Tagline { get; set; }
    }

    public partial class Fees
    {
        public double Bundle { get; set; }
        public double EndDate { get; set; }
        public double Feature { get; set; }
        public double Gallery { get; set; }
        public double Reserve { get; set; }
        public double Subtitle { get; set; }
        public double TenDays { get; set; }
        public long Withdrawal { get; set; }
        public double HighVolume { get; set; }
        public long MaximumSuccessFee { get; set; }
        public SuccessFeeTier[] SuccessFeeTiers { get; set; }
        public double SecondCategory { get; set; }
    }

    public partial class SuccessFeeTier
    {
        public long MinimumTierPrice { get; set; }
        public double? PercentageFee { get; set; }
    }

    public partial class Promotion
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public long MinimumPhotoCount { get; set; }
        public double? OriginalPrice { get; set; }
        public double? GoodFor2RelistsFee { get; set; }
        public bool? Recommended { get; set; }
    }
 }