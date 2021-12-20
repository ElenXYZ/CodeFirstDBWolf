using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Folder : AuditableEntity
    {
        /// <summary>
        /// Имя папки
        /// </summary>
        public string FolderName { get; set; }
        /// <summary>
        /// Маркер окончания обработки
        /// </summary>
        public bool IsDone { get; set; }
    }
}
