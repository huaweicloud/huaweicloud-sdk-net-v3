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
    /// server的任务状态: * &#x60;scheduling&#x60; - 实例处于创建中，正在进行调度 * &#x60;block_device_mapping&#x60; - 实例处于创建中，正在准备磁盘 * &#x60;networking&#x60; - 实例处于创建中，正在准备网络 * &#x60;spawning&#x60; - 实例处于创建中，正在内部创建 * &#x60;rebooting&#x60; - 实例处于重启中 * &#x60;reboot_pending&#x60; - 实例处于重启中，正在下发重启。 * &#x60;reboot_started&#x60; - 实例处于重启中，开始内部重启 * &#x60;rebooting_hard&#x60; - 实例处于强制重启中 * &#x60;reboot_pending_hard&#x60; - 实例处于强制重启中，正在下发重启 * &#x60;reboot_started_hard&#x60; - 实例处于强制重启中，开始内部重启。 * &#x60;rebuilding&#x60; - 实例处于重建中。 * &#x60;rebuild_fail&#x60; - 实例重建失败。 * &#x60;updating_tsvi&#x60; - 实例处于虚拟会话IP更新中。 * &#x60;updating_tsvi_failed&#x60; - 实例虚拟会话IP更新失败。 * &#x60;rebuild_block_device_mapping&#x60; - 实例处于重建中，正在准备磁盘。 * &#x60;rebuild_spawning&#x60; - 实例处于重建中，正在内部重建。 * &#x60;migrating&#x60; - 实例处于热迁移中。 * &#x60;resize_prep&#x60; - 实例处于调整规格中，正在准备阶段。 * &#x60;resize_migrating&#x60; - 实例处于调整规格中，正在迁移阶段。 * &#x60;resize_migrated&#x60; - 实例处于调整规格中，已经完成迁移。 * &#x60;resize_finish&#x60; - 实例处于调整规格中，正在完成调整。 * &#x60;resize_reverting&#x60; - 实例处于调整规格中，正在回退调整。 * &#x60;powering-off&#x60; - 实例处于停止中。 * &#x60;powering-on&#x60; - 实例处于启动中。 * &#x60;deleting&#x60; - 实例处于删除中。 * &#x60;source_locking&#x60; - 资源锁定中 * &#x60;rejoining_domain&#x60; - 实例正在重新加域 * &#x60;delete_failed&#x60; - 实例删除失败 * &#x60;upgrading_access_agent&#x60; - 实例正在升级AccessAgent * &#x60;upgrad_access_agent_fail&#x60; - 实例升级AccessAgent失败 * &#x60;upgrad_access_agent_success&#x60; - 实例升级AccessAgent成功 * &#x60;updating_sid&#x60; - 实例处于创建中，等待更新SID * &#x60;migrate_failed&#x60; - 实例迁移失败 * &#x60;build_image&#x60; - 生成镜像中 * &#x60;build_snapshot&#x60; - 生成快照中 * &#x60;restore_snapshot&#x60; - 恢复快照中 * &#x60;null&#x60; - 未设置
    /// </summary>
    /// <value>server的任务状态: * &#x60;scheduling&#x60; - 实例处于创建中，正在进行调度 * &#x60;block_device_mapping&#x60; - 实例处于创建中，正在准备磁盘 * &#x60;networking&#x60; - 实例处于创建中，正在准备网络 * &#x60;spawning&#x60; - 实例处于创建中，正在内部创建 * &#x60;rebooting&#x60; - 实例处于重启中 * &#x60;reboot_pending&#x60; - 实例处于重启中，正在下发重启。 * &#x60;reboot_started&#x60; - 实例处于重启中，开始内部重启 * &#x60;rebooting_hard&#x60; - 实例处于强制重启中 * &#x60;reboot_pending_hard&#x60; - 实例处于强制重启中，正在下发重启 * &#x60;reboot_started_hard&#x60; - 实例处于强制重启中，开始内部重启。 * &#x60;rebuilding&#x60; - 实例处于重建中。 * &#x60;rebuild_fail&#x60; - 实例重建失败。 * &#x60;updating_tsvi&#x60; - 实例处于虚拟会话IP更新中。 * &#x60;updating_tsvi_failed&#x60; - 实例虚拟会话IP更新失败。 * &#x60;rebuild_block_device_mapping&#x60; - 实例处于重建中，正在准备磁盘。 * &#x60;rebuild_spawning&#x60; - 实例处于重建中，正在内部重建。 * &#x60;migrating&#x60; - 实例处于热迁移中。 * &#x60;resize_prep&#x60; - 实例处于调整规格中，正在准备阶段。 * &#x60;resize_migrating&#x60; - 实例处于调整规格中，正在迁移阶段。 * &#x60;resize_migrated&#x60; - 实例处于调整规格中，已经完成迁移。 * &#x60;resize_finish&#x60; - 实例处于调整规格中，正在完成调整。 * &#x60;resize_reverting&#x60; - 实例处于调整规格中，正在回退调整。 * &#x60;powering-off&#x60; - 实例处于停止中。 * &#x60;powering-on&#x60; - 实例处于启动中。 * &#x60;deleting&#x60; - 实例处于删除中。 * &#x60;source_locking&#x60; - 资源锁定中 * &#x60;rejoining_domain&#x60; - 实例正在重新加域 * &#x60;delete_failed&#x60; - 实例删除失败 * &#x60;upgrading_access_agent&#x60; - 实例正在升级AccessAgent * &#x60;upgrad_access_agent_fail&#x60; - 实例升级AccessAgent失败 * &#x60;upgrad_access_agent_success&#x60; - 实例升级AccessAgent成功 * &#x60;updating_sid&#x60; - 实例处于创建中，等待更新SID * &#x60;migrate_failed&#x60; - 实例迁移失败 * &#x60;build_image&#x60; - 生成镜像中 * &#x60;build_snapshot&#x60; - 生成快照中 * &#x60;restore_snapshot&#x60; - 恢复快照中 * &#x60;null&#x60; - 未设置</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppServerTaskStatus
    {
        /// <summary>
        /// Enum SCHEDULING for value: scheduling
        /// </summary>
        [EnumMember(Value = "scheduling")]
        SCHEDULING = 1,

        /// <summary>
        /// Enum BLOCK_DEVICE_MAPPING for value: block_device_mapping
        /// </summary>
        [EnumMember(Value = "block_device_mapping")]
        BLOCK_DEVICE_MAPPING = 2,

        /// <summary>
        /// Enum NETWORKING for value: networking
        /// </summary>
        [EnumMember(Value = "networking")]
        NETWORKING = 3,

        /// <summary>
        /// Enum SPAWNING for value: spawning
        /// </summary>
        [EnumMember(Value = "spawning")]
        SPAWNING = 4,

        /// <summary>
        /// Enum REBOOTING for value: rebooting
        /// </summary>
        [EnumMember(Value = "rebooting")]
        REBOOTING = 5,

        /// <summary>
        /// Enum REBOOT_PENDING for value: reboot_pending
        /// </summary>
        [EnumMember(Value = "reboot_pending")]
        REBOOT_PENDING = 6,

        /// <summary>
        /// Enum REBOOTING_HARD for value: rebooting_hard
        /// </summary>
        [EnumMember(Value = "rebooting_hard")]
        REBOOTING_HARD = 7,

        /// <summary>
        /// Enum REBOOT_PENDING_HARD for value: reboot_pending_hard
        /// </summary>
        [EnumMember(Value = "reboot_pending_hard")]
        REBOOT_PENDING_HARD = 8,

        /// <summary>
        /// Enum REBOOT_STARTED_HARD for value: reboot_started_hard
        /// </summary>
        [EnumMember(Value = "reboot_started_hard")]
        REBOOT_STARTED_HARD = 9,

        /// <summary>
        /// Enum REBUILDING for value: rebuilding
        /// </summary>
        [EnumMember(Value = "rebuilding")]
        REBUILDING = 10,

        /// <summary>
        /// Enum REBUILD_FAIL for value: rebuild_fail
        /// </summary>
        [EnumMember(Value = "rebuild_fail")]
        REBUILD_FAIL = 11,

        /// <summary>
        /// Enum UPDATING_TSVI for value: updating_tsvi
        /// </summary>
        [EnumMember(Value = "updating_tsvi")]
        UPDATING_TSVI = 12,

        /// <summary>
        /// Enum UPDATING_TSVI_FAILED for value: updating_tsvi_failed
        /// </summary>
        [EnumMember(Value = "updating_tsvi_failed")]
        UPDATING_TSVI_FAILED = 13,

        /// <summary>
        /// Enum REBUILD_BLOCK_DEVICE_MAPPING for value: rebuild_block_device_mapping
        /// </summary>
        [EnumMember(Value = "rebuild_block_device_mapping")]
        REBUILD_BLOCK_DEVICE_MAPPING = 14,

        /// <summary>
        /// Enum REBUILD_SPAWNING for value: rebuild_spawning
        /// </summary>
        [EnumMember(Value = "rebuild_spawning")]
        REBUILD_SPAWNING = 15,

        /// <summary>
        /// Enum MIGRATING for value: migrating
        /// </summary>
        [EnumMember(Value = "migrating")]
        MIGRATING = 16,

        /// <summary>
        /// Enum RESIZE_PREP for value: resize_prep
        /// </summary>
        [EnumMember(Value = "resize_prep")]
        RESIZE_PREP = 17,

        /// <summary>
        /// Enum RESIZE_MIGRATING for value: resize_migrating
        /// </summary>
        [EnumMember(Value = "resize_migrating")]
        RESIZE_MIGRATING = 18,

        /// <summary>
        /// Enum RESIZE_MIGRATED for value: resize_migrated
        /// </summary>
        [EnumMember(Value = "resize_migrated")]
        RESIZE_MIGRATED = 19,

        /// <summary>
        /// Enum RESIZE_FINISH for value: resize_finish
        /// </summary>
        [EnumMember(Value = "resize_finish")]
        RESIZE_FINISH = 20,

        /// <summary>
        /// Enum RESIZE_REVERTING for value: resize_reverting
        /// </summary>
        [EnumMember(Value = "resize_reverting")]
        RESIZE_REVERTING = 21,

        /// <summary>
        /// Enum POWERING_OFF for value: powering-off
        /// </summary>
        [EnumMember(Value = "powering-off")]
        POWERING_OFF = 22,

        /// <summary>
        /// Enum POWERING_ON for value: powering-on
        /// </summary>
        [EnumMember(Value = "powering-on")]
        POWERING_ON = 23,

        /// <summary>
        /// Enum DELETING for value: deleting
        /// </summary>
        [EnumMember(Value = "deleting")]
        DELETING = 24,

        /// <summary>
        /// Enum REJOINING_DOMAIN for value: rejoining_domain
        /// </summary>
        [EnumMember(Value = "rejoining_domain")]
        REJOINING_DOMAIN = 25,

        /// <summary>
        /// Enum SOURCE_LOCKING for value: source_locking
        /// </summary>
        [EnumMember(Value = "source_locking")]
        SOURCE_LOCKING = 26,

        /// <summary>
        /// Enum DELETE_FAILED for value: delete_failed
        /// </summary>
        [EnumMember(Value = "delete_failed")]
        DELETE_FAILED = 27,

        /// <summary>
        /// Enum UPDATING_SID for value: updating_sid
        /// </summary>
        [EnumMember(Value = "updating_sid")]
        UPDATING_SID = 28,

        /// <summary>
        /// Enum UPGRADING_ACCESS_AGENT for value: upgrading_access_agent
        /// </summary>
        [EnumMember(Value = "upgrading_access_agent")]
        UPGRADING_ACCESS_AGENT = 29,

        /// <summary>
        /// Enum UPGRAD_ACCESS_AGENT_FAIL for value: upgrad_access_agent_fail
        /// </summary>
        [EnumMember(Value = "upgrad_access_agent_fail")]
        UPGRAD_ACCESS_AGENT_FAIL = 30,

        /// <summary>
        /// Enum UPGRAD_ACCESS_AGENT_SUCCESS for value: upgrad_access_agent_success
        /// </summary>
        [EnumMember(Value = "upgrad_access_agent_success")]
        UPGRAD_ACCESS_AGENT_SUCCESS = 31,

        /// <summary>
        /// Enum MIGRATE_FAILED for value: migrate_failed
        /// </summary>
        [EnumMember(Value = "migrate_failed")]
        MIGRATE_FAILED = 32,

        /// <summary>
        /// Enum BUILD_IMAGE for value: build_image
        /// </summary>
        [EnumMember(Value = "build_image")]
        BUILD_IMAGE = 33,

        /// <summary>
        /// Enum BUILD_SNAPSHOT for value: build_snapshot
        /// </summary>
        [EnumMember(Value = "build_snapshot")]
        BUILD_SNAPSHOT = 34,

        /// <summary>
        /// Enum RESTORE_SNAPSHOT for value: restore_snapshot
        /// </summary>
        [EnumMember(Value = "restore_snapshot")]
        RESTORE_SNAPSHOT = 35,

        /// <summary>
        /// Enum NULL for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        NULL = 36

    }

}
