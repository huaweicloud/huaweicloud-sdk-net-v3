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
    /// 服务器的稳态，完成某个操作的稳定状态。 * &#x60;BUILD&#x60; - 创建APS实例,APS实例进入运行之前的状态 * &#x60;BUILD_FAIL&#x60; - 创建APS实例失败 * &#x60;REBOOT&#x60; - 实例正在进行重启操作 * &#x60;HARD_REBOOT&#x60; - 实例正在进行强制重启操作 * &#x60;REBUILD&#x60; - 实例正在重建中 * &#x60;REBUILD_FAIL&#x60; - 实例重建失败 * &#x60;MIGRATING&#x60; - 实例正在热迁移中 * &#x60;RESIZE&#x60; - 实例接收变更请求，开始进行变更操作 * &#x60;ACTIVE&#x60; - 实例正常运行状态 * &#x60;SHUTOFF&#x60; - 实例被正常停止 * &#x60;REVERT_RESIZE&#x60; - 实例正在回退变更规格的配置 * &#x60;VERIFY_RESIZE&#x60; - 实例正在校验变更完成后的配置。 * &#x60;ERROR&#x60; - 实例处于异常状态。 * &#x60;DELETING&#x60; - 实例删除中。 * &#x60;FREEZE&#x60; - 冻结 * &#x60;BUILD_IMAGE&#x60; - 生成镜像中 * &#x60;BUILD_SNAPSHOT&#x60; - 生成快照中 * &#x60;RESTORE_SNAPSHOT&#x60; - 恢复快照中 * &#x60;NULL&#x60; - 未设置
    /// </summary>
    /// <value>服务器的稳态，完成某个操作的稳定状态。 * &#x60;BUILD&#x60; - 创建APS实例,APS实例进入运行之前的状态 * &#x60;BUILD_FAIL&#x60; - 创建APS实例失败 * &#x60;REBOOT&#x60; - 实例正在进行重启操作 * &#x60;HARD_REBOOT&#x60; - 实例正在进行强制重启操作 * &#x60;REBUILD&#x60; - 实例正在重建中 * &#x60;REBUILD_FAIL&#x60; - 实例重建失败 * &#x60;MIGRATING&#x60; - 实例正在热迁移中 * &#x60;RESIZE&#x60; - 实例接收变更请求，开始进行变更操作 * &#x60;ACTIVE&#x60; - 实例正常运行状态 * &#x60;SHUTOFF&#x60; - 实例被正常停止 * &#x60;REVERT_RESIZE&#x60; - 实例正在回退变更规格的配置 * &#x60;VERIFY_RESIZE&#x60; - 实例正在校验变更完成后的配置。 * &#x60;ERROR&#x60; - 实例处于异常状态。 * &#x60;DELETING&#x60; - 实例删除中。 * &#x60;FREEZE&#x60; - 冻结 * &#x60;BUILD_IMAGE&#x60; - 生成镜像中 * &#x60;BUILD_SNAPSHOT&#x60; - 生成快照中 * &#x60;RESTORE_SNAPSHOT&#x60; - 恢复快照中 * &#x60;NULL&#x60; - 未设置</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppServerStatus
    {
        /// <summary>
        /// Enum BUILD for value: BUILD
        /// </summary>
        [EnumMember(Value = "BUILD")]
        BUILD = 1,

        /// <summary>
        /// Enum BUILD_FAIL for value: BUILD_FAIL
        /// </summary>
        [EnumMember(Value = "BUILD_FAIL")]
        BUILD_FAIL = 2,

        /// <summary>
        /// Enum REBOOT for value: REBOOT
        /// </summary>
        [EnumMember(Value = "REBOOT")]
        REBOOT = 3,

        /// <summary>
        /// Enum HARD_REBOOT for value: HARD_REBOOT
        /// </summary>
        [EnumMember(Value = "HARD_REBOOT")]
        HARD_REBOOT = 4,

        /// <summary>
        /// Enum REBUILD for value: REBUILD
        /// </summary>
        [EnumMember(Value = "REBUILD")]
        REBUILD = 5,

        /// <summary>
        /// Enum REBUILD_FAIL for value: REBUILD_FAIL
        /// </summary>
        [EnumMember(Value = "REBUILD_FAIL")]
        REBUILD_FAIL = 6,

        /// <summary>
        /// Enum MIGRATING for value: MIGRATING
        /// </summary>
        [EnumMember(Value = "MIGRATING")]
        MIGRATING = 7,

        /// <summary>
        /// Enum RESIZE for value: RESIZE
        /// </summary>
        [EnumMember(Value = "RESIZE")]
        RESIZE = 8,

        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 9,

        /// <summary>
        /// Enum SHUTOFF for value: SHUTOFF
        /// </summary>
        [EnumMember(Value = "SHUTOFF")]
        SHUTOFF = 10,

        /// <summary>
        /// Enum REVERT_RESIZE for value: REVERT_RESIZE
        /// </summary>
        [EnumMember(Value = "REVERT_RESIZE")]
        REVERT_RESIZE = 11,

        /// <summary>
        /// Enum VERIFY_RESIZE for value: VERIFY_RESIZE
        /// </summary>
        [EnumMember(Value = "VERIFY_RESIZE")]
        VERIFY_RESIZE = 12,

        /// <summary>
        /// Enum ERROR for value: ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR = 13,

        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING = 14,

        /// <summary>
        /// Enum FREEZE for value: FREEZE
        /// </summary>
        [EnumMember(Value = "FREEZE")]
        FREEZE = 15,

        /// <summary>
        /// Enum BUILD_IMAGE for value: BUILD_IMAGE
        /// </summary>
        [EnumMember(Value = "BUILD_IMAGE")]
        BUILD_IMAGE = 16,

        /// <summary>
        /// Enum BUILD_SNAPSHOT for value: BUILD_SNAPSHOT
        /// </summary>
        [EnumMember(Value = "BUILD_SNAPSHOT")]
        BUILD_SNAPSHOT = 17,

        /// <summary>
        /// Enum RESTORE_SNAPSHOT for value: RESTORE_SNAPSHOT
        /// </summary>
        [EnumMember(Value = "RESTORE_SNAPSHOT")]
        RESTORE_SNAPSHOT = 18,

        /// <summary>
        /// Enum NULL for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        NULL = 19

    }

}
