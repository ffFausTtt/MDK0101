//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDK0101Program
{
    using System;
    using System.Collections.Generic;
    
    public partial class GenreBooks
    {
        public int ID_Genre { get; set; }
        public int ID_Books { get; set; }
        public int ID_GenreBooks { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Genre Genre { get; set; }
    }
}