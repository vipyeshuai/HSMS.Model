using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSMS.Model
{
   public class Employee
    {
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// 工号
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 性别Id
        /// </summary>
        public Guid GenderId
        {
            get;
            set;
        }

        //因为图片如果一次性读取到Model中会非常耗内存，因此需要的时候再去单独读取，不在Model中建字段

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay
        {
            get;
            set;
        }

        /// <summary>
        /// 入职日期
        /// </summary>
        public DateTime InDate
        {
            get;
            set;
        }

        /// <summary>
        /// 婚姻状态Id
        /// </summary>
        public Guid MarriageId
        {
            get;
            set;
        }

        /// <summary>
        /// 政治面貌Id
        /// </summary>
        public Guid PartyStatusId
        {
            get;
            set;
        }

        /// <summary>
        /// 民族
        /// </summary>
        public string Nationality
        {
            get;
            set;
        }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string NativeAddr
        {
            get;
            set;
        }

        /// <summary>
        /// 教育程度Id
        /// </summary>
        public Guid EducationId
        {
            get;
            set;
        }

        /// <summary>
        /// 专业
        /// </summary>
        public string Major
        {
            get;
            set;
        }

        /// <summary>
        /// 毕业院校
        /// </summary>
        public string School
        {
            get;
            set;
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 基本工资
        /// </summary>
        public int BaseSalary
        {
            get;
            set;
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// 有效身份证号
        /// </summary>
        public string IdNum
        {
            get;
            set;
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string TelNum
        {
            get;
            set;
        }

        /// <summary>
        /// 紧急联系人信息
        /// </summary>
        public string EmergencyContact
        {
            get;
            set;
        }

        /// <summary>
        /// 部门Id
        /// </summary>
        public Guid DepartmentId
        {
            get;
            set;
        }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position
        {
            get;
            set;
        }

        /// <summary>
        /// 合同起始时间
        /// </summary>
        public DateTime ContractStartDay
        {
            get;
            set;
        }

        /// <summary>
        /// 合同到期时间
        /// </summary>
        public DateTime ContractEndDay
        {
            get;
            set;
        }

        /// <summary>
        /// 简历
        /// </summary>
        public string Resume
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            get;
            set;
        }

        public byte[] Photo
        {
            get;
            set;
        }
    }
}
