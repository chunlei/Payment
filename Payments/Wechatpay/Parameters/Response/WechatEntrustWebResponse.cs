using Newtonsoft.Json;
using Payments.Wechatpay.Parameters.Response.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace Payments.Wechatpay.Parameters.Response
{
    /// <summary>
    /// ���ں�APP����ǩԼ
    /// </summary>
    [XmlRoot("xml")]
    public class WechatEntrustWebResponse : WechatpayResponse
    {
        /// <summary>
        /// ǩԼЭ���
        /// </summary>
        [XmlElement("contract_code")]
        public virtual string ContractCode { get; set; }

        /// <summary>
        /// �û���ʶ
        /// </summary>
        [XmlElement("openid")]
        public virtual string Openid { get; set; }

        /// <summary>
        /// ģ��id
        /// </summary>
        [XmlElement("plan_id")]
        public virtual string PlanId { get; set; }

        /// <summary>
        /// �������������ȡֵ:
        /// ADD--ǩԼ
        /// DELETE--��Լ
        /// </summary>
        [XmlElement("change_type")]
        public virtual string ChangeType { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [XmlElement("operate_time")]
        public virtual string OperateTime { get; set; }
        /// <summary>
        /// ί�д���Э��id
        /// </summary>
        [XmlElement("contract_id")]
        public virtual string ContractId { get; set; }

        /// <summary>
        /// Э�鵽��ʱ�䣬��change_typeΪADDʱ�з���
        /// </summary>
        [XmlElement("contract_expired_time")]
        public virtual string ContractExpiredTime { get; set; }

        /// <summary>
        /// ��change_typeΪDELETEʱ�з��� 
        /// 0-δ��Լ 
        /// 1-��Ч�ڹ��Զ���Լ 
        /// 2-�û�������Լ 
        /// 3-�̻�API��Լ 
        /// 4-�̻�ƽ̨��Լ 
        /// 5-ע��
        /// </summary>
        [XmlElement("contract_termination_mode")]
        public virtual int ContractTerminationMode { get; set; }

        /// <summary>
        /// �̻�����ǩԼʱ�����кţ��̻�����Ψһ��
        /// ���к���Ҫ�������򣬲���Ϊ��ѯ������������,��Χ���ܳ���Int64�ķ�Χ��9223372036854775807����
        /// </summary>
        [XmlElement("request_serial")]
        public virtual Int64 RequestSerial { get; set; }


    }
}
