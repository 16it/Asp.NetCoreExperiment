using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_WebPage.Controllers
{
    /// <summary>
    /// Vue����
    /// </summary>
    public class VueController : Controller
    {
        #region Base
        public IActionResult Base()
        {
            return View();
        }
        #endregion



        #region table
        /// <summary>
        /// ���غ�̨�������ɱ��
        /// </summary>
        /// <returns></returns>
        public IActionResult Table()
        {
            return View();
        }
        /// <summary>
        /// ����ȡ����
        /// </summary>
        /// <returns></returns>
        [HttpGet("students")]
        public JsonResult Students()
        {
            return new JsonResult(new List<dynamic>() { new { ID = 1, Name = "����" }, new { ID = 2, Name = "����" } }, new Newtonsoft.Json.JsonSerializerSettings());
        }

        #endregion


        #region ���
        /// <summary>
        /// ���
        /// </summary>
        /// <returns></returns>
        [HttpGet("component")]
        public IActionResult Component()
        {
            return View();
        }
        #endregion


        #region ��֤
        /// <summary>
        /// ��֤
        /// </summary>
        /// <returns></returns>
        [HttpGet("validate")]
        public IActionResult Validate()
        {
            return View();
        }
        #endregion


        #region todolist
        /// <summary>
        /// �б�
        /// </summary>
        /// <returns></returns>
        [HttpGet("todolist")]
        public IActionResult ToDoListComponent()
        {
            return View();
        }
        #endregion


        #region Form��
        public IActionResult Form()
        {
            return View();
        }
        #endregion
    }
}