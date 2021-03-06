﻿using Payments.Attributes;
using Payments.Core.Enum;
using Payments.Core.Response;
using Payments.Wechatpay.Parameters.Requests;
using Payments.Wechatpay.Parameters.Response;
using Payments.Wechatpay.Results;
using System.Threading.Tasks;

namespace Payments.Wechatpay.Abstractions
{

    /// <summary>
    /// 查询扣款订单服务
    /// </summary>
    [PayService("查询扣款订单服务", PayOriginType.WechatPay)]
    public interface IWechatPapOrderQueryService
    {
        /// <summary>
        /// 扣款
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<WechatpayResult<WechatPapOrderQueryResponse>> Query(WechatPapOrderQueryRequest request);
    }
}
