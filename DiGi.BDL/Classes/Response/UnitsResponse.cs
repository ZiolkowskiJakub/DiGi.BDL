namespace DiGi.BDL.Classes
{
    public class UnitsResponse : Response<Unit>
    {
        public int page { get; set; }

        public int pageSize { get; set; }
    }
}
