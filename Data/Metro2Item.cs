public class Metro2Groups
{
    public Metro2Item? Group1 {get;set; } = new Metro2Item();
    public Metro2Item? Group2 {get;set; }  = new Metro2Item();
    public Metro2Item? Group3 {get;set; } = new Metro2Item();
}

public class Metro2Item
{
    public string? BlockDescriptorWord { get; set; } = "";
    public string? ProcessingIndicator { get; set; } = "";
    public string? TimeStamp { get; set; } = "";
    public string? CorrectionIndicator { get; set; } = "";
    public string? IdNum { get; set; } = "";
    public string? CycleIdentifer { get; set; } = "";
    public string? AccountID { get; set; }= "";
    public string? PortfolioType { get; set; }= "";
    public string? AccountType { get; set; }= "";
    public string? DateOpened { get; set; }= "";
    public string? CreditLimit { get; set; }= "";
    public string? HighestCredit { get; set; }= "";
    public string? TermDuration { get; set; }= "";
    public string? TermFrequency { get; set; }= "";
    public string? SchedulePaymentAmount { get; set; }= "";
    public string? ActualPaymentAmount { get; set; }= "";
    public string? AccountStatus{ get; set; }= "";
    public string? PaymentRating { get; set; }= "";
    public string? PaymentHistoryProfile { get; set; }= "";
    public string? SpecialComment { get; set; }= "";
    public string? ComplianceConditionCode{ get; set; }= "";
    public string? CurrentBalance { get; set; }= "";
    public string? AmountPastDue { get; set; }= "";
    public string? OriginalChargeoffAmount { get; set; }= "";
    public string? DateOfAccountInfo { get; set; }= "";
    public string? DFD { get; set; }= "";
    public string? DateClosed { get; set; }= "";
    public string? DateOfLastPayment { get; set; }= "";
    public string? CurrencyType { get; set; }= "";
    public string? ConsumerTransactionType { get; set; }= "";
    public string? SurName { get; set; }= "";
    public string? FirstName { get; set; }= "";
    public string? MiddleName { get; set; }= "";
    public string? GenerationCode { get; set; }= "";
    public string? SIN { get; set; }= "";
    public string? DOB { get; set; }= "";
    public string? PhoneNumber { get; set; }= "";
    public string? AssociationCode { get; set; }= "";
    public string? ConsumerInfoIndicator { get; set; }= "";
    public string? Country { get; set; }= "";
    public string? FirstAddress { get; set; }= "";
    public string? SecondAddress { get; set; }= "";
    public string? City { get; set; }= "";
    public string? Province { get; set; }= "";
    public string? PostalCode { get; set; }= "";
    public string? AddressIndicator { get; set; }= "";
    public string? ResidenceCode { get; set; }= "";
    public string? Raw { get; set; }= "";
}