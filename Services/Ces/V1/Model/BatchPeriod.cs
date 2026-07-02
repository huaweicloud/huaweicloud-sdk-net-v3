using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// **参数解释** 监控数据的聚合粒度，聚合解释可查看：“[[聚合含义](https://support.huaweicloud.com/ces_faq/ces_faq_0009.html)](tag:hc)[[聚合含义](https://support.huaweicloud.com/intl/zh-cn/ces_faq/ces_faq_0009.html)](tag:hk)[[聚合含义](https://support.huaweicloud.com/eu/ces_faq/ces_faq_0009.html)](tag:hws_eu)[[聚合含义](https://docs.otc.t-systems.com/usermanual/ces/ces_faq_0009.html)](tag:dt,dt_test)[《云监控服务用户指南》中“什么是聚合？”章节](tag:ax,cmcc,ctc,hcso_dt,fcs,fcs_vm,mix,g42,hk_g42,hk_sbc,hk_tm,hk_vdf,hws_ocb,ocb,sbc,srg)”。 **约束限制** 不涉及 **取值范围** 枚举值： - 1 监控资源的实时数据 - 60 聚合1分钟粒度数据，表示1分钟一个数据点 - 300 聚合5分钟粒度数据，表示5分钟一个数据点 - 1200 聚合20分钟粒度数据，表示20分钟一个数据点 - 3600 聚合1小时粒度数据，表示1小时一个数据点 - 14400 聚合4小时粒度数据，表示4小时一个数据点 - 86400 聚合1天粒度数据，表示1天一个数据点 **默认取值** 不涉及 
    /// </summary>
    /// <value>**参数解释** 监控数据的聚合粒度，聚合解释可查看：“[[聚合含义](https://support.huaweicloud.com/ces_faq/ces_faq_0009.html)](tag:hc)[[聚合含义](https://support.huaweicloud.com/intl/zh-cn/ces_faq/ces_faq_0009.html)](tag:hk)[[聚合含义](https://support.huaweicloud.com/eu/ces_faq/ces_faq_0009.html)](tag:hws_eu)[[聚合含义](https://docs.otc.t-systems.com/usermanual/ces/ces_faq_0009.html)](tag:dt,dt_test)[《云监控服务用户指南》中“什么是聚合？”章节](tag:ax,cmcc,ctc,hcso_dt,fcs,fcs_vm,mix,g42,hk_g42,hk_sbc,hk_tm,hk_vdf,hws_ocb,ocb,sbc,srg)”。 **约束限制** 不涉及 **取值范围** 枚举值： - 1 监控资源的实时数据 - 60 聚合1分钟粒度数据，表示1分钟一个数据点 - 300 聚合5分钟粒度数据，表示5分钟一个数据点 - 1200 聚合20分钟粒度数据，表示20分钟一个数据点 - 3600 聚合1小时粒度数据，表示1小时一个数据点 - 14400 聚合4小时粒度数据，表示4小时一个数据点 - 86400 聚合1天粒度数据，表示1天一个数据点 **默认取值** 不涉及 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BatchPeriod
    {
        /// <summary>
        /// Enum _1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        _1 = 1,

        /// <summary>
        /// Enum _60 for value: 60
        /// </summary>
        [EnumMember(Value = "60")]
        _60 = 2,

        /// <summary>
        /// Enum _300 for value: 300
        /// </summary>
        [EnumMember(Value = "300")]
        _300 = 3,

        /// <summary>
        /// Enum _1200 for value: 1200
        /// </summary>
        [EnumMember(Value = "1200")]
        _1200 = 4,

        /// <summary>
        /// Enum _3600 for value: 3600
        /// </summary>
        [EnumMember(Value = "3600")]
        _3600 = 5,

        /// <summary>
        /// Enum _14400 for value: 14400
        /// </summary>
        [EnumMember(Value = "14400")]
        _14400 = 6,

        /// <summary>
        /// Enum _86400 for value: 86400
        /// </summary>
        [EnumMember(Value = "86400")]
        _86400 = 7

    }

}
