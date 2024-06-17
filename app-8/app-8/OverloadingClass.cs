class OverloadingClass
{
    public DateTime tempDate;
    public OverloadingClass(int year, int month, int day)
    {
        tempDate = new DateTime(year, month, day);
    }
    public static DateTime operator +(OverloadingClass D, int noOfDays)
    {
        return D.tempDate.AddDays(noOfDays);
    }
    public static DateTime operator +(int noOfDays, OverloadingClass D)
    {
        return D.tempDate.AddDays(noOfDays);
    }
}