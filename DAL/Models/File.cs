using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class File: AuditableEntity
    {
        /// <summary>
        /// Поле связка с таблицей Folders
        /// </summary>
        public int FolderId { get; set; }
        /// <summary>
        /// Путь до файла с имененем файла
        /// </summary>
        public string FileFullPath { get; set; }
        /// <summary>
        /// Дата создания файла
        /// </summary>
        public DateTime FileDateCreate { get; set; }
        /// <summary>
        /// Размер файла в байтах
        /// </summary>
        public decimal FileSize { get; set; }
        /// <summary>
        /// Расширение файла
        /// </summary>
        public string FileExtension { get; set; }

    }
}
