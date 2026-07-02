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
    /// **参数解释** 查询数据起始时间，UNIX时间戳，单位毫秒 **约束限制** 当period为1时，若(to- from) &gt;4*3600*1000，则from调整为 to - 4*3600*1000 当period为300时，若(to - from) &gt;24*3600*1000，则from调整为 to - 24*3600*1000 当period为1200时，若(to - from) &gt;3*24*3600*1000，则from调整为 to - 3*24*3600*1000 当period为3600时，若(to -from) &gt; 10*24*3600*1000，则from调整为 to -10*24*3600*1000 当period为14400时，若(to - from) &gt;30*24*3600*1000，则from调整为 to - 30*24*3600*1000 当period为86400时，若(to -from) &gt; 180*24*3600*1000，则from调整为 to - 180*24*3600*1000 **取值范围** 毫秒级时间戳范围为[1111111111111,9999999999999] **默认取值** 不涉及 
    /// </summary>
    public class FromTimeStampSchema 
    {



    }
}
