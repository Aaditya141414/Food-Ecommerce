namespace FastFood.Models;

public class Coupon
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public double Discount { get; set; }
    public double MinimumAmount { get; set; }
    public byte[] CouponPicture { get; set; }
    public bool IsActive { get; set; }
}

public enum CouponType
{
    Percent=0,
    Currency=1
}
