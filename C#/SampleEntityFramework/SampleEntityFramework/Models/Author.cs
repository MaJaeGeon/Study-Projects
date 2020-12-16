using System;
using System.Collections.Generic;

namespace SampleEntityFramework.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Book> Books { get; set; }    // Entity 클래스에 다른 Entity 클래스가 프로퍼티로 포함될 경우 해당 프로퍼티는 virtual 로 지정해야한다.
    }
}