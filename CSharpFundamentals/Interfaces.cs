namespace Application
{
    interface IList
    {
        public void Get();
        public void CreatePagination();
    }

    interface IDetails
    {
        public void GetOne();
    }
}
