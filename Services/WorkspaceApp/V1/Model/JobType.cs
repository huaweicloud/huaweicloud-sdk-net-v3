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
    /// job类型： * &#x60;CREATE_SERVER&#x60; - 创建服务器 * &#x60;DELETE_SERVER&#x60; - 删除服务器 * &#x60;UPDATE_FREEZE_STATUS&#x60; - 修改服务器冻结状态 * &#x60;CREATE_SERVER_IMAGE&#x60; - 构建镜像 * &#x60;REINSTALL_OS&#x60; - 重装操作系统 * &#x60;CHANGE_SERVER_IMAGE&#x60; - 更换镜像 * &#x60;REJOIN_DOMAIN&#x60; - 重新加域 * &#x60;MIGRATE_SERVER&#x60; - 迁移服务器 * &#x60;UPGRADE_ACCESS_AGENT&#x60; - hda升级 * &#x60;UPDATE_SERVER_TSVI&#x60; - 更新虚拟会话IP * &#x60;SCHEDULED_TASK&#x60; - 定时任务job * &#x60;COLLECT_HDA_LOG&#x60; - 收集hda日志 * &#x60;COLLECT_APS_LOG&#x60; - 收集aps日志 * &#x60;CREATE_SERVER_SNAPSHOT&#x60; - 创建服务器快照 * &#x60;DELETE_SERVER_SNAPSHOT&#x60; - 删除服务器快照 * &#x60;RESTORE_SERVER_SNAPSHOT&#x60; - 恢复服务器快照 * &#x60;BATCH_INSTALL_APP&#x60; - 批量安装应用
    /// </summary>
    /// <value>job类型： * &#x60;CREATE_SERVER&#x60; - 创建服务器 * &#x60;DELETE_SERVER&#x60; - 删除服务器 * &#x60;UPDATE_FREEZE_STATUS&#x60; - 修改服务器冻结状态 * &#x60;CREATE_SERVER_IMAGE&#x60; - 构建镜像 * &#x60;REINSTALL_OS&#x60; - 重装操作系统 * &#x60;CHANGE_SERVER_IMAGE&#x60; - 更换镜像 * &#x60;REJOIN_DOMAIN&#x60; - 重新加域 * &#x60;MIGRATE_SERVER&#x60; - 迁移服务器 * &#x60;UPGRADE_ACCESS_AGENT&#x60; - hda升级 * &#x60;UPDATE_SERVER_TSVI&#x60; - 更新虚拟会话IP * &#x60;SCHEDULED_TASK&#x60; - 定时任务job * &#x60;COLLECT_HDA_LOG&#x60; - 收集hda日志 * &#x60;COLLECT_APS_LOG&#x60; - 收集aps日志 * &#x60;CREATE_SERVER_SNAPSHOT&#x60; - 创建服务器快照 * &#x60;DELETE_SERVER_SNAPSHOT&#x60; - 删除服务器快照 * &#x60;RESTORE_SERVER_SNAPSHOT&#x60; - 恢复服务器快照 * &#x60;BATCH_INSTALL_APP&#x60; - 批量安装应用</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobType
    {
        /// <summary>
        /// Enum CREATE_SERVER for value: CREATE_SERVER
        /// </summary>
        [EnumMember(Value = "CREATE_SERVER")]
        CREATE_SERVER = 1,

        /// <summary>
        /// Enum DELETE_SERVER for value: DELETE_SERVER
        /// </summary>
        [EnumMember(Value = "DELETE_SERVER")]
        DELETE_SERVER = 2,

        /// <summary>
        /// Enum UPDATE_FREEZE_STATUS for value: UPDATE_FREEZE_STATUS
        /// </summary>
        [EnumMember(Value = "UPDATE_FREEZE_STATUS")]
        UPDATE_FREEZE_STATUS = 3,

        /// <summary>
        /// Enum CREATE_SERVER_IMAGE for value: CREATE_SERVER_IMAGE
        /// </summary>
        [EnumMember(Value = "CREATE_SERVER_IMAGE")]
        CREATE_SERVER_IMAGE = 4,

        /// <summary>
        /// Enum REINSTALL_OS for value: REINSTALL_OS
        /// </summary>
        [EnumMember(Value = "REINSTALL_OS")]
        REINSTALL_OS = 5,

        /// <summary>
        /// Enum CHANGE_SERVER_IMAGE for value: CHANGE_SERVER_IMAGE
        /// </summary>
        [EnumMember(Value = "CHANGE_SERVER_IMAGE")]
        CHANGE_SERVER_IMAGE = 6,

        /// <summary>
        /// Enum REJOIN_DOMAIN for value: REJOIN_DOMAIN
        /// </summary>
        [EnumMember(Value = "REJOIN_DOMAIN")]
        REJOIN_DOMAIN = 7,

        /// <summary>
        /// Enum MIGRATE_SERVER for value: MIGRATE_SERVER
        /// </summary>
        [EnumMember(Value = "MIGRATE_SERVER")]
        MIGRATE_SERVER = 8,

        /// <summary>
        /// Enum UPGRADE_ACCESS_AGENT for value: UPGRADE_ACCESS_AGENT
        /// </summary>
        [EnumMember(Value = "UPGRADE_ACCESS_AGENT")]
        UPGRADE_ACCESS_AGENT = 9,

        /// <summary>
        /// Enum UPDATE_SERVER_TSVI for value: UPDATE_SERVER_TSVI
        /// </summary>
        [EnumMember(Value = "UPDATE_SERVER_TSVI")]
        UPDATE_SERVER_TSVI = 10,

        /// <summary>
        /// Enum SCHEDULED_TASK for value: SCHEDULED_TASK
        /// </summary>
        [EnumMember(Value = "SCHEDULED_TASK")]
        SCHEDULED_TASK = 11,

        /// <summary>
        /// Enum COLLECT_HDA_LOG for value: COLLECT_HDA_LOG
        /// </summary>
        [EnumMember(Value = "COLLECT_HDA_LOG")]
        COLLECT_HDA_LOG = 12,

        /// <summary>
        /// Enum COLLECT_APS_LOG for value: COLLECT_APS_LOG
        /// </summary>
        [EnumMember(Value = "COLLECT_APS_LOG")]
        COLLECT_APS_LOG = 13,

        /// <summary>
        /// Enum CREATE_SERVER_SNAPSHOT for value: CREATE_SERVER_SNAPSHOT
        /// </summary>
        [EnumMember(Value = "CREATE_SERVER_SNAPSHOT")]
        CREATE_SERVER_SNAPSHOT = 14,

        /// <summary>
        /// Enum DELETE_SERVER_SNAPSHOT for value: DELETE_SERVER_SNAPSHOT
        /// </summary>
        [EnumMember(Value = "DELETE_SERVER_SNAPSHOT")]
        DELETE_SERVER_SNAPSHOT = 15,

        /// <summary>
        /// Enum RESTORE_SERVER_SNAPSHOT for value: RESTORE_SERVER_SNAPSHOT
        /// </summary>
        [EnumMember(Value = "RESTORE_SERVER_SNAPSHOT")]
        RESTORE_SERVER_SNAPSHOT = 16,

        /// <summary>
        /// Enum BATCH_INSTALL_APP for value: BATCH_INSTALL_APP
        /// </summary>
        [EnumMember(Value = "BATCH_INSTALL_APP")]
        BATCH_INSTALL_APP = 17

    }

}
