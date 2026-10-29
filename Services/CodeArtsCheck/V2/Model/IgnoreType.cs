using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** [忽略类型，将问题修改为待审核状态时选填。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm)[废弃字段。](tag:hws,hws_hk) **约束限制：** 不涉及。 **取值范围：** - NO_RISK：评估无风险暂不解决。 - FALSE_POSITIVES：纯属工具误报。 - THIRD_PARTY：开源及第三方。 - EFFUCUENCY_RETAIN：性能敏感保留危险函数。 - NO_SUPPORT_INKERNEL：不支持的内核危险函数。 - EXCLUDE_SCENES：规范例外场景。 - COMPATIBLE_THIRD_PARTY：兼容第三方。 **默认取值：** NO_RISK
    /// </summary>
    public class IgnoreType 
    {



    }
}
