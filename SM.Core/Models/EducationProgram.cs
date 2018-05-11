using System;
using System.Collections.Generic;
using System.Text;

namespace SM.Domain.Core.Models
{
    public class EducationProgram
    {
        public string Guid { get; set; }
        /// <summary>
        /// Название программы
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Тип программы - Обучение / Стажировка
        /// </summary>
        public string @Type { get; set; }
        /// <summary>
        /// Вид проведения - Курс / Семинар
        /// </summary>
        public string @Class { get; set; }
        /// <summary>
        /// Активность
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Дата утверждения
        /// </summary>
        public DateTime Accepted { get; set; }
    }
}
