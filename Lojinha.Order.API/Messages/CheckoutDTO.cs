namespace Lojinha.Order.API.Messages;

public class CheckoutDTO 
{
    
    public long Id { get; set; }

    public string? UserId { get; set; }

    public bool Finished { get; set; }

    public IEnumerable<CartDetailDTO> CartDetails { get; set; } = new List<CartDetailDTO>();

    public decimal Total { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime DateTime { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? CardNumber { get; set; }

    public string? CVV { get; set; }

    public string? ExpiryMothYear { get; set; }
}