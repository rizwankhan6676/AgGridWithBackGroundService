using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Pagination
    {
        public int size { get; set; } = 10;
        public int totalCount { get; set; } = 0;
        public int currentPage { get; set; } = 1;
        public int nextPage { get; set; } = 1;
        public int skip => (currentPage - 1) * size;
    }
}
