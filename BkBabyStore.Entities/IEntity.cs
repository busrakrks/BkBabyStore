using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BkBabyStore.Entities
{
    public interface  IEntity //veritabanındaki classlarımızı işaretlemek onlara kimlik vermek için kullanacağız
    {
        public int Id { get; set; } //tüm classlarda Id olmalı
    }
}
