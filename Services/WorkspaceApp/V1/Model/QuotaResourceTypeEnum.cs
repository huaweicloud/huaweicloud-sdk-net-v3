using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 配额-资源类型： * GPU_INSTANCES：GPU资源实例数，单位个。 * INSTANCES：普通实例数，单位个。 * VOLUME_GIGABYTES：磁盘总容量，单位GB。 * VOLUMES：磁盘数量，单位个。 * CORES：CPU数量，单位个。 * MEMORY：内存容量，单位MB。
    /// </summary>
    /// <value>配额-资源类型： * GPU_INSTANCES：GPU资源实例数，单位个。 * INSTANCES：普通实例数，单位个。 * VOLUME_GIGABYTES：磁盘总容量，单位GB。 * VOLUMES：磁盘数量，单位个。 * CORES：CPU数量，单位个。 * MEMORY：内存容量，单位MB。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum QuotaResourceTypeEnum
    {
        /// <summary>
        /// Enum GPU_INSTANCES for value: GPU_INSTANCES
        /// </summary>
        [EnumMember(Value = "GPU_INSTANCES")]
        GPU_INSTANCES = 1,

        /// <summary>
        /// Enum INSTANCES for value: INSTANCES
        /// </summary>
        [EnumMember(Value = "INSTANCES")]
        INSTANCES = 2,

        /// <summary>
        /// Enum VOLUME_GIGABYTES for value: VOLUME_GIGABYTES
        /// </summary>
        [EnumMember(Value = "VOLUME_GIGABYTES")]
        VOLUME_GIGABYTES = 3,

        /// <summary>
        /// Enum VOLUMES for value: VOLUMES
        /// </summary>
        [EnumMember(Value = "VOLUMES")]
        VOLUMES = 4,

        /// <summary>
        /// Enum CORES for value: CORES
        /// </summary>
        [EnumMember(Value = "CORES")]
        CORES = 5,

        /// <summary>
        /// Enum MEMORY for value: MEMORY
        /// </summary>
        [EnumMember(Value = "MEMORY")]
        MEMORY = 6

    }

}
