using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 通过该类型过滤出与桌面池规格类型不一致的桌面 - product_id: 查找productID与桌面池套餐ID不一致的桌面 - image_id: 查找imageID与桌面池镜像ID不一致的桌面 - disk_num: 查找数据盘数量与桌面池配置不一致的桌面 - disk_size: 查找磁盘累加容量与桌面池配置不一致的桌面
    /// </summary>
    /// <value>通过该类型过滤出与桌面池规格类型不一致的桌面 - product_id: 查找productID与桌面池套餐ID不一致的桌面 - image_id: 查找imageID与桌面池镜像ID不一致的桌面 - disk_num: 查找数据盘数量与桌面池配置不一致的桌面 - disk_size: 查找磁盘累加容量与桌面池配置不一致的桌面</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InconsistentTypeEnum
    {
        /// <summary>
        /// Enum PRODUCT_ID for value: product_id
        /// </summary>
        [EnumMember(Value = "product_id")]
        PRODUCT_ID = 1,

        /// <summary>
        /// Enum IMAGE_ID for value: image_id
        /// </summary>
        [EnumMember(Value = "image_id")]
        IMAGE_ID = 2,

        /// <summary>
        /// Enum DISK_NUM for value: disk_num
        /// </summary>
        [EnumMember(Value = "disk_num")]
        DISK_NUM = 3,

        /// <summary>
        /// Enum DISK_SIZE for value: disk_size
        /// </summary>
        [EnumMember(Value = "disk_size")]
        DISK_SIZE = 4

    }

}
