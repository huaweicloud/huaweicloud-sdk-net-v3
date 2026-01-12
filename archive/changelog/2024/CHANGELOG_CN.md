# 3.1.127 2024-12-26

### HuaweiCloud SDK CBR

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListVault**
    - 响应参数变更
      - `+ vaults.billing.object_type: enum value [turbo]`
      - `+ vaults.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **CreateVault**
    - 响应参数变更
      - `+ vault.billing.object_type: enum value [turbo]`
      - `+ vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ShowVault**
    - 响应参数变更
      - `+ vault.billing.object_type: enum value [turbo]`
      - `+ vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **UpdateVault**
    - 响应参数变更
      - `+ vault.billing.object_type: enum value [turbo]`
      - `+ vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ListExternalVault**
    - 响应参数变更
      - `+ vaults.billing.object_type: enum value [turbo]`
      - `+ vaults.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ListProtectable**
    - 响应参数变更
      - `+ instances.protectable.vault.billing.object_type: enum value [turbo]`
      - `+ instances.protectable.vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ShowProtectable**
    - 响应参数变更
      - `+ instance.protectable.vault.billing.object_type: enum value [turbo]`
      - `+ instance.protectable.vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ShowVaultResourceInstances**
    - 请求参数变更
      - `+ object_type: enum value [turbo,workspace,vmware,rds,file]`
    - 响应参数变更
      - `+ resources.resource_detail.vault.billing.object_type: enum value [turbo]`
      - `+ resources.resource_detail.vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`

### HuaweiCloud SDK CFW

- _接口版本_
  - V1
- _新增特性_
  - 支持以下接口：
    - `ShowDomainSetDetail`
    - `ListDomainParseIp`
    - `BatchDeleteDomainSet`
    - `ListRegions`
    - `ShowImportStatus`
    - `ShowAntiVirusSwitch`
    - `UpdateAntiVirusSwitch`
    - `ShowAntiVirusRule`
    - `UpdateAntiVirusRule`
    - `ShowAlarmConfig`
    - `UpdateAlarmConfig`
    - `ListAlarmWhitelist`
    - `SwitchAutoProtectStatus`
    - `ShowAutoProtectStatus`
    - `ListProjectTags`
    - `ChangeIpsRuleMode`
    - `UpdateAdvancedIpsRule`
    - `ListIpsRules`
    - `ListIpsRules1`
    - `ShowIpsUpdateTime`
    - `ListCustomerIps`
    - `ListResourceTags`
    - `SaveTags`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **AllowDbRolePrivileges**
    - 请求参数变更
      - `+ user.name`
      - `+ user.schema`
      - `+ user.readonly`
      - `+ user.default_privilege_grantee`
      - `* user: object -> object<GaussDBforOpenGaussRoleAttributes>`
  - **ListDatabaseRoles**
    - 响应参数变更
      - `* total_count: int64 -> int32`
      - `+ roles.attribute.rolsuper`
      - `+ roles.attribute.rolinherit`
      - `+ roles.attribute.rolcreaterole`
      - `+ roles.attribute.rolcreatedb`
      - `+ roles.attribute.rolcanlogin`
      - `+ roles.attribute.rolconnlimit`
      - `+ roles.attribute.rolreplication`
      - `+ roles.attribute.rolbypassrls`
      - `+ roles.attribute.rolpassworddeadline`
      - `* roles.attribute: object -> object<GaussDBListDatabaseRolesPriv>`

### HuaweiCloud SDK IMS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateImage**
    - 请求参数变更
      - `+ hw_firmware_type`
  - **ImportImageQuick**
    - 请求参数变更
      - `+ hw_firmware_type`

### HuaweiCloud SDK LTS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListLogStreams**
    - 请求参数变更
      - `- offset`
      - `- limit`
  - **CreateLogGroup**
    - 请求参数变更
      - `+ log_group_name_alias`
  - **UpdateLogStream**
    - 请求参数变更
      - `- ttl_in_days: enum value [7]`
  - **UpdateTransfer**
    - 请求参数变更
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
    - 响应参数变更
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
  - **CreateTransfer**
    - 请求参数变更
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
    - 响应参数变更
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
  - **DeleteTransfer**
    - 响应参数变更
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
  - **ListTransfers**
    - 响应参数变更
      - `+ log_transfers.log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.invalid_field_value`
  - **UpdateAccessConfig**
    - 请求参数变更
      - `+ access_config_name`

### HuaweiCloud SDK RDS

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`ListDrInfos`
- _解决问题_
  - 无
- _特性变更_
  - **ListUpdateBackupEnhancePolicy**
    - 响应参数变更
      - `* policies.retention_days: string -> int32`

### HuaweiCloud SDK VPCEP

- _接口版本_
  - V1
- _新增特性_
  - 支持接口`UpgradeEndpointService`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.126 2024-12-19

### HuaweiCloud SDK AAD

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`AddWafWhiteIpRule`、`DeleteWafWhiteIpRule`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK AS

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListScalingActivityLogs**
    - 响应参数变更
      - `+ scaling_activity_log.status: enum value [DOING]`
      - `- scaling_activity_log.status: enum value [DING]`
  - **ListScalingActivityV2Logs**
    - 响应参数变更
      - `+ scaling_activity_log.status: enum value [DOING]`
      - `- scaling_activity_log.status: enum value [DING]`

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **UpdateAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **RollbackAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **ShowAutopilotAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **UpdateAutopilotAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **RollbackAutopilotAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **CreateAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **ListAddonInstances**
    - 响应参数变更
      - `+ items.status.currentVersion.supportVersions.category`
  - **ListAddonTemplates**
    - 响应参数变更
      - `+ items.spec.versions.supportVersions.category`
  - **CreateAutopilotAddonInstance**
    - 响应参数变更
      - `+ status.currentVersion.supportVersions.category`
  - **ListAutopilotAddonInstances**
    - 响应参数变更
      - `+ items.status.currentVersion.supportVersions.category`
  - **ListAutopilotAddonTemplates**
    - 响应参数变更
      - `+ items.spec.versions.supportVersions.category`

### HuaweiCloud SDK DCS

- _接口版本_
  - V2
- _新增特性_
  - 支持以下接口：
    - `ShowBandwidths`
    - `UpdateBandwidth`
    - `ShowInstanceBandwidthAutoScalingPolicy`
    - `UpdateInstanceBandwidthAutoScalingPolicy`
    - `DeleteInstanceBandwidthAutoScalingPolicy`
    - `UpdatePublicIp`
    - `DeletePublicIp`
    - `ChangeNodesStartStopStatus`
    - `ShowInstanceVersion`
    - `UpgradeInstanceMinorVersion`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK EVS

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`UnsubscribePostpaidVolume`
- _解决问题_
  - 无
- _特性变更_
  - **CinderListQuotas**
    - 响应参数变更
      - `+ quota_set.gigabytes_ESSD`
      - `+ quota_set.snapshots_ESSD`
      - `+ quota_set.volumes_ESSD`

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `ListRestorableInstancesDetails`
    - `ListRecycleInstancesDetails`
    - `ShowParameterGroupDetail`
    - `ShowSourceInstanceDetail`
    - `AllowDbRolePrivileges`
    - `ListDatabaseRoles`
    - `CreateDbRole`
    - `ListDatastoresDetails`
    - `ListDatabaseInstances`
    - `ListParameterGroupTemplates`
    - `ShowInstanceParamGroupDetail`
    - `ShowUpgradeCandidateVersionsDetails`
    - `BatchShowUpgradeCandidateVersions`
    - `ListFlavorsDetails`
    - `ListBackupsDetails`
    - `SyncLimitData`
    - `DeleteDatabaseSchema`
    - `CreateDatabaseInstance`
- _解决问题_
  - 无
- _特性变更_
  - **ShowUpgradeCandidateVersions**
    - 响应参数变更
      - `* hotfix_upgrade_infos: object<HotfixUpgradeInfos> -> list<HotfixUpgradeInfos>`
      - `* hotfix_rollback_infos: object<HotfixRollbackInfos> -> list<HotfixRollbackInfos>`

### HuaweiCloud SDK IMS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ImportImageQuick**
    - 请求参数变更
      - `+ license_type`

### HuaweiCloud SDK OCR

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeAutoClassification**
    - 请求参数变更
      - `+ pdf_page_number`
  - **RecognizeSmartDocumentRecognizer**
    - 请求参数变更
      - `+ erase_seal`

### HuaweiCloud SDK RDS

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`ListUpdateBackupEnhancePolicy`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.125 2024-12-12

### HuaweiCloud SDK AOS

- _接口版本_
  - V1
- _新增特性_
  - 支持以下接口：
    - `ListPrivateModules`
    - `CreatePrivateModule`
    - `DeletePrivateModule`
    - `ShowPrivateModuleMetadata`
    - `UpdatePrivateModuleMetadata`
    - `ListPrivateModuleVersions`
    - `CreatePrivateModuleVersion`
    - `ShowPrivateModuleVersionContent`
    - `DeletePrivateModuleVersion`
    - `ShowPrivateModuleVersionMetadata`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`SyncNodePool`

### HuaweiCloud SDK CDN

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.cache_rules.force_cache`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.cache_rules.force_cache`

### HuaweiCloud SDK CSMS

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListUsers**
    - 请求参数变更
      - `+ user_info`
      - `- user_name`

### HuaweiCloud SDK DDS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ResizeInstance**
    - 请求参数变更
      - `+ resize.target_ids`

### HuaweiCloud SDK GaussDB

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateStarrocksInstance**
    - 请求参数变更
      - `+ pay_info`
      - `+ region_code`

### HuaweiCloud SDK LTS

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`ListLogContext`
- _解决问题_
  - 无
- _特性变更_
  - **CreateLogStreamIndex**
    - 请求参数变更
      - `+ fields.ltsSubFieldsInfoList`
      - `+ fields.fieldType: enum value [json]`
  - **ListAccessConfig**
    - 响应参数变更
      - `+ result.access_config_detail.repeat_collect`
      - `+ result.access_config_detail.system_fields`
      - `+ result.access_config_detail.custom_key_value`
      - `+ result.access_config_detail.includeLabelsLogical`
      - `+ result.access_config_detail.excludeLabelsLogical`
      - `+ result.access_config_detail.includeK8sLabelsLogical`
      - `+ result.access_config_detail.excludeK8sLabelsLogical`
      - `+ result.access_config_detail.includeEnvsLogical`
      - `+ result.access_config_detail.excludeEnvsLogical`
  - **UpdateAccessConfig**
    - 请求参数变更
      - `+ access_config_detail.system_fields`
      - `+ access_config_detail.custom_key_value`
      - `+ access_config_detail.includeLabelsLogical`
      - `+ access_config_detail.excludeLabelsLogical`
      - `+ access_config_detail.includeK8sLabelsLogical`
      - `+ access_config_detail.excludeK8sLabelsLogical`
      - `+ access_config_detail.includeEnvsLogical`
      - `+ access_config_detail.excludeEnvsLogical`
    - 响应参数变更
      - `+ access_config_detail.repeat_collect`
      - `+ access_config_detail.system_fields`
      - `+ access_config_detail.custom_key_value`
      - `+ access_config_detail.includeLabelsLogical`
      - `+ access_config_detail.excludeLabelsLogical`
      - `+ access_config_detail.includeK8sLabelsLogical`
      - `+ access_config_detail.excludeK8sLabelsLogical`
      - `+ access_config_detail.includeEnvsLogical`
      - `+ access_config_detail.excludeEnvsLogical`
  - **CreateAccessConfig**
    - 请求参数变更
      - `+ access_config_detail.repeat_collect`
      - `+ access_config_detail.system_fields`
      - `+ access_config_detail.custom_key_value`
      - `+ access_config_detail.includeLabelsLogical`
      - `+ access_config_detail.excludeLabelsLogical`
      - `+ access_config_detail.includeK8sLabelsLogical`
      - `+ access_config_detail.excludeK8sLabelsLogical`
      - `+ access_config_detail.includeEnvsLogical`
      - `+ access_config_detail.excludeEnvsLogical`
    - 响应参数变更
      - `+ access_config_detail.repeat_collect`
      - `+ access_config_detail.system_fields`
      - `+ access_config_detail.custom_key_value`
      - `+ access_config_detail.includeLabelsLogical`
      - `+ access_config_detail.excludeLabelsLogical`
      - `+ access_config_detail.includeK8sLabelsLogical`
      - `+ access_config_detail.excludeK8sLabelsLogical`
      - `+ access_config_detail.includeEnvsLogical`
      - `+ access_config_detail.excludeEnvsLogical`
  - **DeleteAccessConfig**
    - 响应参数变更
      - `+ result.access_config_detail.repeat_collect`
      - `+ result.access_config_detail.system_fields`
      - `+ result.access_config_detail.custom_key_value`
      - `+ result.access_config_detail.includeLabelsLogical`
      - `+ result.access_config_detail.excludeLabelsLogical`
      - `+ result.access_config_detail.includeK8sLabelsLogical`
      - `+ result.access_config_detail.excludeK8sLabelsLogical`
      - `+ result.access_config_detail.includeEnvsLogical`
      - `+ result.access_config_detail.excludeEnvsLogical`

# 3.1.124 2024-12-10

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpgradeNodePool**
    - 响应参数变更
      - `+ jobid`
      - `- metadata`
      - `- apiVersion`
      - `- kind`
      - `- spec`
      - `- status`

### HuaweiCloud SDK CSMS

- _接口版本_
  - V1
- _新增特性_
  - 支持以下接口：
    - `ListUsers`
    - `ListGrants`
    - `UpdateGrant`
    - `CreateGrants`
    - `DeleteGrant`
    - `GenerateRandomPassword`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DBSS

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListRdsDatabases**
    - 请求参数变更
      - `+ db_type: enum value [ORACLE,DAMENG,KINGBASE]`
  - **SwitchAuditDatabase**
    - 响应参数变更
      - `+ status`
      - `- result`

### HuaweiCloud SDK IMS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListImages**
    - 响应参数变更
      - `+ images.__support_kvm_hi1822_hisriov`
      - `+ images.__support_kvm_hi1822_hivirtionet`
  - **UpdateImage**
    - 响应参数变更
      - `+ __support_kvm_hi1822_hisriov`
      - `+ __support_kvm_hi1822_hivirtionet`

### HuaweiCloud SDK SWR

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`ShowShareFeatureGates`、`ShowDomainResourceReports`、`ShowDomainOverview`、`CreateRepoTag`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.123 2024-12-05

### HuaweiCloud SDK AOS

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **EstimateExecutionPlanPrice**
    - 响应参数变更
      - `+ items.resource_price.best_discount_type`
      - `+ items.resource_price.best_discount_price`
      - `+ items.resource_price.official_website_discount_price`

### HuaweiCloud SDK CES

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAlarmHistories**
    - 请求参数变更
      - `+ record_id`

### HuaweiCloud SDK CTS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListTraces**
    - 响应参数变更
      - `+ traces.read_only`
      - `+ traces.operation_id`

### HuaweiCloud SDK DDS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowInstanceConfigurationModifyHistory**
    - 请求参数变更
      - `+ entity_id`

### HuaweiCloud SDK DRS

- _接口版本_
  - V5
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.compare_result.data_compare_task_list.dynamic_compare_delay`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.compare_result.data_compare_task_list.dynamic_compare_delay`

### HuaweiCloud SDK FunctionGraph

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAsyncInvocations**
    - 响应参数变更
      - `* invocations.end_time: date-time -> string`
  - **ListActiveAsyncInvocations**
    - 响应参数变更
      - `* invocations.end_time: date-time -> string`

### HuaweiCloud SDK GaussDBforNoSQL

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `SwitchOver`
    - `BatchDeleteManualBackup`
    - `ShowDisasterRecoverySettings`
    - `SetDisasterRecoverySettings`
    - `ShowRedisHotKeys`
    - `ShowRedisDisabledCommands`
    - `SaveRedisDisabledCommands`
    - `DeleteRedisDisabledCommands`
    - `ListInstanceSessions`
    - `ClearInstanceSessions`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IAM

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`KeystoneListFederationProjects`
- _解决问题_
  - 无
- _特性变更_
  - **KeystoneListUsersForGroupByAdmin**
    - 响应参数变更
      - `- users.extra`
  - **UpdateUser**
    - 请求参数变更
      - `- user.create_time`
      - `- user.xdomain_id`
      - `- user.xdomain_type`
      - `- user.is_domain_owner`
    - 响应参数变更
      - `+ user.create_time`
      - `+ user.xdomain_id`
      - `+ user.xdomain_type`
      - `+ user.is_domain_owner`
  - **KeystoneUpdateUserByAdmin**
    - 响应参数变更
      - `- user.extra`
  - **CreateUnscopedTokenWithIdToken**
    - 响应参数变更
      - `* token.catalog: object -> list<object>`

# 3.1.122 2024-11-28

### HuaweiCloud SDK CBR

- _接口版本_
  - V1
- _新增特性_
  - 支持接口`ChangeOrder`
- _解决问题_
  - 无
- _特性变更_
  - **AddAgentPath**
    - 请求参数变更
      - `+ exclude_path`
  - **AddMember**
    - 请求参数变更
      - `+ domains`
  - **ShowAgent**
    - 响应参数变更
      - `+ agent.paths.exclude_paths`
  - **UpdateAgent**
    - 响应参数变更
      - `+ agent.paths.exclude_paths`
  - **ListAgent**
    - 响应参数变更
      - `+ agents.paths.exclude_paths`
  - **RegisterAgent**
    - 响应参数变更
      - `+ agent.paths.exclude_paths`
  - **ShowBackup**
    - 响应参数变更
      - `+ backup.version`
      - `- backup.image_type: enum value [backup,replication]`
      - `- backup.resource_type: enum value [OS::Nova::Server,OS::Cinder::Volume,OS::Workspace::DesktopV2]`
  - **UpdateBackup**
    - 响应参数变更
      - `+ backup.version`
      - `- backup.image_type: enum value [backup,replication]`
      - `- backup.resource_type: enum value [OS::Nova::Server,OS::Cinder::Volume,OS::Workspace::DesktopV2]`
  - **ListBackups**
    - 响应参数变更
      - `+ backups.version`
      - `- backups.image_type: enum value [backup,replication]`
      - `- backups.resource_type: enum value [OS::Nova::Server,OS::Cinder::Volume,OS::Workspace::DesktopV2]`
  - **ListOrganizationPolicies**
    - 请求参数变更
      - `+ limit`
      - `+ offset`
  - **ListProtectable**
    - 请求参数变更
      - `+ protectable_type: enum value [turbo,workspace,workspace_v2]`

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowCluster**
    - 响应参数变更
      - `+ spec.encryptionConfig`
  - **UpdateCluster**
    - 响应参数变更
      - `+ spec.encryptionConfig`
  - **DeleteCluster**
    - 响应参数变更
      - `+ spec.encryptionConfig`
  - **ShowAutopilotCluster**
    - 响应参数变更
      - `- spec.deletionProtection`
  - **UpdateAutopilotCluster**
    - 响应参数变更
      - `- spec.deletionProtection`
  - **DeleteAutopilotCluster**
    - 响应参数变更
      - `- spec.deletionProtection`
  - **CreateCluster**
    - 请求参数变更
      - `+ spec.encryptionConfig`
    - 响应参数变更
      - `+ spec.encryptionConfig`
  - **ListClusters**
    - 响应参数变更
      - `+ items.spec.encryptionConfig`
  - **CreateAutopilotCluster**
    - 请求参数变更
      - `- spec.deletionProtection`
    - 响应参数变更
      - `- spec.deletionProtection`
  - **ListAutopilotClusters**
    - 响应参数变更
      - `- items.spec.deletionProtection`
  - **ShowNode**
    - 响应参数变更
      - `+ spec.extendParam.securityReinforcementType`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.extendParam.securityReinforcementType`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.extendParam.securityReinforcementType`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.extendParam.securityReinforcementType`
    - 响应参数变更
      - `+ spec.extendParam.securityReinforcementType`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.extendParam.securityReinforcementType`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **UpdateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.securityReinforcementType`
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **AddNode**
    - 请求参数变更
      - `+ nodeList.spec.securityReinforcementType`
  - **ResetNode**
    - 请求参数变更
      - `+ nodeList.spec.securityReinforcementType`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.nodeTemplate.extendParam.securityReinforcementType`

### HuaweiCloud SDK CSMS

- _接口版本_
  - V1
- _新增特性_
  - 支持接口`ListSecretTask`、`ShowAgency`、`CreateAgency`、`ShowSecretFunctionTemplates`
- _解决问题_
  - 无
- _特性变更_
  - **RotateSecret**
    - 响应参数变更
      - `+ rotation_task_id`
  - **ListSecrets**
    - 响应参数变更
      - `+ secrets.rotation_func_urn`
      - `+ secrets.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **CreateSecret**
    - 请求参数变更
      - `+ rotation_func_urn`
      - `+ secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
    - 响应参数变更
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **ShowSecret**
    - 响应参数变更
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **UpdateSecret**
    - 请求参数变更
      - `+ rotation_func_urn`
    - 响应参数变更
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **UploadSecretBlob**
    - 响应参数变更
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **DeleteSecretForSchedule**
    - 响应参数变更
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **RestoreSecret**
    - 响应参数变更
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **ListNotificationRecords**
    - 请求参数变更
      - `- limit`
      - `- marker`
    - 响应参数变更
      - `+ records.trigger_event_type: enum value [SECRET_VERSION_CREATED,SECRET_VERSION_EXPIRED,SECRET_ROTATED,SECRET_DELETED,SECRET_ROTATED_FAILED]`
      - `+ records.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
      - `+ records.notification_status: enum value [SUCCESS,FAIL,INVALID]`
  - **ListResourceInstances**
    - 响应参数变更
      - `+ resources.resource_detail.rotation_func_urn`
      - `+ resources.resource_detail.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **ListSecretEvents**
    - 响应参数变更
      - `+ events.event_types: enum value [SECRET_ROTATED_FAILED]`
  - **CreateSecretEvent**
    - 请求参数变更
      - `+ event_types: enum value [SECRET_VERSION_CREATED,SECRET_VERSION_EXPIRED,SECRET_ROTATED,SECRET_DELETED,SECRET_ROTATED_FAILED]`
    - 响应参数变更
      - `+ event.event_types: enum value [SECRET_ROTATED_FAILED]`
  - **ShowSecretEvent**
    - 响应参数变更
      - `+ event.event_types: enum value [SECRET_ROTATED_FAILED]`
  - **UpdateSecretEvent**
    - 请求参数变更
      - `+ event_types: enum value [SECRET_VERSION_CREATED,SECRET_VERSION_EXPIRED,SECRET_ROTATED,SECRET_DELETED,SECRET_ROTATED_FAILED]`
    - 响应参数变更
      - `+ event.event_types: enum value [SECRET_ROTATED_FAILED]`

### HuaweiCloud SDK GaussDB

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`ShowSlowLogStatistics`、`DownloadSlowLogFile`、`ShowMultiTenant`、`UpdateMultiTenant`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `ShowRedisPitrPolicy`
    - `SetRedisPitrPolicy`
    - `ListRedisPitrRestoreTime`
    - `ShowRedisPitrInfo`
    - `RestoreRedisPitr`
    - `StopBackup`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK KMS

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`AssociateAlias`、`ListAliases`、`CreateAlias`、`DeleteAlias`
- _解决问题_
  - 无
- _特性变更_
  - **ListSupportRegions**
    - 请求参数变更
      - `+ limit`
      - `+ offset`

### HuaweiCloud SDK KPS

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`BatchImportKeypair`、`BatchExportPrivateKey`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Live

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSingleStreamDetail**
    - 响应参数变更
      - `- audio_framerate`

### HuaweiCloud SDK OCR

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeGeneralText**
    - 请求参数变更
      - `+ pdf_page_number`

### HuaweiCloud SDK RDS

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`CopyDatabase`、`DeleteMsdtcLocalHost`
- _解决问题_
  - 无
- _特性变更_
  - **ListFlavorsResize**
    - 响应参数变更
      - `* flavor_groups.compute_flavors: object<ComputeFlavor> -> list<ComputeFlavor>`

### HuaweiCloud SDK VOD

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListTopStatistics**
    - 响应参数变更
      - `+ top_urls.duration_ms`
  - **ListAssetList**
    - 响应参数变更
      - `+ assets.duration_ms`
  - **ModifySubtitle**
    - 请求参数变更
      - `+ repackage_mode`
      - `+ delete_mode`
  - **ShowTakeOverAssetDetails**
    - 响应参数变更
      - `+ base_info.meta_data.duration_ms`
  - **PublishAssets**
    - 响应参数变更
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **UnpublishAssets**
    - 响应参数变更
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetMeta**
    - 响应参数变更
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetDetail**
    - 响应参数变更
      - `+ base_info.meta_data.duration_ms`
  - **ShowTakeOverTaskDetails**
    - 响应参数变更
      - `+ assets.base_info.meta_data.duration_ms`

# 3.1.121 2024-11-21

### HuaweiCloud SDK AOM

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **PushEvents**
    - 请求参数变更
      - `+ enterprise-project-id`
      - `- x-enterprise-prject-id`
  - **ListPromInstance**
    - 请求参数变更
      - `* Enterprise-Project-Id: optional -> required`

### HuaweiCloud SDK CloudRTC

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowUrlAuth`、`UpdateUrlAuth`

### HuaweiCloud SDK DDS

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `ValidateConfigurationName`
    - `ShowInstanceConfigurationModifyHistory`
    - `SetAutoEnlargePolicies`
    - `BatchDeleteBackup`
    - `ShowAutoEnlargePolicy`
    - `ListScheduledTasks`
    - `CancelScheduledTask`
    - `BatchUpgradeDatabaseVersion`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK EVS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ChangeVolumeChargeMode`、`UnsubscribePostpaidVolume`
  - **RetypeVolume**
    - 请求参数变更
      - `+ os-retype.iops`
      - `+ os-retype.throughput`

### HuaweiCloud SDK FunctionGraph

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowFunctionTrigger**
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`
  - **UpdateTrigger**
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`
  - **CreateFunctionTrigger**
    - 请求参数变更
      - `+ event_data.channel_id`
      - `+ event_data.event_types`
      - `+ event_data.status: enum value [ACTIVE,DISABLE]`
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`
  - **ListFunctionTriggers**
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`

### HuaweiCloud SDK GaussDBforNoSQL

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `ShowBackupPolicies`
    - `ApplyConfigurationToInstances`
    - `UpdateInstanceConfigurations`
    - `CreateDbCacheMapping`
    - `DeleteDbCacheMapping`
    - `UpdateDbCacheRule`
    - `CreateDbCacheRule`
    - `DeleteDbCacheRule`
    - `ListDbCacheMappings`
    - `ListDbCacheRules`
    - `ShowSecondLevelMonitoringStatus`
    - `SwitchSecondLevelMonitoring`
    - `SetInstanceDataDump`
    - `ListInstanceMaintenanceWindow`
    - `ModifyInstanceMaintenanceWindow`
    - `ListNosqlTaskList`
    - `CancelInstanceScheduleWindow`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateLimitTask**
    - 响应参数变更
      - `+ job_id`
      - `- jobId`
      - `* key_words: list<string> -> string`
  - **UpdateLimitTask**
    - 响应参数变更
      - `+ job_id`
      - `- jobId`

# 3.1.120 2024-11-14

### HuaweiCloud SDK AOM

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **PushEvents**
    - 请求参数变更
      - `+ enterprise-project-id`
      - `- x-enterprise-prject-id`
  - **ListPromInstance**
    - 请求参数变更
      - `* Enterprise-Project-Id: optional -> required`

### HuaweiCloud SDK CloudRTC

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowUrlAuth`、`UpdateUrlAuth`

### HuaweiCloud SDK DDS

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `ValidateConfigurationName`
    - `ShowInstanceConfigurationModifyHistory`
    - `SetAutoEnlargePolicies`
    - `BatchDeleteBackup`
    - `ShowAutoEnlargePolicy`
    - `ListScheduledTasks`
    - `CancelScheduledTask`
    - `BatchUpgradeDatabaseVersion`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK EVS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ChangeVolumeChargeMode`、`UnsubscribePostpaidVolume`
  - **RetypeVolume**
    - 请求参数变更
      - `+ os-retype.iops`
      - `+ os-retype.throughput`

### HuaweiCloud SDK FunctionGraph

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowFunctionTrigger**
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`
  - **UpdateTrigger**
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`
  - **CreateFunctionTrigger**
    - 请求参数变更
      - `+ event_data.channel_id`
      - `+ event_data.event_types`
      - `+ event_data.status: enum value [ACTIVE,DISABLE]`
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`
  - **ListFunctionTriggers**
    - 响应参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.channel_id`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
      - `+ event_data.event_types`

### HuaweiCloud SDK GaussDBforNoSQL

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `ShowBackupPolicies`
    - `ApplyConfigurationToInstances`
    - `UpdateInstanceConfigurations`
    - `CreateDbCacheMapping`
    - `DeleteDbCacheMapping`
    - `UpdateDbCacheRule`
    - `CreateDbCacheRule`
    - `DeleteDbCacheRule`
    - `ListDbCacheMappings`
    - `ListDbCacheRules`
    - `ShowSecondLevelMonitoringStatus`
    - `SwitchSecondLevelMonitoring`
    - `SetInstanceDataDump`
    - `ListInstanceMaintenanceWindow`
    - `ModifyInstanceMaintenanceWindow`
    - `ListNosqlTaskList`
    - `CancelInstanceScheduleWindow`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateLimitTask**
    - 响应参数变更
      - `+ job_id`
      - `- jobId`
      - `* key_words: list<string> -> string`
  - **UpdateLimitTask**
    - 响应参数变更
      - `+ job_id`
      - `- jobId`

# 3.1.119 2024-11-07

### HuaweiCloud SDK AAD

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpgradeInstanceSpec**
    - 请求参数变更
      - `+ upgrade_data.elastic_service_bandwidth_type`
      - `+ upgrade_data.elastic_service_bandwidth`

### HuaweiCloud SDK GaussDBforNoSQL

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`BatchUpgradeDatabaseVersion`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IoTDA

- _接口版本_
  - V5
- _新增特性_
  - 支持以下接口：
    - `ListAsyncHistoryCommands`
    - `CountAsyncHistoryCommands`
    - `ListFunctions`
    - `AddFunctions`
    - `DeleteFunctions`
    - `ListAsyncCommands`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK MPC

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateExtractTask**
    - 请求参数变更
      - `+ encryption`
  - **CreateTranscodingTask**
    - 请求参数变更
      - `+ av_parameters.video.crf`
      - `+ av_parameters.video.max_bitrate`
  - **ListTranscodingTask**
    - 响应参数变更
      - `+ task_array.av_parameters.video.crf`
      - `+ task_array.av_parameters.video.max_bitrate`
  - **CreateEditingJob**
    - 请求参数变更
      - `+ concats.av_parameters.video.crf`
      - `+ concats.av_parameters.video.max_bitrate`
  - **ListEditingJob**
    - 响应参数变更
      - `+ jobs.edit_task_req.concats.av_parameters.video.crf`
      - `+ jobs.edit_task_req.concats.av_parameters.video.max_bitrate`

### HuaweiCloud SDK VPCEP

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `* error: object<QueryError> -> list<QueryError>`

# 3.1.118 2024-10-31

### HuaweiCloud SDK CFW

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ChangeEastWestFirewallStatus**
    - 响应参数变更
      - `- trace_id`
      - `* data: object -> object<ChangeEastWestFirewallStatusResponseData>`
  - **AddServiceSet**
    - 响应参数变更
      - `+ data.name`
      - `* data: object -> object<ServiceSetId>`
  - **ListJob**
    - 响应参数变更
      - `- error_msg`
      - `- error_code`
      - `* data: object -> object<GetCreateFirewallJobResponseData>`
  - **ListAddressSets**
    - 请求参数变更
      - `+ address_type: enum value [0,1]`
  - **BatchUpdateAclRuleActions**
    - 请求参数变更
      - `+ fw_instance_id`
  - **ListDnsServers**
    - 请求参数变更
      - `* fw_instance_id: required -> optional`
  - **ChangeIpsSwitchStatus**
    - 请求参数变更
      - `- X-Language`
      - `- ips_type: enum value [1]`
  - **UpdateAclRuleOrder**
    - 响应参数变更
      - `- data.name`
      - `* data: object<RuleId> -> object<OrderRuleId>`
  - **AddBlackWhiteList**
    - 响应参数变更
      - `* data: object<IdObject> -> object<BlackWhiteListId>`
  - **UpdateBlackWhiteList**
    - 响应参数变更
      - `* data: object<IdObject> -> object<BlackWhiteListId>`
  - **DeleteBlackWhiteList**
    - 响应参数变更
      - `* data: object<IdObject> -> object<BlackWhiteListId>`
  - **UpdateServiceSet**
    - 响应参数变更
      - `+ data.name`
      - `* data: object -> object<ServiceSetId>`
  - **DeleteServiceSet**
    - 响应参数变更
      - `* data: object<IdObject> -> object<ServiceSetId>`
  - **DeleteServiceItem**
    - 响应参数变更
      - `* data: object<IdObject> -> object<DeleteServiceItemResponseBodyData>`
  - **ListEipCount**
    - 响应参数变更
      - `- data.object_id`
  - **ChangeEipStatus**
    - 响应参数变更
      - `+ data.fail_eip_list`
  - **DeleteAddressItem**
    - 响应参数变更
      - `* data: object<IdObject> -> object<AddressItemId>`
  - **AddAddressSet**
    - 请求参数变更
      - `- address_type: enum value [0,1]`
    - 响应参数变更
      - `* data: object<IdObject> -> object<AddressSetId>`
  - **ListAddressSetDetail**
    - 响应参数变更
      - `- data.address_type: enum value [0,1]`
  - **UpdateAddressSet**
    - 响应参数变更
      - `+ data.name`
  - **DeleteAddressSet**
    - 响应参数变更
      - `* data: object<IdObject> -> object<AddressSetId>`
  - **AddDomainSet**
    - 请求参数变更
      - `* fw_instance_id: optional -> required`
  - **DeleteDomains**
    - 请求参数变更
      - `+ fw_instance_id`
  - **ListCaptureTask**
    - 请求参数变更
      - `* fw_instance_id: optional -> required`
    - 响应参数变更
      - `* data: list<HttpQueryCaptureTaskResponseData> -> object<HttpQueryCaptureTaskResponseData>`
  - **CreateCaptureTask**
    - 响应参数变更
      - `* data: object<IdObject> -> object<CaptureTaskId>`
  - **DeleteCaptureTask**
    - 响应参数变更
      - `* data: object<IdObject> -> object<CaptureTaskId>`
  - **CancelCaptureTask**
    - 响应参数变更
      - `* data: object<IdObject> -> object<CaptureTaskId>`
  - **ListEastWestFirewall**
    - 响应参数变更
      - `- data.er_associated_subnet`
      - `- data.ew_vpc_route_limit`
      - `- data.firewall_associated_subnets.status`
      - `- data.er.state`
      - `- data.er.enterprise_project_id`
      - `- data.er.enable_ipv6`
      - `- data.inspection_vpc.status`
  - **AddAclRule**
    - 请求参数变更
      - `- rules.applicationsJsonString`
  - **UpdateAclRule**
    - 请求参数变更
      - `- sequence`
      - `- applicationsJsonString`
  - **ListAclRules**
    - 请求参数变更
      - `+ address_type: enum value [2]`
  - **ListEips**
    - 请求参数变更
      - `+ status: enum value [null,0,1]`
      - `+ sync: enum value [0,1]`
    - 响应参数变更
      - `- data.records.owner`
  - **AddAddressItem**
    - 请求参数变更
      - `- address_items.name`
    - 响应参数变更
      - `- data.items.name`
      - `* data.items: list<IdObject> -> list<AddressItemIdWithoutName>`
  - **ListDomains**
    - 响应参数变更
      - `- data.records.dns_ips`
  - **ListFirewallDetail**
    - 请求参数变更
      - `+ service_type: enum value [0,1]`
    - 响应参数变更
      - `- data.records.status: enum value [-1,0,1,2,3,4,5,6,7,8,9,10,11]`
  - **ListDomainSets**
    - 响应参数变更
      - `- data.records.message`

### HuaweiCloud SDK DRS

- _接口版本_
  - V5
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `- jobs.compare_result.data_compare_task_list.dynamic_compare_delay`
      - `* jobs.compare_result.data_compare_task_list.report_remain_seconds: string -> int64`
  - **ShowJobDetail**
    - 响应参数变更
      - `- job.compare_result.data_compare_task_list.dynamic_compare_delay`
      - `* job.compare_result.data_compare_task_list.report_remain_seconds: string -> int64`

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 支持以下接口：
    - `UpdateMysqlCompatibility`
    - `StartMysqlCompatibility`
    - `StopInstance`
    - `ListLimitTask`
    - `CreateLimitTask`
    - `ShowLimitTask`
    - `UpdateLimitTask`
    - `DeleteLimitTask`
    - `ListNodeLimitSqlModel`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK LTS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListLogStreams**
    - 响应参数变更
      - `+ log_streams.log_stream_name_alias`
      - `+ log_streams.whether_log_storage`
      - `+ log_streams.hot_cold_separation`
      - `+ log_streams.auth_web_tracking`
      - `+ log_streams.ttl_in_days`
      - `+ log_streams.hot_storage_days`
  - **ListLogStream**
    - 响应参数变更
      - `+ log_streams.log_stream_name_alias`
      - `+ log_streams.whether_log_storage`
      - `+ log_streams.hot_cold_separation`
      - `+ log_streams.auth_web_tracking`
      - `+ log_streams.ttl_in_days`
      - `+ log_streams.hot_storage_days`
  - **ListLogs**
    - 响应参数变更
      - `* analysisLogs: list<map<string, string>> -> list<object>`
  - **ShowNotificationTemplate**
    - 响应参数变更
      - `+ templates.topic`
  - **ListActiveOrHistoryAlarms**
    - 响应参数变更
      - `+ events.metadata.log_group_name`
      - `+ events.metadata.log_stream_name`
  - **DeleteActiveAlarms**
    - 请求参数变更
      - `+ events.metadata.log_group_name`
      - `+ events.metadata.log_stream_name`
  - **UpdateNotificationTemplate**
    - 请求参数变更
      - `+ templates.topic`
    - 响应参数变更
      - `+ templates.topic`
  - **CreateNotificationTemplate**
    - 请求参数变更
      - `+ templates.topic`
    - 响应参数变更
      - `+ templates.topic`
  - **ListNotificationTemplates**
    - 响应参数变更
      - `+ results.templates.topic`
  - **ListAccessConfig**
    - 响应参数变更
      - `+ processor_type`
      - `+ component_id`
      - `+ environment_id`
      - `+ processors`
      - `+ application_id`
      - `+ encoding_format`
      - `+ demo_log`
      - `+ incremental_collect`
      - `+ demo_fields`
      - `+ result.encoding_format`
      - `+ result.incremental_collect`
      - `+ result.processor_type`
      - `+ result.demo_log`
      - `+ result.demo_fields`
      - `+ result.processors`
      - `+ result.application_id`
      - `+ result.environment_id`
      - `+ result.component_id`
  - **UpdateAccessConfig**
    - 请求参数变更
      - `+ incremental_collect`
      - `+ encoding_format`
      - `+ processor_type`
      - `+ demo_log`
      - `+ demo_fields`
      - `+ processors`
      - `+ application_id`
      - `+ environment_id`
      - `+ component_id`
    - 响应参数变更
      - `+ processor_type`
      - `+ component_id`
      - `+ environment_id`
      - `+ processors`
      - `+ application_id`
      - `+ encoding_format`
      - `+ demo_log`
      - `+ incremental_collect`
      - `+ demo_fields`
  - **CreateAccessConfig**
    - 请求参数变更
      - `+ incremental_collect`
      - `+ encoding_format`
      - `+ processor_type`
      - `+ demo_log`
      - `+ demo_fields`
      - `+ processors`
      - `+ application_id`
      - `+ environment_id`
      - `+ component_id`
      - `+ access_config_type_source`
    - 响应参数变更
      - `+ processor_type`
      - `+ component_id`
      - `+ environment_id`
      - `+ processors`
      - `+ application_id`
      - `+ encoding_format`
      - `+ demo_log`
      - `+ incremental_collect`
      - `+ demo_fields`
  - **DeleteAccessConfig**
    - 响应参数变更
      - `+ processor_type`
      - `+ component_id`
      - `+ environment_id`
      - `+ processors`
      - `+ application_id`
      - `+ encoding_format`
      - `+ demo_log`
      - `+ incremental_collect`
      - `+ demo_fields`
      - `+ result.encoding_format`
      - `+ result.incremental_collect`
      - `+ result.processor_type`
      - `+ result.demo_log`
      - `+ result.demo_fields`
      - `+ result.processors`
      - `+ result.application_id`
      - `+ result.environment_id`
      - `+ result.component_id`

### HuaweiCloud SDK Moderation

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunCreateAudioStreamModerationJob**
    - 请求参数变更
      - `+ data.return_all_results`

### HuaweiCloud SDK OCR

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeSmartDocumentRecognizer**
    - 请求参数变更
      - `+ language`

### HuaweiCloud SDK RDS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListDbUsers**
    - 响应参数变更
      - `+ users.databases`
      - `+ users.hosts`
  - **ListSqlserverDbUsers**
    - 响应参数变更
      - `+ users.databases`
      - `+ users.hosts`

### HuaweiCloud SDK VOD

- _接口版本_
  - V1
- _新增特性_
  - 支持接口`ShowStorageModeType`、`UpdateStorageModeType`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.117 2024-10-24

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowCluster**
    - 响应参数变更
      - `+ spec.enableDistMgt`
  - **UpdateCluster**
    - 响应参数变更
      - `+ spec.enableDistMgt`
  - **DeleteCluster**
    - 响应参数变更
      - `+ spec.enableDistMgt`
  - **CreateCluster**
    - 请求参数变更
      - `+ spec.enableDistMgt`
    - 响应参数变更
      - `+ spec.enableDistMgt`
  - **ListClusters**
    - 响应参数变更
      - `+ items.spec.enableDistMgt`

### HuaweiCloud SDK CES

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateAgentInvocations**
    - 请求参数变更
      - `+ version`

### HuaweiCloud SDK DRS

- _接口版本_
  - V5
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.compare_result.data_compare_task_list.options`
      - `+ jobs.compare_result.data_compare_task_list.dynamic_compare_delay`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.compare_result.data_compare_task_list.options`
      - `+ job.compare_result.data_compare_task_list.dynamic_compare_delay`

### HuaweiCloud SDK GaussDB

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CheckTableConfig**
    - 请求参数变更
      - `+ target_database_name`
      - `+ is_create_task`

### HuaweiCloud SDK RAM

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **EnableOrganizationShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DisableOrganizationShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowOrganizationShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **AssociateResourceSharePermission**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DisassociateResourceSharePermission**
    - 请求参数变更
      - `+ X-Security-Token`
  - **AcceptResourceShareInvitation**
    - 请求参数变更
      - `+ X-Security-Token`
  - **RejectResourceShareInvitation**
    - 请求参数变更
      - `+ X-Security-Token`
  - **SearchResourceShareInvitation**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListPermissions**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowPermission**
    - 请求参数变更
      - `+ X-Security-Token`
  - **AssociateResourceShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DisassociateResourceShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **SearchResourceShareAssociations**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListResourceShareTags**
    - 请求参数变更
      - `+ X-Security-Token`
  - **SearchResourceShareCountByTags**
    - 请求参数变更
      - `+ X-Security-Token`
  - **BatchCreateResourceShareTags**
    - 请求参数变更
      - `+ X-Security-Token`
  - **BatchDeleteResourceShareTags**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListResourceSharePermissions**
    - 请求参数变更
      - `+ X-Security-Token`
  - **SearchSharedResources**
    - 请求参数变更
      - `+ X-Security-Token`
  - **SearchSharedPrincipals**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListResourceTypes**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListPermissionVersions**
    - 请求参数变更
      - `+ X-Security-Token`
  - **CreateResourceShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **SearchResourceShares**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DeleteResourceShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **UpdateResourceShare**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListResourceSharesByTags**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListQuota**
    - 请求参数变更
      - `+ X-Security-Token`

# 3.1.116 2024-10-17

### HuaweiCloud SDK CDN

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateDomain**
    - 请求参数变更
      - `+ domain.sources.http_port`
      - `+ domain.sources.https_port`

### HuaweiCloud SDK DBSS

- _接口版本_
  - V1
- _新增特性_
  - 支持以下接口：
    - `AddAuditDatabase`
    - `AddRdsDatabase`
    - `ListRdsDatabases`
    - `DeleteAuditDatabase`
    - `SwitchAuditDatabase`
    - `DownloadAuditAgent`
    - `DeleteAuditAgent`
    - `ListAuditSummaryInfos`
    - `StartAuditInstance`
    - `StopAuditInstance`
    - `RebootAuditInstance`
    - `UpdateAuditInstance`
    - `ListAuditAlarmLog`
    - `ListAuditSqls`
    - `ListAuditAgent`
    - `AddAuditAgent`
    - `DeleteInstances`
- _解决问题_
  - 无
- _特性变更_
  - **ShowAuditQuota**
    - 响应参数变更
      - `- quota`
  - **ListAuditRuleRisks**
    - 请求参数变更
      - `+ risk_levels: enum value [LOW,MEDIUM,HIGH,NO_RISK]`
    - 响应参数变更
      - `+ rules.rule_type`
  - **ListProjectResourceTags**
    - 请求参数变更
      - `+ resource_type: enum value [auditInstance]`
  - **BatchAddResourceTag**
    - 请求参数变更
      - `+ resource_type: enum value [auditInstance]`
      - `* tags: list<KeyValueBean> -> list<object>`
      - `* sys_tags: list<KeyValueBean> -> list<object>`
  - **BatchDeleteResourceTag**
    - 请求参数变更
      - `+ resource_type: enum value [auditInstance]`
      - `* tags: list<KeyValueBean> -> list<object>`
      - `* sys_tags: list<KeyValueBean> -> list<object>`
      - `* body: object<ResourceTagRequest> -> object<ResourceTagDeleteRequest>`
  - **UpdateAuditSecurityGroup**
    - 请求参数变更
      - `+ instance_id`
      - `- resource_id`
  - **SwitchAgent**
    - 请求参数变更
      - `+ status: enum value [0,1]`
  - **ListEcsSpecification**
    - 响应参数变更
      - `+ specification.az_type`
  - **ListAuditInstanceJobs**
    - 响应参数变更
      - `+ jobs.resource_id`
  - **ListAuditOperateLogs**
    - 请求参数变更
      - `+ action`
      - `- operate_name`
      - `+ result: enum value [success,fail]`
      - `+ time.time_range: enum value [HALF_HOUR, HOUR, THREE_HOUR, TWELVE_HOUR, DAY, WEEK, MONTH]`
  - **ListResourceInstanceByTag**
    - 请求参数变更
      - `+ resource_type: enum value [auditInstance]`
  - **CountResourceInstanceByTag**
    - 请求参数变更
      - `+ resource_type: enum value [auditInstance]`
  - **ListAuditDatabases**
    - 响应参数变更
      - `+ databases.database.rds_audit_switch_mismatch`
      - `+ databases.database.rds_id`
      - `+ databases.database.rds_obj_info`
      - `+ databases.database.dws_obj_info`
      - `+ databases.database.clouddb_obj_info`

### HuaweiCloud SDK ECS

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`NovaShowFlavorExtraSpecs`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.115 2024-10-10

### HuaweiCloud SDK AAD

- _接口版本_
  - V1
- _新增特性_
  - 支持接口`AssociateIpToPolicyAndPackage`、`DisassociateIpFromPolicyAndPackage`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAutopilotCluster**
    - 响应参数变更
      - `+ spec.deletionProtection`
  - **UpdateAutopilotCluster**
    - 响应参数变更
      - `+ spec.deletionProtection`
  - **DeleteAutopilotCluster**
    - 响应参数变更
      - `+ spec.deletionProtection`
  - **CreateAutopilotCluster**
    - 请求参数变更
      - `+ spec.deletionProtection`
    - 响应参数变更
      - `+ spec.deletionProtection`
  - **ListAutopilotClusters**
    - 响应参数变更
      - `+ items.spec.deletionProtection`

### HuaweiCloud SDK DRS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchListJobDetails**
    - 响应参数变更
      - `* results.node_num: string -> int32`

### HuaweiCloud SDK DRS

- _接口版本_
  - V5
- _新增特性_
  - 支持以下接口：
    - `ListReplicationJobs`
    - `CreateReplicationJob`
    - `ShowReplicationJob`
    - `UpdateReplicationJob`
    - `DeleteReplicationJob`
    - `ChangeToPeriod`
    - `ListConnections`
    - `CreateConnection`
    - `ModifyConnection`
    - `DeleteConnection`
    - `ListJobDdls`
    - `CleanAlarms`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK ELB

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListMembers**
    - 请求参数变更
      - `+ enterprise_project_id`

### HuaweiCloud SDK EVS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowVolume**
    - 响应参数变更
      - `- volume.snapshot_policy_id`
  - **ListVolumes**
    - 请求参数变更
      - `- snapshot_policy_id`
    - 响应参数变更
      - `- volumes.snapshot_policy_id`

### HuaweiCloud SDK GaussDB

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateStarrocksInstance**
    - 请求参数变更
      - `+ security_group_id`
  - **CheckStarrocksParams**
    - 响应参数变更
      - `+ differences`
      - `- check_starrocks_params_responce`

### HuaweiCloud SDK RDS

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`ShowRecoveryTimeWindow`、`UpdateToPeriod`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.114 2024-09-26

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
    - 响应参数变更
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.rootVolume.iops`
      - `+ items.spec.rootVolume.throughput`
      - `+ items.spec.storage.storageSelectors.matchLabels.iops`
      - `+ items.spec.storage.storageSelectors.matchLabels.throughput`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **UpdateNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **AddNode**
    - 请求参数变更
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.iops`
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.throughput`
  - **ResetNode**
    - 请求参数变更
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.iops`
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.throughput`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
    - 响应参数变更
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.nodeTemplate.rootVolume.iops`
      - `+ items.spec.nodeTemplate.rootVolume.throughput`
      - `+ items.spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ items.spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`

### HuaweiCloud SDK CES

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateAlarmRules**
    - 请求参数变更
      - `+ tags`

### HuaweiCloud SDK DDS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ResizeInstance**
    - 请求参数变更
      - `+ resize.target_type: enum value [config,readonly]`

### HuaweiCloud SDK Live

- _接口版本_
  - V1
- _新增特性_
  - 支持以下接口：
    - `ListHarvestTask`
    - `ModifyHarvestTask`
    - `CreateHarvestTask`
    - `DeleteHarvestTask`
    - `UpdateHarvestJobStatus`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VPCEP

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateEndpointService**
    - 请求参数变更
      - `+ snat_network_id`

# 3.1.113 2024-09-23

### HuaweiCloud SDK AOM

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEvents**
    - 响应参数变更
      - `* page_info.current_count: string -> int32`
  - **PushEvents**
    - 请求参数变更
      - `- events.event_sn`
      - `- events.arrives_at`
      - `- events.enterprise_project_id`
      - `- events.policy`

### HuaweiCloud SDK CDN

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateDomainMultiCertificates**
    - 请求参数变更
      - `+ https.scm_certificate_id`
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.user_agent_filter.include_empty`
      - `+ configs.https.scm_certificate_id`
      - `+ configs.https.certificates.certificate_source`
      - `+ configs.https.certificates.scm_certificate_id`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.user_agent_filter.include_empty`
      - `+ configs.https.scm_certificate_id`
      - `+ configs.https.certificates.certificate_source`
      - `+ configs.https.certificates.scm_certificate_id`

### HuaweiCloud SDK DDS

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`ListDatabases`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK ECS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListServersDetails**
    - 请求参数变更
      - `+ marker`

### HuaweiCloud SDK EVS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowVolume**
    - 响应参数变更
      - `+ volume.snapshot_policy_id`
  - **ListVolumes**
    - 请求参数变更
      - `+ snapshot_policy_id`
    - 响应参数变更
      - `+ volumes.snapshot_policy_id`

### HuaweiCloud SDK IAM

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAgencies**
    - 响应参数变更
      - `+ agencies.agency_urn`
  - **CreateAgency**
    - 请求参数变更
      - `- agency.duration: enum value [FOREVER,ONEDAY]`
    - 响应参数变更
      - `+ agency.agency_urn`
  - **ShowAgency**
    - 响应参数变更
      - `+ agency.agency_urn`
  - **UpdateAgency**
    - 请求参数变更
      - `- agency.duration: enum value [FOREVER,ONEDAY]`
    - 响应参数变更
      - `+ agency.agency_urn`

### HuaweiCloud SDK Organizations

- _接口版本_
  - V1
- _新增特性_
  - 支持接口`UpdateAccount`
- _解决问题_
  - 无
- _特性变更_
  - **LeaveOrganization**
    - 请求参数变更
      - `+ X-Security-Token`
  - **CloseAccount**
    - 请求参数变更
      - `+ X-Security-Token`
  - **RemoveAccount**
    - 请求参数变更
      - `+ X-Security-Token`
  - **MoveAccount**
    - 请求参数变更
      - `+ X-Security-Token`
  - **EnableTrustedService**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DisableTrustedService**
    - 请求参数变更
      - `+ X-Security-Token`
  - **RegisterDelegatedAdministrator**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DeregisterDelegatedAdministrator**
    - 请求参数变更
      - `+ X-Security-Token`
  - **AttachPolicy**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DetachPolicy**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowEffectivePolicies**
    - 请求参数变更
      - `+ X-Security-Token`
  - **UntagResource**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListServices**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DeleteOrganization**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowOrganization**
    - 请求参数变更
      - `+ X-Security-Token`
  - **CreateOrganization**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListOrganizationalUnits**
    - 请求参数变更
      - `+ X-Security-Token`
  - **CreateOrganizationalUnit**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DeleteOrganizationalUnit**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowOrganizationalUnit**
    - 请求参数变更
      - `+ X-Security-Token`
  - **UpdateOrganizationalUnit**
    - 请求参数变更
      - `+ X-Security-Token`
      - `- X-Auth-Token`
  - **ListAccounts**
    - 请求参数变更
      - `+ X-Security-Token`
      - `+ with_register_contact_info`
    - 响应参数变更
      - `+ accounts.mobile_phone`
      - `+ accounts.intl_number_prefix`
      - `+ accounts.email`
      - `+ accounts.description`
  - **CreateAccount**
    - 请求参数变更
      - `+ X-Security-Token`
      - `+ description`
  - **ShowAccount**
    - 请求参数变更
      - `+ X-Security-Token`
      - `+ with_register_contact_info`
    - 响应参数变更
      - `+ account.mobile_phone`
      - `+ account.intl_number_prefix`
      - `+ account.email`
      - `+ account.description`
  - **ListCreateAccountStatuses**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowCreateAccountStatus**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListCloseAccountStatuses**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListTrustedServices**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListDelegatedServices**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListDelegatedAdministrators**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListEntitiesForPolicy**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListTagsForResource**
    - 请求参数变更
      - `+ X-Security-Token`
  - **TagResource**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListEntities**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListTagPolicyServices**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListTagResources**
    - 请求参数变更
      - `+ X-Security-Token`
  - **CreateTagResource**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DeleteTagResource**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowResourceInstancesCount**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListResourceTags**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListRoots**
    - 请求参数变更
      - `+ X-Security-Token`
  - **InviteAccount**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshake.expired_at`
  - **ShowHandshake**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshake.expired_at`
  - **AcceptHandshake**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshake.expired_at`
  - **DeclineHandshake**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshake.expired_at`
  - **CancelHandshake**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshake.expired_at`
  - **ListReceivedHandshakes**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshakes.expired_at`
  - **ListHandshakes**
    - 请求参数变更
      - `+ X-Security-Token`
    - 响应参数变更
      - `+ handshakes.expired_at`
  - **ListPolicies**
    - 请求参数变更
      - `+ X-Security-Token`
  - **CreatePolicy**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DeletePolicy**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ShowPolicy**
    - 请求参数变更
      - `+ X-Security-Token`
  - **UpdatePolicy**
    - 请求参数变更
      - `+ X-Security-Token`
      - `- X-Auth-Token`
  - **EnablePolicyType**
    - 请求参数变更
      - `+ X-Security-Token`
  - **DisablePolicyType**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListResourceInstances**
    - 请求参数变更
      - `+ X-Security-Token`
  - **ListQuotas**
    - 请求参数变更
      - `+ X-Security-Token`

# 3.1.112 2024-09-12

### HuaweiCloud SDK AOM

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEvents**
    - 请求参数变更
      - `+ limit`
      - `+ marker`
    - 响应参数变更
      - `+ page_info`
      - `+ events.event_sn`
      - `+ events.arrives_at`
      - `+ events.enterprise_project_id`
      - `+ events.policy`
  - **PushEvents**
    - 请求参数变更
      - `- events`
      - `+ events.event_sn`
      - `+ events.arrives_at`
      - `+ events.enterprise_project_id`
      - `+ events.policy`
  - **DeletePromInstance**
    - 请求参数变更
      - `* Enterprise-Project-Id: optional -> required`

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`AddNodesToNodePool`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowResourceInstances`、`BatchCreateDeleteResourceTags`、`ShowResourceTags`、`ShowCustomizeClusterTagsByProjectId`

### HuaweiCloud SDK VPCEP

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListServiceDetails**
    - 响应参数变更
      - `+ ip`
  - **UpdateEndpointService**
    - 请求参数变更
      - `+ ip`
    - 响应参数变更
      - `+ ip`
  - **CreateEndpointService**
    - 请求参数变更
      - `+ ip`
    - 响应参数变更
      - `+ ip`
  - **ListEndpointService**
    - 请求参数变更
      - `+ net_type`
    - 响应参数变更
      - `+ endpoint_services.ip`

# 3.1.111 2024-09-05

### HuaweiCloud SDK BMS

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ChangeBaremetalServerName**
    - 响应参数变更
      - `* server.hostId: uuid -> string`

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`RevokeKubernetesClusterCert`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DNS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowResourceTag**
    - 响应参数变更
      - `- enterpriseProjectOrDefault`

### HuaweiCloud SDK ECS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListCloudServers**
    - 请求参数变更
      - `+ marker`
    - 响应参数变更
      - `- count`
      - `+ servers.launched_at`
      - `- servers.launched`
      - `+ servers.security_groups.id`
      - `+ servers.volumes_attached.size`
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`
      - `- servers.flavor.root_gb`
      - `- servers.flavor.ephemeral_gb`
      - `- servers.flavor.extra_specs`

### HuaweiCloud SDK FunctionGraph

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **InvokeFunction**
    - 请求参数变更
      - `+ X-Cff-Instance-Memory`
  - **AsyncInvokeFunction**
    - 请求参数变更
      - `+ X-Cff-Instance-Memory`

### HuaweiCloud SDK IAM

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAgencies**
    - 请求参数变更
      - `+ page`
      - `+ per_page`
  - **ShowDomainRoleAssignments**
    - 请求参数变更
      - `* page: string -> int32`
      - `* per_page: string -> int32`
  - **ListCustomPolicies**
    - 响应参数变更
      - `- roles.references`
      - `* roles: list<PolicyRoleResult> -> list<ListPolicyRoleResult>`
  - **CreateCloudServiceCustomPolicy**
    - 响应参数变更
      - `- role.references`
  - **UpdateCloudServiceCustomPolicy**
    - 响应参数变更
      - `- role.references`
  - **CreateAgencyCustomPolicy**
    - 响应参数变更
      - `- role.references`
  - **UpdateAgencyCustomPolicy**
    - 响应参数变更
      - `- role.references`

### HuaweiCloud SDK Live

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainHttpsCert**
    - 响应参数变更
      - `+ tls_certificate`
      - `+ gm_certificate`
  - **UpdateDomainHttpsCert**
    - 请求参数变更
      - `+ tls_certificate`
      - `+ gm_certificate`

### HuaweiCloud SDK VPC

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateSubNetworkInterface**
    - 请求参数变更
      - `- sub_network_interface.instance_id`
      - `- sub_network_interface.instance_type`
      - `- sub_network_interface.tags`
  - **BatchCreateSubNetworkInterface**
    - 请求参数变更
      - `- sub_network_interface.instance_id`
      - `- sub_network_interface.instance_type`
      - `- sub_network_interface.tags`

# 3.1.110 2024-08-29

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
    - 响应参数变更
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.nodeNicSpec.primaryNic.subnetList`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **UpdateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.nodeNicSpecUpdate`
    - 响应参数变更
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
    - 响应参数变更
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`

### HuaweiCloud SDK ECS

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`ListCloudServers`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK EIP

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListCommonPools**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **ListShareBandwidthTypes**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **ListTenantVpcIgws**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **CreateTenantVpcIgw**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **ShowInternalVpcIgw**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **UpdateTenantVpcIgw**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **ListEipBandwidths**
    - 请求参数变更
      - `+ fields`
  - **ListBandwidth**
    - 请求参数变更
      - `+ fields`
  - **ListPublicipPool**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **ShowPublicipPool**
    - 请求参数变更
      - `* fields: string -> list<string>`
  - **ListProjectGeipBindings**
    - 请求参数变更
      - `* fields: string -> list<string>`

### HuaweiCloud SDK EVS

- _接口版本_
  - V2
- _新增特性_
  - 支持接口`RetypeVolume`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK FunctionGraph

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowFunctionCode**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`
  - **UpdateFunctionCode**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`
  - **CreateFunction**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`
  - **ShowFunctionConfig**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`
  - **UpdateFunctionConfig**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`
  - **UpdateFunctionMaxInstanceConfig**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`
  - **CreateFunctionTrigger**
    - 请求参数变更
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
  - **CreateFunctionVersion**
    - 响应参数变更
      - `* dependencies.last_modified: date-time -> int64`

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`CreateGaussDbInstance`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateManualBackup**
    - 请求参数变更
      - `+ backup_database_individually`

### HuaweiCloud SDK VPC

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **AddSecurityGroups**
    - 响应参数变更
      - `+ port.extra_dhcp_opts.opt_name`
      - `+ port.extra_dhcp_opts.opt_value`
      - `* port.extra_dhcp_opts: list<object> -> list<ExtraDhcpOpt>`
  - **RemoveSecurityGroups**
    - 响应参数变更
      - `+ port.extra_dhcp_opts.opt_name`
      - `+ port.extra_dhcp_opts.opt_value`
      - `* port.extra_dhcp_opts: list<object> -> list<ExtraDhcpOpt>`

# 3.1.109 2024-08-22

### HuaweiCloud SDK CCE

- _接口版本_
  - V3
- _新增特性_
  - 支持接口`SyncNode`、`BatchSyncNodes`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DRS

- _接口版本_
  - V5
- _新增特性_
  - 支持接口`UploadUserJdbcDriver`、`SyncUserJdbcDriver`、`ListUserJdbcDrivers`、`DeleteUserJdbcDriver`
- _解决问题_
  - 无
- _特性变更_
  - **CreateJob**
    - 请求参数变更
      - `+ job.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ job.source_endpoint.db_type: enum value [mysql]`
    - 响应参数变更
      - `+ is_clone_job`
      - `+ create_time`
      - `+ name`
      - `+ id`
      - `+ status`
      - `- job`
  - **BatchCreateJobsAsync**
    - 请求参数变更
      - `+ jobs.policy_config.is_create_table_with_index`
      - `+ jobs.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ jobs.source_endpoint.db_type: enum value [mysql]`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.status: enum value [CREATING,CREATE_FAILED,CONFIGURATION,STARTJOBING,WAITING_FOR_START,START_JOB_FAILED,PAUSING,FULL_TRANSFER_STARTED,FULL_TRANSFER_FAILED,FULL_TRANSFER_COMPLETE,INCRE_TRANSFER_STARTED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_STARTED,RELEASE_RESOURCE_FAILED,RELEASE_RESOURCE_COMPLETE,REBUILD_NODE_STARTED,REBUILD_NODE_FAILED,CHANGE_JOB_STARTED,CHANGE_JOB_FAILED,DELETED,CHILD_TRANSFER_STARTING,CHILD_TRANSFER_STARTED,CHILD_TRANSFER_COMPLETE,CHILD_TRANSFER_FAILED,RELEASE_CHILD_TRANSFER_STARTED,RELEASE_CHILD_TRANSFER_COMPLETE,NODE_UPGRADE_START,NODE_UPGRADE_COMPLETE,NODE_UPGRADE_FAILED]`
      - `+ jobs.policy_config.is_create_table_with_index`
      - `+ jobs.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ jobs.source_endpoint.db_type: enum value [mysql]`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.params.policy_config.is_create_table_with_index`
      - `+ jobs.params.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ jobs.params.source_endpoint.db_type: enum value [mysql]`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.status: enum value [CREATING,CREATE_FAILED,CONFIGURATION,STARTJOBING,WAITING_FOR_START,START_JOB_FAILED,PAUSING,FULL_TRANSFER_STARTED,FULL_TRANSFER_FAILED,FULL_TRANSFER_COMPLETE,INCRE_TRANSFER_STARTED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_STARTED,RELEASE_RESOURCE_FAILED,RELEASE_RESOURCE_COMPLETE,REBUILD_NODE_STARTED,REBUILD_NODE_FAILED,CHANGE_JOB_STARTED,CHANGE_JOB_FAILED,DELETED,CHILD_TRANSFER_STARTING,CHILD_TRANSFER_STARTED,CHILD_TRANSFER_COMPLETE,CHILD_TRANSFER_FAILED,RELEASE_CHILD_TRANSFER_STARTED,RELEASE_CHILD_TRANSFER_COMPLETE,NODE_UPGRADE_START,NODE_UPGRADE_COMPLETE,NODE_UPGRADE_FAILED]`
      - `+ job.policy_config.is_create_table_with_index`
      - `+ job.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ job.source_endpoint.db_type: enum value [mysql]`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.params.policy_config.is_create_table_with_index`
      - `+ job.params.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ job.params.source_endpoint.db_type: enum value [mysql]`
  - **ExecuteJobAction**
    - 请求参数变更
      - `+ job.action_params.is_only_init_task`
      - `+ job.action_params.endpoints.db_type: enum value [mysql]`
  - **BatchExecuteJobActions**
    - 请求参数变更
      - `+ jobs.action_params.is_only_init_task`
      - `+ jobs.action_params.endpoints.db_type: enum value [mysql]`

### HuaweiCloud SDK GaussDBforopenGauss

- _接口版本_
  - V3
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateDbInstance**
    - 请求参数变更
      - `+ ha.instance_mode`

### HuaweiCloud SDK KMS

- _接口版本_
  - V2
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateDatakey**
    - 请求参数变更
      - `+ additional_authenticated_data`
  - **CreateDatakeyWithoutPlaintext**
    - 请求参数变更
      - `+ additional_authenticated_data`
  - **EncryptDatakey**
    - 请求参数变更
      - `+ additional_authenticated_data`
  - **DecryptDatakey**
    - 请求参数变更
      - `+ additional_authenticated_data`
  - **EncryptData**
    - 请求参数变更
      - `+ additional_authenticated_data`
  - **DecryptData**
    - 请求参数变更
      - `+ additional_authenticated_data`

### HuaweiCloud SDK VPCEP

- _接口版本_
  - V1
- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `* policy_document: string -> object`
  - **UpdateEndpointWhite**
    - 响应参数变更
      - `* policy_document: string -> object`
  - **UpdateEndpointPolicy**
    - 请求参数变更
      - `* policy_document: string -> object`
    - 响应参数变更
      - `* policy_document: string -> object`
  - **DeleteEndpointPolicy**
    - 响应参数变更
      - `* policy_document: string -> object`
  - **CreateEndpoint**
    - 请求参数变更
      - `* policy_document: string -> object`
    - 响应参数变更
      - `* policy_document: string -> object`
  - **ListEndpoints**
    - 响应参数变更
      - `* endpoints.policy_document: string -> object`

# 3.1.108 2024-08-15

### HuaweiCloud SDK AOS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **EstimateExecutionPlanPrice**
    - 响应参数变更
      - `+ items.module_address`

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNodePool**
    - 响应参数变更
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **UpdateNodePool**
    - 请求参数变更
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
    - 响应参数变更
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **CreateNodePool**
    - 请求参数变更
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
    - 响应参数变更
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.status.scaleGroupStatuses`
      - `* items.spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`BatchRestartOnlineMigrationTasks`
- _解决问题_
  - 无
- _特性变更_
  - **BatchStopMigrationTasks**
    - 响应参数变更
      - `+ migration_tasks.error_msg`
      - `+ migration_tasks.error_code`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdatePrePaidBandwidth**
    - 请求参数变更
      - `+ extendParam.period_type`
      - `+ extendParam.period_num`
  - **ListEipBandwidths**
    - 响应参数变更
      - `* eip_bandwidths.tenant_id: uuid -> string`
  - **ListProjectGeipBindings**
    - 响应参数变更
      - `* geip_bindings.vnic.vni: int32 -> string`

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAvailabilityZones**
    - 响应参数变更
      - `+ spec_code`
  - **ListFlavors**
    - 请求参数变更
      - `- loadbalancer_type`
  - **ShowLoadBalancer**
    - 响应参数变更
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **UpdateLoadBalancer**
    - 响应参数变更
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **BatchAddAvailableZones**
    - 响应参数变更
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **BatchRemoveAvailableZones**
    - 响应参数变更
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **ListLoadBalancers**
    - 响应参数变更
      - `+ loadbalancers.gw_flavor_id`
      - `+ loadbalancers.loadbalancer_type`
  - **CreateLoadBalancer**
    - 响应参数变更
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstance**
    - 请求参数变更
      - `+ ha.instance_mode`
  - **ShowBatchUpgradeCandidateVersions**
    - 响应参数变更
      - `+ hotfix_rollback_infos`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListImages**
    - 请求参数变更
      - `+ visibility: enum value [shared]`
    - 响应参数变更
      - `+ images.visibility: enum value [shared]`
  - **UpdateImage**
    - 响应参数变更
      - `+ visibility: enum value [shared]`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListLogs**
    - 请求参数变更
      - `+ query`
      - `+ is_analysis_query`
    - 响应参数变更
      - `+ analysisLogs`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeTransportationLicense**
    - 响应参数变更
      - `+ result.expiry_date`
      - `+ result.review_expiry_date`
      - `+ result.assessed_technical_level`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **UpdateEndpointWhite**
    - 响应参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **UpdateEndpointPolicy**
    - 请求参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
    - 响应参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **DeleteEndpointPolicy**
    - 响应参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **CreateEndpoint**
    - 请求参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
    - 响应参数变更
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **ListEndpoints**
    - 响应参数变更
      - `+ endpoints.policy_statement.Effect: enum value [Deny]`
      - `- endpoints.policy_statement.Effect: enum value [Refuse]`

# 3.1.107 2024-08-08

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeSmartDocumentRecognizer**
    - 请求参数变更
      - `+ single_orientation_mode`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSubNetworkInterfaces**
    - 响应参数变更
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **CreateSubNetworkInterface**
    - 请求参数变更
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.tags`
    - 响应参数变更
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **BatchCreateSubNetworkInterface**
    - 请求参数变更
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.tags`
    - 响应参数变更
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **ShowSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **UpdateSubNetworkInterface**
    - 请求参数变更
      - `+ sub_network_interface.allowed_address_pairs`
    - 响应参数变更
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **MigrateSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **UpdateTrafficMirrorSession**
    - 请求参数变更
      - `- traffic_mirror_session.type`

# 3.1.106 2024-08-01

### HuaweiCloud SDK LTS

- _新增特性_
  - 支持以下接口：
    - `ListConsumerGroup`
    - `CreateConsumerGroup`
    - `ConsumerGroupHeartBeat`
    - `ShowLogStreamShards`
    - `ListDetailsConsumerGroup`
    - `UpdateCheckPoint`
    - `DeleteConsumerGroup`
    - `ShowCursorByTime`
    - `ShowCursorTime`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `+ policy_document`
  - **UpdateEndpointWhite**
    - 响应参数变更
      - `+ policy_document`
  - **UpdateEndpointPolicy**
    - 请求参数变更
      - `+ policy_document`
    - 响应参数变更
      - `+ policy_document`
  - **DeleteEndpointPolicy**
    - 响应参数变更
      - `+ policy_document`
  - **CreateEndpoint**
    - 请求参数变更
      - `+ policy_document`
    - 响应参数变更
      - `+ policy_document`
  - **ListEndpoints**
    - 响应参数变更
      - `+ endpoints.policy_document`

# 3.1.105 2024-07-25

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持以下接口：
    - `SyncNodePool`
    - `UpgradeNodePool`
    - `ShowClusterSupportConfiguration`
    - `ShowResourceInstances`
    - `BatchCreateDeleteResourceTags`
    - `ShowResourceTags`
    - `ShowCustomizeClusterTagsByProjectId`
    - `UpdateAutopilotClusterEip`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`BatchCheckImageSync`
- _解决问题_
  - 无
- _特性变更_
  - **RunTextModeration**
    - 请求参数变更
      - `+ Enterprise-Project-Id`
  - **CheckImageModeration**
    - 请求参数变更
      - `+ Enterprise-Project-Id`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeCambodianIdCard**
    - 请求参数变更
      - `+ detect_reproduce`
    - 响应参数变更
      - `+ result.detect_reproduce_result`
      - `+ result.score_info.reproduce_score`

# 3.1.104 2024-07-18

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateScalingV2Policy**
    - 请求参数变更
      - `+ scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ interval_alarm_actions.percentage`
      - `* interval_alarm_actions.lower_bound: int32 -> double`
      - `* interval_alarm_actions.upper_bound: int32 -> double`
  - **ListAllScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policies.interval_alarm_actions.percentage`
      - `* scaling_policies.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policies.interval_alarm_actions.upper_bound: int32 -> double`
  - **UpdateScalingV2Policy**
    - 请求参数变更
      - `+ scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ interval_alarm_actions.percentage`
      - `* interval_alarm_actions.lower_bound: int32 -> double`
      - `* interval_alarm_actions.upper_bound: int32 -> double`
  - **ShowScalingV2Policy**
    - 响应参数变更
      - `+ scaling_policy.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policy.interval_alarm_actions.percentage`
      - `* scaling_policy.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policy.interval_alarm_actions.upper_bound: int32 -> double`
  - **ListScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policies.interval_alarm_actions.percentage`
      - `* scaling_policies.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policies.interval_alarm_actions.upper_bound: int32 -> double`

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListBareMetalServers**
    - 响应参数变更
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`
  - **ListBareMetalServerDetails**
    - 响应参数变更
      - `+ server.flavor.gpus`
      - `+ server.flavor.asic_accelerators`

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持以下接口：
    - `ListAutopilotClusters`
    - `CreateAutopilotCluster`
    - `ShowAutopilotCluster`
    - `UpdateAutopilotCluster`
    - `DeleteAutopilotCluster`
    - `CreateAutopilotKubernetesClusterCert`
    - `ShowAutopilotJob`
    - `ShowAutopilotClusterEndpoints`
    - `ListAutopilotAddonInstances`
    - `CreateAutopilotAddonInstance`
    - `ListAutopilotAddonTemplates`
    - `ShowAutopilotAddonInstance`
    - `UpdateAutopilotAddonInstance`
    - `DeleteAutopilotAddonInstance`
    - `RollbackAutopilotAddonInstance`
    - `UpgradeAutopilotCluster`
    - `ShowAutopilotUpgradeClusterTask`
    - `RetryAutopilotUpgradeClusterTask`
    - `ListAutopilotUpgradeClusterTasks`
    - `CreateAutopilotPreCheck`
    - `ShowAutopilotPreCheck`
    - `ListAutopilotPreCheckTasks`
    - `CreateAutopilotPostCheck`
    - `CreateAutopilotClusterMasterSnapshot`
    - `ListAutopilotClusterMasterSnapshotTasks`
    - `ShowAutopilotClusterUpgradeInfo`
    - `ListAutopilotClusterUpgradePaths`
    - `ListAutopilotClusterUpgradeFeatureGates`
    - `ListAutopilotUpgradeWorkFlows`
    - `CreateAutopilotUpgradeWorkFlow`
    - `ShowAutopilotUpgradeWorkFlow`
    - `UpgradeAutopilotWorkFlowUpdate`
    - `ShowAutopilotQuotas`
    - `BatchCreateAutopilotClusterTags`
    - `BatchDeleteAutopilotClusterTags`
    - `ListAutopilotCharts`
    - `UploadAutopilotChart`
    - `ListAutopilotReleases`
    - `CreateAutopilotRelease`
    - `ShowAutopilotChart`
    - `UpdateAutopilotChart`
    - `DeleteAutopilotChart`
    - `ShowAutopilotRelease`
    - `UpdateAutopilotRelease`
    - `DeleteAutopilotRelease`
    - `DownloadAutopilotChart`
    - `ShowAutopilotChartValues`
    - `ShowAutopilotReleaseHistory`
    - `ShowAutopilotUserChartsQuotas`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListTraces**
    - 请求参数变更
      - `+ access_key_id`
      - `+ enterprise_project_id`
    - 响应参数变更
      - `+ traces.enterprise_project_id`
      - `+ traces.resource_account_id`
      - `+ traces.user.user_name`
      - `+ traces.user.account_id`
      - `+ traces.user.access_key_id`
      - `+ traces.user.principal_urn`
      - `+ traces.user.principal_id`
      - `+ traces.user.principal_is_root_user`
      - `+ traces.user.type`
      - `+ traces.user.invoked_by`
      - `+ traces.user.session_context`

### HuaweiCloud SDK DRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateJobs**
    - 请求参数变更
      - `+ jobs.node_type: enum value [micro,small,medium,xlarge,2xlarge]`
  - **BatchUpdateJob**
    - 请求参数变更
      - `+ jobs.node_type: enum value [micro,small,medium,xlarge,2xlarge]`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowServer**
    - 响应参数变更
      - `+ server.flavor.gpus`
      - `+ server.flavor.asic_accelerators`
  - **ListServersDetails**
    - 响应参数变更
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`

### HuaweiCloud SDK ELB

- _新增特性_
  - 支持接口`ShowCertificatePrivateKeyEcho`、`CreateCertificatePrivateKeyEcho`
- _解决问题_
  - 无
- _特性变更_
  - **ShowQuota**
    - 响应参数变更
      - `+ quota.free_instance_members_per_pool`
      - `+ quota.free_instance_listeners_per_loadbalancer`
  - **ChangeLoadbalancerChargeMode**
    - 请求参数变更
      - `+ pay_type`
      - `+ prepaid_options.cloud_service_console_url`
  - **ListCertificates**
    - 请求参数变更
      - `+ common_name`
      - `+ fingerprint`
    - 响应参数变更
      - `+ certificates.common_name`
      - `+ certificates.fingerprint`
      - `+ certificates.subject_alternative_names`
  - **CreateCertificate**
    - 响应参数变更
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **ShowCertificate**
    - 响应参数变更
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **UpdateCertificate**
    - 请求参数变更
      - `+ certificate.scm_certificate_id`
    - 响应参数变更
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **ListFlavors**
    - 请求参数变更
      - `+ loadbalancer_type`
    - 响应参数变更
      - `+ flavors.public_border_group`
      - `+ flavors.category`
  - **ShowFlavor**
    - 响应参数变更
      - `+ flavor.public_border_group`
      - `+ flavor.category`
  - **UpdateLoadBalancer**
    - 请求参数变更
      - `+ loadbalancer.gw_flavor_id`
  - **ListIpGroups**
    - 请求参数变更
      - `+ enterprise_project_id`
    - 响应参数变更
      - `+ ipgroups.enterprise_project_id`
  - **CreateIpGroup**
    - 响应参数变更
      - `+ ipgroup.enterprise_project_id`
  - **ShowIpGroup**
    - 响应参数变更
      - `+ ipgroup.enterprise_project_id`
  - **UpdateIpGroup**
    - 响应参数变更
      - `+ ipgroup.enterprise_project_id`
  - **UpdateIpList**
    - 响应参数变更
      - `+ ipgroup.enterprise_project_id`
  - **BatchDeleteIpList**
    - 响应参数变更
      - `+ ipgroup.enterprise_project_id`
  - **ListListeners**
    - 响应参数变更
      - `+ listeners.insert_headers.X-Nuwa-Trace`
  - **CreateListener**
    - 请求参数变更
      - `+ listener.insert_headers.X-Nuwa-Trace`
    - 响应参数变更
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **ShowListener**
    - 响应参数变更
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **UpdateListener**
    - 请求参数变更
      - `+ listener.insert_headers.X-Nuwa-Trace`
    - 响应参数变更
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **ListPools**
    - 请求参数变更
      - `+ pool_health`
      - `+ any_port_enable`
      - `+ public_border_group`
    - 响应参数变更
      - `+ pools.enterprise_project_id`
      - `+ pools.pool_health`
      - `+ pools.public_border_group`
  - **CreatePool**
    - 请求参数变更
      - `+ pool.target_rebalance`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
    - 响应参数变更
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **ShowPool**
    - 响应参数变更
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **UpdatePool**
    - 请求参数变更
      - `+ pool.pool_health`
    - 响应参数变更
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **ListMembers**
    - 响应参数变更
      - `- members.pool_id`
      - `- members.device_owner`
      - `- members.device_id`
      - `- members.loadbalancer_id`
      - `- members.loadbalancers`
  - **CreateMember**
    - 响应参数变更
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **ShowMember**
    - 响应参数变更
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **UpdateMember**
    - 响应参数变更
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **ListAllMembers**
    - 响应参数变更
      - `* members: list<Member> -> list<MemberInfo>`
  - **BatchUpdateMembers**
    - 响应参数变更
      - `+ members.created_at`
      - `+ members.updated_at`
  - **UpdateHealthMonitor**
    - 请求参数变更
      - `- healthmonitor.http_method: enum value [PUT,DELETE,TRACE,OPTIONS,CONNECT,PATCH]`
  - **ListLoadBalancers**
    - 请求参数变更
      - `+ loadbalancer_type`
  - **CreateLoadBalancer**
    - 请求参数变更
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
      - `+ loadbalancer.prepaid_options.promotion_info`
      - `+ loadbalancer.prepaid_options.cloud_service_console_url`
  - **ListL7Policies**
    - 响应参数变更
      - `+ l7policies.redirect_pools_config`
      - `+ l7policies.redirect_pools_sticky_session_config`
      - `+ l7policies.redirect_url_config.insert_headers_config`
      - `+ l7policies.redirect_url_config.remove_headers_config`
      - `+ l7policies.fixed_response_config.insert_headers_config`
      - `+ l7policies.fixed_response_config.remove_headers_config`
      - `+ l7policies.fixed_response_config.traffic_limit_config`
      - `+ l7policies.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policies.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policies.redirect_pools_extend_config.traffic_limit_config`
  - **CreateL7Policy**
    - 请求参数变更
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
    - 响应参数变更
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
  - **ShowL7Policy**
    - 响应参数变更
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
  - **UpdateL7Policy**
    - 请求参数变更
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
      - `* l7policy.redirect_pools_extend_config.rewrite_url_config: object<CreateRewriteUrlConfig> -> object<UpdateRewriteUrlConfig>`
    - 响应参数变更
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`

### HuaweiCloud SDK EVS

- _新增特性_
  - 支持接口`ChangeVolumeChargeMode`、`UnsubscribePostpaidVolume`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListWorkflowExecutions**
    - 请求参数变更
      - `+ offset`

### HuaweiCloud SDK IAM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAgencies**
    - 响应参数变更
      - `- agencies.duration`
  - **CreateAgency**
    - 响应参数变更
      - `- agency.duration`
  - **ShowAgency**
    - 响应参数变更
      - `- agency.duration`
  - **UpdateAgency**
    - 响应参数变更
      - `- agency.duration`
  - **ListRolesForGroupOnEnterpriseProject**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListPermissions**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneShowPermission**
    - 响应参数变更
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListDomainPermissionsForGroup**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListProjectPermissionsForGroup**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListAllProjectPermissionsForGroup**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListDomainPermissionsForAgency**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListProjectPermissionsForAgency**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListRolesForUserOnEnterpriseProject**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **CreateCloudServiceCustomPolicy**
    - 请求参数变更
      - `* role.policy.Statement.Resource: object -> list<string>`
    - 响应参数变更
      - `* role.policy.Statement.Resource: object -> list<string>`
  - **UpdateCloudServiceCustomPolicy**
    - 请求参数变更
      - `* role.policy.Statement.Resource: object -> list<string>`
    - 响应参数变更
      - `* role.policy.Statement.Resource: object -> list<string>`
  - **CreateTemporaryAccessKeyByToken**
    - 请求参数变更
      - `* auth.identity.policy.Statement.Resource: object -> list<string>`
  - **CreateTemporaryAccessKeyByAgency**
    - 请求参数变更
      - `* auth.identity.policy.Statement.Resource: object -> list<string>`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListImages**
    - 请求参数变更
      - `+ __platform: enum value [Huawei Cloud EulerOS]`

### HuaweiCloud SDK KMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListKeys**
    - 响应参数变更
      - `- key_details.key_label`
  - **ListKeyDetail**
    - 响应参数变更
      - `- key_info.key_label`
  - **ListKmsByTags**
    - 响应参数变更
      - `- resources.resource_detail.key_label`

### HuaweiCloud SDK Live

- _新增特性_
  - 支持接口`ListPlayDomainStreamInfo`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VOD

- _新增特性_
  - 支持接口`DeleteTranscodeProduct`
- _解决问题_
  - 无
- _特性变更_
  - **ShowVodStatistics**
    - 响应参数变更
      - `+ sample_data.storage_warm`
      - `+ sample_data.storage_cold`

# 3.1.103 2024-07-11

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`ScaleNodePool`
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ metadata.ownerReference`
  - **UpdateNode**
    - 响应参数变更
      - `+ metadata.ownerReference`
  - **DeleteNode**
    - 响应参数变更
      - `+ metadata.ownerReference`
  - **CreateNode**
    - 请求参数变更
      - `+ metadata.ownerReference`
    - 响应参数变更
      - `+ metadata.ownerReference`
  - **ListNodes**
    - 响应参数变更
      - `+ items.metadata.ownerReference`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.extensionScaleGroups`
  - **UpdateNodePool**
    - 请求参数变更
      - `+ spec.extensionScaleGroups`
    - 响应参数变更
      - `+ spec.extensionScaleGroups`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.extensionScaleGroups`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.extensionScaleGroups`
    - 响应参数变更
      - `+ spec.extensionScaleGroups`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.extensionScaleGroups`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 废弃以下接口：
    - `ShowBlackWhiteList`
    - `UpdateBlackWhiteList`
    - `UpdatePrivateBucketAccess`
    - `BatchDeleteTags`
    - `ShowOriginHost`
    - `UpdateOriginHost`
    - `UpdateRangeSwitch`
    - `UpdateFollow302Switch`
    - `ShowRefer`
    - `UpdateRefer`
    - `ShowIpInfo`
    - `ShowResponseHeader`
    - `UpdateResponseHeader`
    - `CreateRefreshTasks`
    - `CreatePreheatingTasks`
    - `ShowHistoryTasks`
    - `ShowHistoryTaskDetails`
    - `ShowUrlTaskInfo`
    - `ShowQuota`
    - `ShowTags`
    - `CreateTags`
    - `CreateDomain`
    - `ShowDomainDetail`
    - `DeleteDomain`
    - `EnableDomain`
    - `DisableDomain`
    - `UpdateDomainOrigin`
    - `ShowHttpInfo`
    - `UpdateHttpsInfo`
    - `UpdateDomainMultiCertificates`
    - `ShowCertificatesHttpsInfo`
    - `ShowCacheRules`
    - `UpdateCacheRules`
  - **ListCdnDomainTopRefers**
    - 响应参数变更
      - `- top_refer_summary.ratio`

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateEvents**
    - 请求参数变更
      - `+ detail.dimensions`
  - **ListNotificationMasks**
    - 响应参数变更
      - `+ notification_masks.policies.selected_unit`

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 支持以下接口：
    - `ListHostGroupPermissions`
    - `UpdateHostGroupPermissions`
    - `CheckWhetherHostGroupCanBeCreated`
    - `ListEnvironmentPermissions`
    - `UpdateEnvironmentPermission`
    - `CopyHostsToTarget`
    - `BatchDeleteHosts`
    - `ListAssociateEnvironmentsInfos`
    - `ListHostGroupBaseInfos`
    - `ListEnvironmentHosts`
    - `CopyApplication`
    - `BatchDeleteApp`
    - `ListApplicationPermissions`
    - `BatchUpdateApplicationPermissions`
    - `BatchUpdatePermissionLevel`
    - `ListAppGroups`
    - `CreateAppGroups`
    - `UpdateAppGroups`
    - `DeleteAppGroups`
    - `MoveAppGroups`
    - `MoveAppToGroup`
    - `CheckIsDuplicateAppName`
    - `CheckCanCreate`
    - `UpdateAppDisableStatus`
    - `UpdateHostCluster`
    - `DeleteHostCluster`
    - `UpdateHostInfo`
    - `DeleteHost`
    - `UpdateEnvironment`
    - `UpdateAppInfo`
- _解决问题_
  - 无
- _特性变更_
  - **CreateApp**
    - 请求参数变更
      - `+ arrange_infos.operation_list.id`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListFlavors**
    - 响应参数变更
      - `+ flavors.os_extra_specs.info:gpus`
      - `+ flavors.os_extra_specs.info:asic_accelerators`
  - **ListResizeFlavors**
    - 响应参数变更
      - `+ flavors.extra_specs.info:gpus`
      - `+ flavors.extra_specs.info:asic_accelerators`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持以下接口：
    - `ListSupportKernelPlugins`
    - `ListKernelPlugins`
    - `SetKernelPluginLicense`
    - `InstallKernelPlugin`
    - `ListPluginExtensions`
    - `ResumePluginExtensions`
- _解决问题_
  - 无
- _特性变更_
  - **RestoreInstance**
    - 请求参数变更
      - `- source.table_list`
      - `- source.schema_type`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- kafka_manager_user`
      - `- kafka_manager_password`

### HuaweiCloud SDK Live

- _新增特性_
  - 支持以下接口：
    - `ShowRefererChain`
    - `SetRefererChain`
    - `DeleteRefererChain`
    - `ListHlsConfig`
    - `UpdateHlsConfig`
- _解决问题_
  - 无
- _特性变更_
  - **ShowPullSourcesConfig**
    - 响应参数变更
      - `+ source_port`
  - **UpdatePullSourcesConfig**
    - 请求参数变更
      - `+ source_port`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeBankReceipt**
    - 请求参数变更
      - `+ page_num`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs,fcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs,fcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs,fcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs,fcs),[c6.4u16g.cluster.arm](tag:hcs,fcs),[c6.8u32g.cluster.arm](tag:hcs,fcs),[c6.16u64g.cluster.arm](tag:hcs,fcs),[c6.32u128g.cluster.arm](tag:hcs,fcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs,fcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs,fcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs,fcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs,fcs),[c6.4u16g.cluster.arm](tag:hcs,fcs),[c6.8u32g.cluster.arm](tag:hcs,fcs),[c6.16u64g.cluster.arm](tag:hcs,fcs),[c6.32u128g.cluster.arm](tag:hcs,fcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`

# 3.1.102 2024-07-04

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.url_auth.time_arg`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.url_auth.time_arg`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `ResizeStarRocksFlavor`
    - `ShowStarrocksParams`
    - `UpdateStarrocksParams`
    - `SyncStarRocksUsers`
    - `CheckStarrocksParams`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 响应参数变更
      - `+ instances.datastore.target_version`
      - `+ instances.datastore.hotfix_finished_times`
  - **ListInstancesDetails**
    - 响应参数变更
      - `+ instances.datastore.target_version`
      - `+ instances.datastore.hotfix_finished_times`

### HuaweiCloud SDK KMS

- _新增特性_
  - 支持接口`UpdatePrimaryRegion`、`ReplicateKey`、`ListSupportRegions`
- _解决问题_
  - 无
- _特性变更_
  - **ListKeys**
    - 响应参数变更
      - `- key_details.partition_type`
  - **ListKeyDetail**
    - 响应参数变更
      - `- key_info.partition_type`
  - **ListKmsByTags**
    - 响应参数变更
      - `- resources.resource_detail.partition_type`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeCambodianIdCard**
    - 请求参数变更
      - `+ detect_border_integrity`
      - `+ detect_blocking_within_border`
      - `+ detect_blur`
      - `+ detect_glare`
      - `+ return_adjusted_image`
      - `+ detect_tampering`
    - 响应参数变更
      - `+ result.adjusted_image`
      - `+ result.detect_border_integrity_result`
      - `+ result.detect_blocking_within_border_result`
      - `+ result.detect_blur_result`
      - `+ result.detect_glare_result`
      - `+ result.detect_tampering_result`
      - `+ result.score_info`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 支持以下接口：
    - `ListVhosts`
    - `CreateVhost`
    - `BatchDeleteVhosts`
    - `ListExchanges`
    - `CreateExchange`
    - `BatchDeleteExchanges`
    - `ListQueues`
    - `CreateQueue`
    - `BatchDeleteQueues`
    - `ShowQueueDetails`
    - `DeleteQueueInfo`
    - `ListBindings`
    - `CreateBinding`
    - `DeleteBinding`
    - `ListUser`
    - `CreateUser`
    - `UpdateUser`
    - `DeleteUser`
- _解决问题_
  - 无
- _特性变更_
  - **CreatePostPaidInstanceByEngine**
    - 请求参数变更
      - `- engine_version: enum value [3.8.35]`
  - **UpdateInstance**
    - 请求参数变更
      - `+ enable_acl`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- engine_version: enum value [3.8.35]`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`CreateInstanceIam5`、`UnlockNodeReadonlyStatus`、`DeleteDisasterRecovery`、`ListFlavorsResize`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.101 2024-06-27

### HuaweiCloud SDK Core

- _新增特性_
  - 无
- _解决问题_
  - 解决调用部分服务接口验签失败的问题
- _特性变更_
  - 无

### HuaweiCloud SDK AOM

- _新增特性_
  - 支持接口`ListMetricOrEventAlarmRule`、`AddOrUpdateMetricOrEventAlarmRule`、`DeleteMetricOrEventAlarmRule`
- _解决问题_
  - 无
- _特性变更_
  - **ListEvent2alarmRule**
    - 响应参数变更
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **UpdateEventRule**
    - 请求参数变更
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **AddEvent2alarmRule**
    - 请求参数变更
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **ListNotifiedHistories**
    - 响应参数变更
      - `* notified_histories.notifications.smn_channel.smn_notified_history.smn_subscription_status: string -> int32`
  - **CreateApp**
    - 请求参数变更
      - `+ register_type: enum value [CONSOLESERVICE_DISCOVERY]`
      - `- register_type: enum value [CONSOLE,SERVICE_DISCOVERY]`
  - **UpdateApp**
    - 请求参数变更
      - `+ register_type: enum value [CONSOLESERVICE_DISCOVERY]`
      - `- register_type: enum value [CONSOLE,SERVICE_DISCOVERY]`
  - **CreateComponent**
    - 请求参数变更
      - `- model_type: enum value [APPLICATION,SUB_APPLICATION]`
  - **CreateEnv**
    - 请求参数变更
      - `- env_type: enum value [DEV,TEST,PRE,ONLINE]`
      - `- os_type: enum value [LINUX,WINDOWS]`
      - `- register_type: enum value [API,CONSOLE,SERVICE_DISCOVERY]`
  - **ListResourceUnderNode**
    - 请求参数变更
      - `- ci_type: enum value [APPLICATION,SUB_APPLICATION,COMPONENT,ENVIRONMENT]`
  - **UpdateEnv**
    - 请求参数变更
      - `- env_type: enum value [DEV,TEST,PRE,ONLINE]`
      - `- os_type: enum value [LINUX,WINDOWS]`
      - `- register_type: enum value [API,CONSOLE,SERVICE_DISCOVERY]`

### HuaweiCloud SDK AOS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **GetStackTemplate**
    - 请求参数变更
      - `+ access_control_source_ips`
      - `+ access_control_source_vpc_ids`
  - **ShowStackSetTemplate**
    - 请求参数变更
      - `+ access_control_source_ips`
      - `+ access_control_source_vpc_ids`
      - `+ call_identity`
  - **ShowStackInstance**
    - 请求参数变更
      - `+ call_identity`
  - **ShowTemplateVersionContent**
    - 请求参数变更
      - `+ access_control_source_vpc_ids`
      - `+ access_control_source_ips`
  - **ListStackSets**
    - 请求参数变更
      - `+ call_identity`
    - 响应参数变更
      - `+ stack_sets.permission_model: enum value [SERVICE_MANAGED]`
  - **CreateStackSet**
    - 请求参数变更
      - `+ call_identity`
      - `+ permission_model: enum value [SERVICE_MANAGED]`
  - **ListStackSetOperations**
    - 请求参数变更
      - `+ call_identity`
  - **ShowStackSetMetadata**
    - 请求参数变更
      - `+ call_identity`
    - 响应参数变更
      - `+ organizational_unit_ids`
      - `+ permission_model: enum value [SERVICE_MANAGED]`
  - **ListStackInstances**
    - 请求参数变更
      - `+ call_identity`
  - **CreateStackInstance**
    - 请求参数变更
      - `+ call_identity`
  - **DeleteStackInstanceDeprecated**
    - 请求参数变更
      - `+ call_identity`
  - **UpdateStackInstances**
    - 请求参数变更
      - `+ call_identity`
  - **DeleteStackInstance**
    - 请求参数变更
      - `+ call_identity`
  - **DeployStackSet**
    - 请求参数变更
      - `+ call_identity`
      - `- var_overrides`
  - **DeleteStackSet**
    - 请求参数变更
      - `+ call_identity`
  - **UpdateStackSet**
    - 请求参数变更
      - `+ call_identity`
      - `- permission_model`
  - **ShowStackSetOperationMetadata**
    - 请求参数变更
      - `+ call_identity`

### HuaweiCloud SDK CFW

- _新增特性_
  - 支持以下接口：
    - `CreateTag`
    - `DeleteTag`
    - `ListCaptureTask`
    - `CreateCaptureTask`
    - `DeleteCaptureTask`
    - `ListCaptureResult`
    - `CancelCaptureTask`
- _解决问题_
  - 无
- _特性变更_
  - **ListFlowLogs**
    - 请求参数变更
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
      - `+ protocol: enum value [6,17,1,58]`
    - 响应参数变更
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
  - **ListAccessControlLogs**
    - 请求参数变更
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
    - 响应参数变更
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
  - **ListBlackWhiteLists**
    - 请求参数变更
      - `+ address_type: enum value [0,1,2]`
    - 响应参数变更
      - `- data.object_id`
  - **AddServiceSet**
    - 响应参数变更
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **ListDomainParseDetail**
    - 请求参数变更
      - `* address_type: string -> int32`
  - **UpdateDnsServers**
    - 请求参数变更
      - `* fw_instance_id: optional -> required`
  - **ListDnsServers**
    - 请求参数变更
      - `* fw_instance_id: optional -> required`
  - **ChangeIpsSwitchStatus**
    - 响应参数变更
      - `- trace_id`
  - **ListAttackLogs**
    - 请求参数变更
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
      - `- source`
      - `+ protocol: enum value [6,17,1,58]`
      - `+ action: enum value [0,1]`
      - `+ direction: enum value [0,1]`
    - 响应参数变更
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
      - `- data.records.dst_host`
      - `* data.records.hit_time: int32 -> int64`
  - **UpdateBlackWhiteList**
    - 请求参数变更
      - `- list_type`
      - `- object_id`
  - **ChangeIpsProtectMode**
    - 响应参数变更
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **UpdateServiceSet**
    - 响应参数变更
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **ListServiceItems**
    - 响应参数变更
      - `- data.records.name`
  - **AddServiceItems**
    - 请求参数变更
      - `- service_items.item_id`
      - `- service_items.name`
    - 响应参数变更
      - `- data.items.name`
      - `* data.items: list<IdObject> -> list<object>`
  - **CreateFirewall**
    - 请求参数变更
      - `- X-Trace-Id`
  - **UpdateAddressSet**
    - 请求参数变更
      - `- address_type`
  - **UpdateDomainSet**
    - 请求参数变更
      - `* fw_instance_id: optional -> required`
      - `- set_id`
      - `- domain_set_type`
  - **ListProtectedVpcs**
    - 响应参数变更
      - `- trace_id`
      - `- data.protect_vpcs.id`
      - `- data.protect_vpcs.name`
      - `- data.protect_vpcs.virsubnet_id`
      - `- data.protect_vpcs.state`
      - `- data.protect_vpcs.created_at`
      - `- data.protect_vpcs.updated_at`
      - `- data.protect_vpcs.tags`
      - `- data.protect_vpcs.description`
      - `- data.protect_vpcs.project_id`
      - `- data.protect_vpcs.vpc_project_id`
      - `- data.protect_vpcs.enterprise_project_id`
  - **CreateEastWestFirewall**
    - 响应参数变更
      - `+ data.er`
      - `+ data.inspertion_vpc`
      - `- data.name`
      - `* data: object<IdObject> -> object<CreateEWFirewallResp>`
  - **ListEastWestFirewall**
    - 请求参数变更
      - `* fw_instance_id: optional -> required`
    - 响应参数变更
      - `+ data.er.attachment_id`
  - **AddAclRule**
    - 请求参数变更
      - `- rules.profile`
      - `+ rules.source.address_group`
      - `* rules.service.service_group_names: list<AddressGroupVO> -> list<ServiceGroupVO>`
  - **UpdateAclRule**
    - 请求参数变更
      - `- profile`
      - `+ source.address_group_names.address_set_type`
      - `- source.address_group_names.protocols`
      - `- source.address_group_names.service_set_type`
  - **ListAclRules**
    - 请求参数变更
      - `- protocol`
    - 响应参数变更
      - `- data.records.sequence`
      - `- data.records.source.predefined_group`
      - `+ data.records.source.address_group_names.address_set_type`
      - `- data.records.source.address_group_names.protocols`
      - `- data.records.source.address_group_names.service_set_type`
      - `* data.records.source: object<RuleAddressDto> -> object<RuleAddressDtoForResponse>`
      - `- data.records.service.predefined_group`
      - `* data.records.service: object<RuleServiceDto> -> object<RuleServiceDtoForResponse>`
  - **ListServiceSets**
    - 响应参数变更
      - `- data.records.status`
  - **ListDomains**
    - 请求参数变更
      - `- description`
      - `- set_id`
  - **ListFirewallDetail**
    - 响应参数变更
      - `- data.records.flavor.session_concurrent`
      - `- data.records.flavor.session_create`
      - `- data.records.flavor.total_rule_count`
      - `- data.records.flavor.used_rule_count`
      - `- data.records.flavor.vpc_bandwith`
  - **ListFirewallList**
    - 响应参数变更
      - `- data.records.flavor.session_concurrent`
      - `- data.records.flavor.session_create`
      - `- data.records.flavor.total_rule_count`
      - `- data.records.flavor.used_rule_count`
      - `- data.records.flavor.vpc_bandwith`

### HuaweiCloud SDK DRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateJobs**
    - 请求参数变更
      - `+ jobs.is_open_fast_clean`
  - **BatchListJobDetails**
    - 响应参数变更
      - `+ results.is_open_fast_clean`
  - **ShowDbObjectTemplateResult**
    - 请求参数变更
      - `+ file_export_object_level`
  - **DownloadDbObjectTemplate**
    - 请求参数变更
      - `+ file_import_db_level: enum value [column]`
  - **UploadDbObjectTemplate**
    - 请求参数变更
      - `+ file_import_db_level: enum value [column]`
  - **ShowDbObjectTemplateProgress**
    - 请求参数变更
      - `+ type`
  - **ShowSupportObjectType**
    - 响应参数变更
      - `+ is_import_cloumn`
  - **ShowReplayResults**
    - 请求参数变更
      - `+ is_sample`
      - `+ error_type`
      - `+ sql_template_md5`
      - `+ type: enum value [error_classification]`
    - 响应参数变更
      - `+ error_classifications`
      - `+ slow_sql_templates.sql_template_md5`
      - `+ error_sql_templates.sql_template_md5`
  - **CreateJob**
    - 请求参数变更
      - `+ job.base_info.is_open_fast_clean`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **BatchCreateJobsAsync**
    - 请求参数变更
      - `+ jobs.base_info.is_open_fast_clean`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.base_info.is_open_fast_clean`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.params.base_info.is_open_fast_clean`
      - `+ jobs.params.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.base_info.is_open_fast_clean`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.params.base_info.is_open_fast_clean`
      - `+ job.params.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ExecuteJobAction**
    - 请求参数变更
      - `+ job.action_name: enum value [set_readonly]`
      - `+ job.action_params.endpoints.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **BatchExecuteJobActions**
    - 请求参数变更
      - `+ jobs.action_name: enum value [set_readonly]`
      - `+ jobs.action_params.endpoints.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListFlavors**
    - 响应参数变更
      - `+ flavors.os_extra_specs.network_interface:traffic_mirroring_supported`
      - `+ flavors.os_extra_specs.security:enclave_supported`
  - **ListResizeFlavors**
    - 响应参数变更
      - `+ flavors.extra_specs.network_interface:traffic_mirroring_supported`
      - `+ flavors.extra_specs.security:enclave_supported`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListQuotas**
    - 响应参数变更
      - `+ quotas.resources.type: enum value [fgs_on_demand_instance_limit,fgs_func_qos_limit]`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `ResumeStarRocksDataReplication`
    - `PauseStarRocksDataReplication`
    - `ListClickHouseInstanceNode`
    - `ShowClickHouseSlowLogDetail`
    - `ShowClickHouseSlowLogSensitiveStatus`
    - `UpdateClickHouseSlowLogSensitiveStatus`
    - `ShowClickHouseLtsConfig`
    - `UpdateClickHouseLtsConfig`
    - `DeleteClickHouseLtsConfig`
    - `CheckClickHouseDataBaseConfig`
    - `CheckClickHouseTableConfig`
    - `ListClickHouseDataBase`
    - `ListClickHouseDataBaseReplicationConfig`
    - `ListClickHouseDataBaseParameter`
    - `CreateClickHouseInstance`
    - `ListClickHouseInstance`
    - `DeleteClickHouseInstance`
    - `ResizeClickHouseInstance`
    - `RebootClickHouseInstance`
    - `ShowClickHouseDatabaseUser`
    - `CreateClickHouseDatabaseUser`
    - `UpdateClickHouseDatabaseUserPassword`
    - `UpdateClickHouseDatabaseUserPermission`
    - `ListClickHouseDataBaseReplication`
    - `CreateClickHouseDataBaseReplication`
    - `DeleteClickHouseDataBaseReplication`
    - `UpdateClickHouseDataBaseConfig`
    - `DeleteClickHouseDataBaseConfig`
    - `ResizeClickHouseFlavor`
    - `DeleteClickHouseDatabaseUser`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持以下接口：
    - `SetNewBackupPolicy`
    - `ListInstanceDetails`
    - `ShowBatchUpgradeCandidateVersions`
    - `UpgradeInstancesVersion`
    - `ConfirmRestoredData`
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstance**
    - 请求参数变更
      - `- replica_num: enum value [2]`
  - **CreateDbInstance**
    - 请求参数变更
      - `- replica_num: enum value [2]`

### HuaweiCloud SDK VPC

- _新增特性_
  - 支持以下接口：
    - `CountPortsByTags`
    - `ListPortsByTags`
    - `ShowPortTags`
    - `CreatePortTag`
    - `ListPortTags`
    - `BatchCreatePortTags`
    - `DeletePortTag`
    - `BatchDeletePortTags`
- _解决问题_
  - 无
- _特性变更_
  - **ListFirewallTags**
    - 请求参数变更
      - `+ limit`
      - `+ offset`
    - 响应参数变更
      - `+ total_count`
      - `* tags: object<ListTag> -> list<ListTag>`
  - **ShowFirewallTags**
    - 响应参数变更
      - `- sys_tags`
      - `* tags: object<ResourceTag> -> list<ResourceTag>`
  - **BatchDeleteFirewallTags**
    - 请求参数变更
      - `* tags: list<ResourceTag> -> list<DeleteResourceTagRequestBody>`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateEndpointService**
    - 响应参数变更
      - `+ ip_version`
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `+ ipv6_address`
  - **CreateEndpointService**
    - 请求参数变更
      - `+ ip_version`
      - `- enable_policy`
    - 响应参数变更
      - `+ ip_version`
  - **CreateEndpoint**
    - 请求参数变更
      - `+ policy_statement`
      - `+ ip_version`
      - `+ ipv6_address`
    - 响应参数变更
      - `+ ipv6_address`
  - **ListEndpoints**
    - 请求参数变更
      - `- public_border_group`

# 3.1.100 2024-06-20

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持以下接口：
    - `ListProvisioningTemplates`
    - `CreateProvisioningTemplate`
    - `ShowProvisioningTemplate`
    - `UpdateProvisioningTemplate`
    - `DeleteProvisioningTemplate`
    - `ListDeviceAuthorizers`
    - `CreateDeviceAuthorizer`
    - `ShowDeviceAuthorizer`
    - `UpdateDeviceAuthorizer`
    - `DeleteDeviceAuthorizer`
    - `ListDevicePolicies`
    - `CreateDevicePolicy`
    - `ShowDevicePolicy`
    - `UpdateDevicePolicy`
    - `DeleteDevicePolicy`
    - `BindDevicePolicy`
    - `UnbindDevicePolicy`
    - `ShowTargetsInDevicePolicy`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowConnectorTask**
    - 响应参数变更
      - `- sink_task.connector_class`
      - `- sink_task.storage_class`
      - `- sink_task.format_class`
  - **CreateConnectorTask**
    - 响应参数变更
      - `- sink_task.connector_class`
      - `- sink_task.storage_class`
      - `- sink_task.format_class`
  - **ListConnectorTasks**
    - 响应参数变更
      - `- tasks.sink_task.connector_class`
      - `- tasks.sink_task.storage_class`
      - `- tasks.sink_task.format_class`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunCreateAudioStreamModerationJob**
    - 请求参数变更
      - `+ data.language`
  - **RunCreateAudioModerationJob**
    - 请求参数变更
      - `+ data.language`

# 3.1.99 2024-06-13

### HuaweiCloud SDK Core

- _新增特性_
  - 支持请求重试
- _解决问题_
  - 无
- _特性变更_
  - Credentials的SetAk/SetSk方法添加非空检查

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateScalingV2Policy**
    - 请求参数变更
      - `+ interval_alarm_actions`
  - **ListAllScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.interval_alarm_actions`
  - **UpdateScalingV2Policy**
    - 请求参数变更
      - `+ interval_alarm_actions`
  - **ShowScalingV2Policy**
    - 响应参数变更
      - `+ scaling_policy.interval_alarm_actions`
  - **ListScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.interval_alarm_actions`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateMigrationTask**
    - 请求参数变更
      - `+ target_instance.task_status`
  - **ShowMigrationTask**
    - 响应参数变更
      - `+ target_instance.task_status`
  - **StopMigrationTask**
    - 响应参数变更
      - `+ target_instance.task_status`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowServer**
    - 响应参数变更
      - `- server.fault.code`
      - `- server.fault.created`
      - `- server.fault.message`
      - `- server.fault.details`
      - `* server.fault: object<ServerFault> -> object`
  - **ListServersDetails**
    - 响应参数变更
      - `- servers.fault.code`
      - `- servers.fault.created`
      - `- servers.fault.message`
      - `- servers.fault.details`
      - `* servers.fault: object<ServerFault> -> object`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DisassociatePublicips**
    - 响应参数变更
      - `- publicip.associate_instance_type: enum value [null]`
  - **AssociatePublicips**
    - 响应参数变更
      - `- publicip.associate_instance_type: enum value [null]`
  - **UpdatePublicip**
    - 请求参数变更
      - `+ publicip.associate_instance_type: enum value [VPN]`
      - `- publicip.associate_instance_type: enum value []`
    - 响应参数变更
      - `- publicip.associate_instance_type: enum value [null]`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDedicatedResourceInfo**
    - 响应参数变更
      - `+ resource_name`
      - `- name`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowReplayDelayStatus**
    - 响应参数变更
      - `+ delay_time_value_range`

### HuaweiCloud SDK VPC

- _新增特性_
  - 支持以下接口：
    - `ListSecurityGroupsByTags`
    - `BatchCreateSecurityGroupTags`
    - `BatchDeleteSecurityGroupTags`
    - `ShowSecurityGroupTags`
    - `CreateSecurityGroupTag`
    - `DeleteSecurityGroupTag`
    - `ListSecurityGroupTags`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.98 2024-06-06

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ spec.serverEnterpriseProjectID`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.serverEnterpriseProjectID`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.serverEnterpriseProjectID`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.serverEnterpriseProjectID`
    - 响应参数变更
      - `+ spec.serverEnterpriseProjectID`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.serverEnterpriseProjectID`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **UpdateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
    - 响应参数变更
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
    - 响应参数变更
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.nodeTemplate.serverEnterpriseProjectID`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ChangeVpc**
    - 请求参数变更
      - `* nic.security_groups: object<ChangeVpcSecurityGroups> -> list<ChangeVpcSecurityGroups>`
  - **ListFlavors**
    - 响应参数变更
      - `+ flavors.os_extra_specs.cond:storage:type`
  - **ListResizeFlavors**
    - 响应参数变更
      - `+ flavors.extra_specs.cond:storage:type`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `ShowLtsConfigs`
    - `CreateLtsConfigs`
    - `DeleteLtsConfigs`
    - `ShowRecyclePolicy`
    - `SetRecyclePolicy`
    - `ListRecycleInstances`
    - `ShowSlowlogSensitiveStatus`
    - `UpdateSlowlogSensitiveSwitch`
    - `RestartProxyInstance`
    - `RenameInstanceNode`
    - `ShowAutoScalingHistory`
    - `UpdateServerlessPolicy`
    - `ModifyNodePriority`
    - `ShowInstanceEip`
    - `ListParamsTemplateApplyHistory`
    - `ShowProxyConfigurations`
- _解决问题_
  - 无
- _特性变更_
  - **ShowProxyIpgroup**
    - 响应参数变更
      - `+ ip_group.id`
      - `+ ip_group.name`
      - `+ ip_group.ip_list`
      - `* ip_group: object -> object<ProxyIpGroupDetail>`
  - **UpdateGaussMySqlInstanceName**
    - 请求参数变更
      - `+ is_modify_node_name`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **OfflineNodes**
    - 响应参数变更
      - `+ job_id`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAvailableFlavors**
    - 响应参数变更
      - `+ flavors.spec_code`
      - `- flavors.spec_cpde`
  - **ListRestorableInstances**
    - 响应参数变更
      - `* instances.version: number -> string`
  - **ListDbUsers**
    - 响应参数变更
      - `+ users.attribute`
      - `+ users.lock_status`
      - `- users.attributes`
  - **ShowUpgradeCandidateVersions**
    - 响应参数变更
      - `+ hotfix_upgrade_infos`
      - `+ hotfix_rollback_infos`

### HuaweiCloud SDK ImageSearch

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunSearch**
    - 请求参数变更
      - `+ text`
      - `+ search_type: enum value [TEXT]`
      - `+ optional_params.text_lang`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateLogStreamIndex**
    - 请求参数变更
      - `+ sqlAnalysisEnable`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ShowReplayDelayStatus`、`SwitchLogReplay`、`ListShareBackups`
- _解决问题_
  - 无
- _特性变更_
  - **ListBackups**
    - 请求参数变更
      - `+ status`

# 3.1.97 2024-05-30

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowHistoryTaskDetails**
    - 响应参数变更
      - `+ urls.fail_classify`
      - `+ urls.fail_desc`
  - **ListDomains**
    - 响应参数变更
      - `+ domains.sources.obs_bucket_type`
  - **CreateDomain**
    - 请求参数变更
      - `+ domain.sources.obs_bucket_type`
      - `* domain.sources: list<Sources> -> list<SourcesRequestBody>`
    - 响应参数变更
      - `+ domain.sources.obs_bucket_type`
  - **DeleteDomain**
    - 响应参数变更
      - `+ domain.sources.obs_bucket_type`
  - **EnableDomain**
    - 响应参数变更
      - `+ domain.sources.obs_bucket_type`
  - **DisableDomain**
    - 响应参数变更
      - `+ domain.sources.obs_bucket_type`
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.access_area_filter`
      - `* configs.sources: list<SourcesConfig> -> list<SourcesConfigResponseBody>`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.access_area_filter`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`ChangeServerNetworkInterface`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`UpgradeProxyVersion`、`UpdateProxyName`、`ShowProxyIpgroup`、`ShowProxyVersion`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **SearchAutoEnlargePolicy**
    - 响应参数变更
      - `+ step_percent`
      - `+ step_size`
  - **UpdateInstanceConfiguration**
    - 响应参数变更
      - `+ job_id`
  - **CreateConfigurationTemplate**
    - 请求参数变更
      - `+ datastore.instance_mode: enum value [ha:readonly]`
  - **ListDatabases**
    - 响应参数变更
      - `+ databases.datctype`
      - `+ databases.compatibility_type`
  - **ListTasks**
    - 响应参数变更
      - `+ tasks.created_at`
      - `+ tasks.ended_at`
  - **ListComponentInfos**
    - 响应参数变更
      - `+ nodes.components.type`
      - `+ nodes.components.detail`
  - **ShowUpgradeCandidateVersions**
    - 响应参数变更
      - `+ upgrade_type_list.is_parallel_upgrade`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持以下接口：
    - `ListBridges`
    - `AddBridge`
    - `DeleteBridge`
    - `ResetBridgeSecret`
    - `ListDeviceGroupsByDevice`
    - `UpdateCertificate`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VPC

- _新增特性_
  - 支持以下接口：
    - `ListClouddcnSubnets`
    - `CreateClouddcnSubnet`
    - `ShowClouddcnSubnet`
    - `UpdateClouddcnSubnet`
    - `DeleteClouddcnSubnet`
    - `ShowClouddcnSubnetsTags`
    - `AddClouddcnSubnetsTags`
    - `ListClouddcnSubnetsFilterTags`
    - `DeleteClouddcnSubnetsTag`
    - `ListClouddcnSubnetsCountFilterTags`
    - `ListClouddcnSubnetsTags`
    - `BatchDeleteClouddcnSubnetsTags`
    - `BatchCreateClouddcnSubnetsTags`
- _解决问题_
  - 无
- _特性变更_
  - **ListSecurityGroups**
    - 响应参数变更
      - `+ security_groups.tags`
  - **CreateSecurityGroup**
    - 请求参数变更
      - `+ security_group.tags`
    - 响应参数变更
      - `+ security_group.tags`
  - **ShowSecurityGroup**
    - 响应参数变更
      - `+ security_group.tags`
  - **UpdateSecurityGroup**
    - 响应参数变更
      - `+ security_group.tags`
  - **CreateFirewall**
    - 请求参数变更
      - `+ firewall.tags`

# 3.1.96 2024-05-23

### HuaweiCloud SDK Organizations

- _新增特性_
  - 支持组织服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateScalingGroup**
    - 请求参数变更
      - `+ tags`
  - **ListScalingGroups**
    - 响应参数变更
      - `+ scaling_groups.tags`
  - **ShowScalingGroup**
    - 响应参数变更
      - `+ scaling_group.tags`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ShowRedisBigKeys`、`ShowPasswordlessConfig`、`UpdatePasswordlessConfig`
- _解决问题_
  - 无
- _特性变更_
  - **OfflineNodes**
    - 请求参数变更
      - `* x-auth-token: optional -> required`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`DownloadErrorlog`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.95 2024-05-16

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 废弃接口`UpdateDomainFullConfig`、`ShowDomainFullConfig`
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.https.enc_certificate_value`
      - `+ configs.https.certificates`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.https.enc_certificate_value`
      - `+ configs.https.enc_private_key`
      - `+ configs.https.certificates`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListClients**
    - 响应参数变更
      - `* clients.idle: string -> int32`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `CreateStarrocksInstance`
    - `ListStarrocksInstanceInfo`
    - `DeleteStarrocksInstance`
    - `RestartStarrocksInstance`
    - `RestartStarrocksNode`
    - `CheckStarRocksResource`
    - `ListHtapDataStore`
    - `ListHtapStorageType`
    - `ListHtapFlavor`
    - `ListHtapInstanceInfo`
    - `ShowStarRocksDatabaseUser`
    - `CreateStarRocksDatabaseUser`
    - `DeleteStarRocksDatabaseUser`
    - `UpdateStarRocksDatabaseUserPassword`
    - `UpdateStarRocksDatabaseUserPermission`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持接口`RestoreInstance`
- _解决问题_
  - 无
- _特性变更_
  - **CreateDbInstance**
    - 请求参数变更
      - `+ enable_single_float_ip`

### HuaweiCloud SDK IAM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListCustomPolicies**
    - 响应参数变更
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **CreateCloudServiceCustomPolicy**
    - 请求参数变更
      - `* role.policy.Statement.Resource: list<string> -> object`
    - 响应参数变更
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **ShowCustomPolicy**
    - 响应参数变更
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **UpdateCloudServiceCustomPolicy**
    - 请求参数变更
      - `* role.policy.Statement.Resource: list<string> -> object`
    - 响应参数变更
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **CreateTemporaryAccessKeyByToken**
    - 请求参数变更
      - `* auth.identity.policy.Statement.Resource: list<string> -> object`
  - **CreateTemporaryAccessKeyByAgency**
    - 请求参数变更
      - `* auth.identity.policy.Statement.Resource: list<string> -> object`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListLogs**
    - 请求参数变更
      - `+ __time__`
  - **ListStructuredLogsWithTimeRange**
    - 请求参数变更
      - `* time_range.start_time: string -> int64`
      - `* time_range.end_time: string -> int64`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeSmartDocumentRecognizer**
    - 请求参数变更
      - `+ pdf_page_number`

# 3.1.94 2024-05-09

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持以下接口：
    - `ListObejectLevelCompareOverview`
    - `CreateObjectLevelCompareJob`
    - `ListObejectLevelCompareDetail`
    - `ListContentCompareDifference`
    - `DownloadCompareResultFile`
    - `CreateCompareResultFile`
    - `ShowHealthCompareJobDetail`
    - `ShowHealthObjectCompareJobOverview`
    - `UpdateComparePolicy`
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateJobs**
    - 请求参数变更
      - `+ jobs.source_endpoint.kafka_security_config`
  - **BatchValidateConnections**
    - 请求参数变更
      - `+ jobs.kafka_security_config.endpoint_algorithm`
      - `+ jobs.kafka_security_config.sasl_mechanism`
      - `+ jobs.kafka_security_config.delegation_tokens`
      - `+ jobs.kafka_security_config.enable_key_store`
      - `+ jobs.kafka_security_config.key_store_key`
      - `+ jobs.kafka_security_config.key_store_key_name`
      - `+ jobs.kafka_security_config.key_store_password`
      - `+ jobs.kafka_security_config.set_private_key_password`
      - `+ jobs.kafka_security_config.key_password`
      - `+ jobs.kafka_security_config.type: enum value [SASL_PLAINTEXT,SSL]`
  - **ShowJobList**
    - 响应参数变更
      - `+ jobs.children.job_direction: enum value [no-dbs]`
      - `- jobs.children.job_direction: enum value [non-dbs]`
  - **BatchUpdateJob**
    - 请求参数变更
      - `+ jobs.source_endpoint.kafka_security_config`
  - **BatchListJobDetails**
    - 响应参数变更
      - `+ results.source_endpoint.kafka_security_config`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.is_writable`
      - `+ jobs.compare_result.content_diff_detail_info`
      - `+ jobs.compare_result.content_compare_overview_infos.status: enum value [WAIT_FOR_COMPARE,CANCELED]`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.type: enum value [notify]`
  - **ShowJobDetail**
    - 请求参数变更
      - `+ type: enum value [is_writable,cloud_connection]`
    - 响应参数变更
      - `+ job.is_writable`
      - `+ job.compare_result.content_diff_detail_info`
      - `+ job.compare_result.content_compare_overview_infos.status: enum value [WAIT_FOR_COMPARE,CANCELED]`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.type: enum value [notify]`
  - **ExecuteJobAction**
    - 请求参数变更
      - `+ job.action_name: enum value [set_writable,cloud_connection]`
      - `+ job.action_params.replay_config`
  - **BatchExecuteJobActions**
    - 请求参数变更
      - `+ jobs.action_name: enum value [set_writable,cloud_connection]`
      - `+ jobs.action_params.replay_config`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`ChangeVpc`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateFunctionCode**
    - 请求参数变更
      - `- depend_list`
  - **CreateFunction**
    - 请求参数变更
      - `+ gpu_type`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `ListStarRocksDataReplications`
    - `CreateStarRocksDataReplication`
    - `DeleteStarRocksDataReplication`
    - `CheckDataBaseConfig`
    - `CheckTableConfig`
    - `ListStarRocksDataReplicationConfig`
    - `ListStarRocksDbParameters`
    - `ListStarRocksDataBases`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK MPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateTranscodingTask**
    - 请求参数变更
      - `+ video_process.hls_segment_type`

# 3.1.93 2024-04-30

### HuaweiCloud SDK AOS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **EstimateExecutionPlanPrice**
    - 响应参数变更
      - `- currency: enum value [CNY,USD]`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `+ product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
  - **ShowInstance**
    - 响应参数变更
      - `+ available_zone_names`
      - `+ enterprise_project_id`
  - **CreateTopicOrBatchDeleteTopic**
    - 请求参数变更
      - `+ queues`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
  - **ListInstances**
    - 响应参数变更
      - `+ available_zone_names`
      - `+ enterprise_project_id`
      - `+ instances.available_zone_names`
      - `+ instances.enterprise_project_id`

# 3.1.92 2024-04-25

### HuaweiCloud SDK AAD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowUnblockRecord**
    - 响应参数变更
      - `* unblock_record.block_id: string -> int64`

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDeployTaskDetail**
    - 响应参数变更
      - `+ is_disable`
      - `+ can_disable`
  - **ListDeployTasks**
    - 响应参数变更
      - `+ is_disable`
      - `+ can_disable`
      - `+ result.can_disable`
      - `+ result.is_disable`
  - **ListAllApp**
    - 响应参数变更
      - `+ result.is_disable`
      - `+ result.can_disable`
  - **ShowAppDetailById**
    - 响应参数变更
      - `+ result.is_disable`
      - `+ result.can_disable`
      - `+ result.arrange_infos.can_disable`
      - `+ result.arrange_infos.is_disable`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateMigrationTask**
    - 请求参数变更
      - `+ source_instance.task_status`
      - `+ source_instance.id`
      - `+ source_instance.ip`
      - `+ source_instance.port`
      - `+ source_instance.name`
      - `+ source_instance.proxy_multi_db`
      - `+ source_instance.db`
      - `+ target_instance.ip`
      - `+ target_instance.port`
      - `+ target_instance.addrs`
      - `+ target_instance.proxy_multi_db`
      - `+ target_instance.db`
  - **ShowMigrationTask**
    - 响应参数变更
      - `+ source_instance.task_status`
      - `+ source_instance.id`
      - `+ source_instance.ip`
      - `+ source_instance.port`
      - `+ source_instance.name`
      - `+ source_instance.proxy_multi_db`
      - `+ source_instance.db`
      - `+ target_instance.ip`
      - `+ target_instance.port`
      - `+ target_instance.addrs`
      - `+ target_instance.proxy_multi_db`
      - `+ target_instance.db`
  - **StopMigrationTask**
    - 响应参数变更
      - `+ source_instance.task_status`
      - `+ source_instance.id`
      - `+ source_instance.ip`
      - `+ source_instance.port`
      - `+ source_instance.name`
      - `+ source_instance.proxy_multi_db`
      - `+ source_instance.db`
      - `+ target_instance.ip`
      - `+ target_instance.port`
      - `+ target_instance.addrs`
      - `+ target_instance.proxy_multi_db`
      - `+ target_instance.db`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 响应参数变更
      - `+ instances.availability_zone`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持以下接口：
    - `ListDeviceProxies`
    - `CreateDeviceProxy`
    - `ShowDeviceProxy`
    - `UpdateDeviceProxy`
    - `DeleteDeviceProxy`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunCreateVideoModerationJob**
    - 请求参数变更
      - `+ seed`
  - **RunCreateAudioStreamModerationJob**
    - 请求参数变更
      - `+ seed`
  - **RunCreateDocumentModerationJob**
    - 请求参数变更
      - `+ seed`
  - **RunCreateVideoStreamModerationJob**
    - 请求参数变更
      - `+ seed`
  - **RunCreateAudioModerationJob**
    - 请求参数变更
      - `+ seed`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeBankReceipt`
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeBusinessLicense**
    - 响应参数变更
      - `+ result.organization_form`
  - **RecognizeSmartDocumentRecognizer**
    - 请求参数变更
      - `+ formula`
    - 响应参数变更
      - `+ result.formula_result`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateFirewall**
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **ShowFirewall**
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **UpdateFirewall**
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **UpdateFirewallRules**
    - 请求参数变更
      - `+ firewall.ingress_rules.enabled`
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **AddFirewallRules**
    - 请求参数变更
      - `+ firewall.ingress_rules.enabled`
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **RemoveFirewallRules**
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **AssociateSubnetFirewall**
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`
  - **DisassociateSubnetFirewall**
    - 响应参数变更
      - `+ firewall.ingress_rules.enabled`

# 3.1.91 2024-04-18

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEvents**
    - 请求参数变更
      - `+ Enterprise-Project-Id`
  - **CountEvents**
    - 响应参数变更
      - `+ summary`
  - **UpdateAlarmRule**
    - 请求参数变更
      - `+ period: enum value [3600000]`
      - `- period: enum value [36000000]`
  - **AddAlarmRule**
    - 请求参数变更
      - `+ period: enum value [3600000]`
      - `- period: enum value [36000000]`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListMigrationTask**
    - 响应参数变更
      - `+ migration_tasks.description`
      - `+ migration_tasks.source_instance_status`
      - `+ migration_tasks.target_instance_status`
      - `+ migration_tasks.source_instance_subnet_id`
      - `+ migration_tasks.target_instance_subnet_id`
      - `+ migration_tasks.source_instance_spec_code`
      - `+ migration_tasks.target_instance_spec_code`
      - `+ migration_tasks.error_message`
      - `+ migration_tasks.released_at`
      - `+ migration_tasks.version`
      - `+ migration_tasks.resume_mode`
      - `+ migration_tasks.supported_features`
  - **ShowMigrationTask**
    - 响应参数变更
      - `+ task_status`
      - `+ tenant_security_group_id`
      - `+ tenant_vpc_id`
      - `+ released_at`
      - `+ version`
      - `+ resume_mode`
      - `+ supported_features`
      - `+ bandwidth_limit_mb`
      - `+ tenant_subnet_id`
  - **StopMigrationTask**
    - 响应参数变更
      - `+ task_status`
      - `+ tenant_security_group_id`
      - `+ tenant_vpc_id`
      - `+ released_at`
      - `+ version`
      - `+ resume_mode`
      - `+ supported_features`
      - `+ bandwidth_limit_mb`
      - `+ tenant_subnet_id`
  - **ListBackgroundTask**
    - 响应参数变更
      - `+ tasks.details.old_resource_spec_code`
      - `+ tasks.details.new_resource_spec_code`
      - `+ tasks.details.old_replica_num`
      - `+ tasks.details.new_replica_num`
      - `+ tasks.details.old_cache_type`
      - `+ tasks.details.new_cache_type`
      - `+ tasks.details.replica_ip`
      - `+ tasks.details.replica_az`
      - `+ tasks.details.group_name`
      - `+ tasks.details.old_port`
      - `+ tasks.details.new_port`
      - `+ tasks.details.is_only_adjust_charging`
      - `+ tasks.details.account_name`
      - `+ tasks.details.source_ip`
      - `+ tasks.details.target_ip`
      - `+ tasks.details.node_name`
      - `+ tasks.details.rename_commands`
      - `+ tasks.details.updated_config_length`
  - **ListCenterTask**
    - 响应参数变更
      - `+ tasks.details.old_resource_spec_code`
      - `+ tasks.details.new_resource_spec_code`
      - `+ tasks.details.old_replica_num`
      - `+ tasks.details.new_replica_num`
      - `+ tasks.details.old_cache_type`
      - `+ tasks.details.new_cache_type`
      - `+ tasks.details.replica_ip`
      - `+ tasks.details.replica_az`
      - `+ tasks.details.group_name`
      - `+ tasks.details.old_port`
      - `+ tasks.details.new_port`
      - `+ tasks.details.is_only_adjust_charging`
      - `+ tasks.details.account_name`
      - `+ tasks.details.source_ip`
      - `+ tasks.details.target_ip`
      - `+ tasks.details.node_name`
      - `+ tasks.details.rename_commands`
      - `+ tasks.details.updated_config_length`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持接口`ListTopIoTraffics`、`ShowErrorLogSwitchStatus`、`ListInstanceErrorLogs`、`DeleteInstanceTag`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowInstancesStatistics`
  - **UpgradeInstanceVersion**
    - 请求参数变更
      - `+ upgrade_action`
      - `- upgrde_action`
      - `- is_parallel_upgrade`
  - **ShowBackupPolicy**
    - 响应参数变更
      - `* backup_policy.differential_period: string -> int32`

### HuaweiCloud SDK TMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DeleteResourceTag**
    - 请求参数变更
      - `+ tags.value`

# 3.1.90 2024-04-11

### HuaweiCloud SDK AOS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowStackSetMetadata**
    - 响应参数变更
      - `+ managed_operation`
  - **UpdateStackSet**
    - 请求参数变更
      - `+ managed_operation`
  - **CreateStackSet**
    - 请求参数变更
      - `+ managed_operation`
  - **CreateStackInstance**
    - 请求参数变更
      - `+ operation_preferences`
  - **DeleteStackInstanceDeprecated**
    - 请求参数变更
      - `+ operation_preferences`
  - **UpdateStackInstances**
    - 请求参数变更
      - `+ operation_preferences`
  - **DeleteStackInstance**
    - 请求参数变更
      - `+ operation_preferences`
  - **DeployStackSet**
    - 请求参数变更
      - `+ operation_preferences`
  - **ShowStackSetOperationMetadata**
    - 响应参数变更
      - `+ operation_preferences`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowQuota`
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.sni`
      - `+ configs.request_url_rewrite`
      - `+ configs.browser_cache_rules`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.sni`
      - `+ configs.request_url_rewrite`
      - `+ configs.browser_cache_rules`

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持以下接口：
    - `ListDataLevelTableCompareJobs`
    - `CreateDataLevelTableCompareJob`
    - `DeleteCompareJob`
    - `StartPromptlyDataLevelTableCompareJob`
    - `ListDataCompareOverview`
    - `ListDataCompareDetail`
    - `ListContentCompareOverview`
    - `ListContentCompareDetail`
    - `ListsAgencyPermissions`
    - `ShowReplayResults`
- _解决问题_
  - 无
- _特性变更_
  - **ShowDataFilteringResult**
    - 响应参数变更
      - `+ db_object_filtering_result.source`
      - `+ db_object_filtering_result.target_result`
      - `+ db_object_filtering_result.source_result`
      - `+ db_object_filtering_result.target_message`
      - `+ db_object_filtering_result.source_message`
  - **ShowDataProgress**
    - 响应参数变更
      - `+ data_process_info.source`
  - **UpdateDataProgress**
    - 请求参数变更
      - `+ data_process_info.source`
  - **CheckDataFilter**
    - 请求参数变更
      - `+ data_process_info.source`
  - **ExecuteJobAction**
    - 请求参数变更
      - `+ job.action_params.compare_task_param.data_process_info`
  - **BatchExecuteJobActions**
    - 请求参数变更
      - `+ jobs.action_params.compare_task_param.data_process_info`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持以下接口：
    - `ShowInstancesStatistics`
    - `ShowSlowLogDownload`
    - `CreateSlowLogDownload`
    - `UpgradeInstanceVersion`
    - `SearchAutoEnlargePolicy`
    - `ListCnInfosBeforeReduce`
    - `StartInstance`
    - `ShowUpgradeCandidateVersions`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持以下接口：
    - `ListRoutingBacklogPolicy`
    - `CreateRoutingBacklogPolicy`
    - `ShowRoutingBacklogPolicy`
    - `UpdateRoutingBacklogPolicy`
    - `DeleteRoutingBacklogPolicy`
    - `ListRoutingFlowControlPolicy`
    - `CreateRoutingFlowControlPolicy`
    - `ShowRoutingFlowControlPolicy`
    - `UpdateRoutingFlowControlPolicy`
    - `DeleteRoutingFlowControlPolicy`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 请求参数变更
      - `* engine: optional -> required`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`BatchListAssociatedIssues`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstancesDetails**
    - 请求参数变更
      - `* engine: optional -> required`
      - `+ engine: enum value [rabbitmq]`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowReplayDelayStatus`、`SwitchLogReplay`
  - **StartResizeFlavorAction**
    - 请求参数变更
      - `+ resize_flavor.is_delay`
  - **ListPostgresqlDatabases**
    - 请求参数变更
      - `+ db`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 请求参数变更
      - `* engine: optional -> required`
      - `+ engine: enum value [rocketmq]`
      - `+ engine: enum value [reliability]`

### HuaweiCloud SDK SWR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSharedReposDetails**
    - 请求参数变更
      - `* center: optional -> required`

# 3.1.89 2024-04-03

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListFlowLogs**
    - 请求参数变更
      - `+ src_region_name`
      - `+ dst_region_name`
    - 响应参数变更
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
  - **ListAccessControlLogs**
    - 请求参数变更
      - `+ src_region_name`
      - `+ dst_region_name`
  - **ListAddressSets**
    - 请求参数变更
      - `+ address_set_type`
  - **ListAttackLogs**
    - 请求参数变更
      - `+ attack_rule_id`
      - `+ src_region_name`
      - `+ dst_region_name`
  - **UpdateAclRuleOrder**
    - 请求参数变更
      - `+ bottom`
  - **ListServiceSetDetail**
    - 请求参数变更
      - `+ query_service_set_type`
  - **AddAclRule**
    - 请求参数变更
      - `+ rules.applications`
      - `+ rules.applicationsJsonString`
      - `+ rules.profile`
      - `+ rules.sequence.bottom`
      - `+ rules.source.address_set_type`
      - `+ rules.source.predefined_group`
      - `- rules.source.address_group`
      - `- rules.source.address_group_names`
      - `* rules.source: object<RuleAddressDto> -> object<RuleAddressDtoForRequest>`
      - `+ rules.service.protocols`
      - `+ rules.service.predefined_group`
      - `+ rules.service.service_set_type`
      - `+ rules.service.service_group_names.protocols`
      - `+ rules.service.service_group_names.service_set_type`
  - **UpdateAclRule**
    - 请求参数变更
      - `+ applications`
      - `+ applicationsJsonString`
      - `+ profile`
      - `+ sequence.bottom`
      - `+ source.address_set_type`
      - `+ source.predefined_group`
      - `+ source.address_group_names.protocols`
      - `+ source.address_group_names.service_set_type`
      - `+ service.protocols`
      - `+ service.predefined_group`
      - `+ service.service_set_type`
  - **ListAclRules**
    - 请求参数变更
      - `+ application`
    - 响应参数变更
      - `+ data.records.sequence.bottom`
      - `+ data.records.source.address_set_type`
      - `+ data.records.source.predefined_group`
      - `+ data.records.source.address_group_names.protocols`
      - `+ data.records.source.address_group_names.service_set_type`
      - `+ data.records.service.protocols`
      - `+ data.records.service.predefined_group`
      - `+ data.records.service.service_set_type`
  - **ListServiceItems**
    - 请求参数变更
      - `+ query_service_set_type`
  - **ListAddressItems**
    - 请求参数变更
      - `+ query_address_set_type`
  - **ListServiceSets**
    - 请求参数变更
      - `+ query_service_set_type`
  - **ListDomainSets**
    - 响应参数变更
      - `+ data.records.rules`
  - **ListFirewallDetail**
    - 请求参数变更
      - `+ name`
    - 响应参数变更
      - `+ data.records.tags`
      - `+ data.records.flavor.default_bandwidth`
      - `+ data.records.flavor.default_eip_count`
      - `+ data.records.flavor.default_log_storage`
      - `+ data.records.flavor.default_vpc_count`
  - **ListFirewallList**
    - 响应参数变更
      - `+ data.records.tags`
      - `+ data.records.flavor.default_bandwidth`
      - `+ data.records.flavor.default_eip_count`
      - `+ data.records.flavor.default_log_storage`
      - `+ data.records.flavor.default_vpc_count`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowServerAutoRecovery`、`RegisterServerAutoRecovery`
  - **ResizePostPaidServer**
    - 请求参数变更
      - `+ resize.cpu_options`
  - **ShowServer**
    - 响应参数变更
      - `+ server.cpu_options.hw:cpu_threads: enum value [1,2]`
  - **ListServersDetails**
    - 响应参数变更
      - `+ servers.cpu_options.hw:cpu_threads: enum value [1,2]`
  - **ChangeServerOsWithCloudInit**
    - 请求参数变更
      - `+ os-change.isAutoPay`
  - **ChangeServerOsWithoutCloudInit**
    - 请求参数变更
      - `+ os-change.isAutoPay`
  - **ResizeServer**
    - 请求参数变更
      - `+ resize.cpu_options`
  - **CreateServers**
    - 请求参数变更
      - `+ server.cpu_options`
  - **CreatePostPaidServers**
    - 请求参数变更
      - `+ server.cpu_options`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListTenantVpcIgws**
    - 请求参数变更
      - `+ offset`
      - `+ marker`
  - **ListProjectGeipBindings**
    - 请求参数变更
      - `+ offset`
      - `+ marker`
    - 响应参数变更
      - `+ geip_bindings.instance_type`
      - `+ geip_bindings.instance_id`
      - `- geip_bindings.binding_instance_type`
      - `- geip_bindings.binding_instance_id`
      - `+ geip_bindings.gcbandwidth.id`
      - `+ geip_bindings.gcbandwidth.admin_status`
      - `+ geip_bindings.gcbandwidth.size`
      - `+ geip_bindings.gcbandwidth.short_id`
      - `+ geip_bindings.gcbandwidth.sla_level`
      - `+ geip_bindings.gcbandwidth.dscp`
      - `* geip_bindings.gcbandwidth: object -> object<BackboneBandwidthResp>`
      - `+ geip_bindings.vnic.private_ip_address`
      - `+ geip_bindings.vnic.device_id`
      - `+ geip_bindings.vnic.device_owner`
      - `+ geip_bindings.vnic.vpc_id`
      - `+ geip_bindings.vnic.port_id`
      - `+ geip_bindings.vnic.mac`
      - `+ geip_bindings.vnic.vtep`
      - `+ geip_bindings.vnic.vni`
      - `+ geip_bindings.vnic.instance_id`
      - `+ geip_bindings.vnic.instance_type`
      - `+ geip_bindings.vnic.port_profile`
      - `* geip_bindings.vnic: object -> object<InstanceVnicResp>`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateDependencyVersion**
    - 请求参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
    - 响应参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowDependencyVersion**
    - 响应参数变更
      - `+ is_shared`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListDependencies**
    - 响应参数变更
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListDependencyVersion**
    - 响应参数变更
      - `+ dependencies.is_shared`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowFunctionCode**
    - 响应参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionCode**
    - 响应参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ImportFunction**
    - 响应参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListFunctions**
    - 响应参数变更
      - `+ functions.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **CreateFunction**
    - 请求参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0,Custom Image]`
    - 响应参数变更
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowFunctionConfig**
    - 响应参数变更
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionConfig**
    - 请求参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0,Custom Image]`
    - 响应参数变更
      - `+ enable_cloud_debug`
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionMaxInstanceConfig**
    - 响应参数变更
      - `+ is_return_stream`
      - `+ enable_cloud_debug`
      - `+ enable_auth_in_header`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListBridgeFunctions**
    - 响应参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListStatistics**
    - 响应参数变更
      - `+ gpu_gbs`
  - **CreateFunctionVersion**
    - 响应参数变更
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListFunctionVersions**
    - 响应参数变更
      - `- versions.enable_cloud_debug`
      - `+ versions.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`

### HuaweiCloud SDK GEIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CountGlobalEips**
    - 响应参数变更
      - `+ global_eip`
      - `- global_eips`
      - `- page_info`
  - **BatchCreateGlobalEip**
    - 响应参数变更
      - `+ global_eips`
      - `- global_eip`
  - **CountGlobalEipSegment**
    - 响应参数变更
      - `+ global_eip_segment`
      - `- global_eip_segments`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowConnectorTask**
    - 响应参数变更
      - `+ topics_regex`
  - **CreateConnectorTask**
    - 响应参数变更
      - `+ topics_regex`
  - **ListConnectorTasks**
    - 响应参数变更
      - `+ topics_regex`
      - `+ tasks.topics_regex`

### HuaweiCloud SDK KMS

- _新增特性_
  - 支持接口`GenerateMac`、`VerifyMac`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ShowReplayDelayStatus`、`SwitchLogReplay`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateConsumerGroup**
    - 请求参数变更
      - `- from_beginning`
  - **ListMessageTrace**
    - 响应参数变更
      - `+ trace.trace_type: enum value [SubBefore,SubAfter]`
      - `- trace.trace_type: enum value [Sub]`
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `* max: number -> int32`
      - `* remaining: number -> int32`
      - `* next_offset: number -> int32`
      - `* previous_offset: number -> int32`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSubNetworkInterfaces**
    - 响应参数变更
      - `+ sub_network_interfaces.security_enabled`
  - **CreateSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interface.security_enabled`
  - **BatchCreateSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interfaces.security_enabled`
  - **ShowSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interface.security_enabled`
  - **UpdateSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interface.security_enabled`
  - **MigrateSubNetworkInterface**
    - 响应参数变更
      - `+ sub_network_interfaces.security_enabled`

# 3.1.88 2024-04-01

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListBareMetalServers**
    - 响应参数变更
      - `- servers.image.name`
      - `- servers.image.__os_type`
      - `- servers.image.links`
  - **ListBareMetalServerDetails**
    - 响应参数变更
      - `- server.image.name`
      - `- server.image.__os_type`
      - `- server.image.links`

### HuaweiCloud SDK KPS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateKeypair**
    - 请求参数变更
      - `+ keypair.key_protection.encryption.kms_key_id`
  - **ImportPrivateKey**
    - 请求参数变更
      - `+ keypair.key_protection.encryption.kms_key_id`
    - 响应参数变更
      - `+ keypair.key_protection.encryption.kms_key_id`

# 3.1.87 2024-03-28

### HuaweiCloud SDK CBR

- _新增特性_
  - 支持以下接口：
    - `ListOrganizationPolicies`
    - `CreateOrganizationPolicy`
    - `ShowOrganizationPolicy`
    - `UpdateOrganizationPolicy`
    - `DeleteOrganizationPolicy`
    - `ListOrganizationPolicyDetail`
- _解决问题_
  - 无
- _特性变更_
  - **ShowBackup**
    - 响应参数变更
      - `+ backup.incremental`
      - `- backup.extend_info.incremental`
  - **UpdateBackup**
    - 响应参数变更
      - `+ backup.incremental`
      - `- backup.extend_info.incremental`
  - **ListBackups**
    - 响应参数变更
      - `+ backups.incremental`
      - `- backups.extend_info.incremental`
  - **ListVault**
    - 响应参数变更
      - `- sys_lock_source_service`
  - **CreateVault**
    - 请求参数变更
      - `+ vault.sys_lock_source_service`
  - **ListExternalVault**
    - 响应参数变更
      - `- sys_lock_source_service`

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNodePoolConfigurationDetails**
    - 响应参数变更
      - `- kubelet`
  - **ShowClusterConfigurationDetails**
    - 响应参数变更
      - `- kube-apiserver`
  - **ShowCluster**
    - 响应参数变更
      - `- spec.enableAutopilot`
  - **UpdateCluster**
    - 响应参数变更
      - `- spec.enableAutopilot`
  - **DeleteCluster**
    - 请求参数变更
      - `+ lts_reclaim_policy`
    - 响应参数变更
      - `- spec.enableAutopilot`
  - **CreateCluster**
    - 请求参数变更
      - `- spec.enableAutopilot`
    - 响应参数变更
      - `- spec.enableAutopilot`
  - **ListClusters**
    - 响应参数变更
      - `- items.spec.enableAutopilot`

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListFlowLogs**
    - 响应参数变更
      - `* data.records.bytes: int32 -> double`

### HuaweiCloud SDK CTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateTracker**
    - 请求参数变更
      - `+ agency_name`
  - **CreateTracker**
    - 请求参数变更
      - `+ agency_name`
    - 响应参数变更
      - `+ agency_name`
  - **ListTrackers**
    - 响应参数变更
      - `+ trackers.agency_name`
  - **UpdateNotification**
    - 请求参数变更
      - `+ agency_name`
    - 响应参数变更
      - `+ agency_name`
  - **CreateNotification**
    - 请求参数变更
      - `+ agency_name`
    - 响应参数变更
      - `+ agency_name`
  - **ListNotifications**
    - 响应参数变更
      - `+ notifications.agency_name`

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunImageMediaTagging**
    - 请求参数变更
      - `- use_default_tags`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`UpdateApplication`
- _解决问题_
  - 无
- _特性变更_
  - **CreateBatchTask**
    - 请求参数变更
      - `+ task_mode`
      - `+ task_ext_info`
    - 响应参数变更
      - `+ task_ext_info`
      - `+ task_mode`
  - **ListBatchTasks**
    - 响应参数变更
      - `+ task_ext_info`
      - `+ task_mode`
      - `+ batchtasks.task_mode`
      - `+ batchtasks.task_ext_info`
  - **ShowBatchTask**
    - 响应参数变更
      - `+ task_ext_info`
      - `+ task_mode`
      - `+ batchtask.task_mode`
      - `+ batchtask.task_ext_info`
  - **CreateOtaPackage**
    - 请求参数变更
      - `+ file_location.obs_location.sign`
    - 响应参数变更
      - `+ file_location.obs_location.sign`
  - **ShowOtaPackage**
    - 响应参数变更
      - `+ file_location.obs_location.sign`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持以下接口：
    - `ShowDiagnosisPreCheck`
    - `ListMessageDiagnosisReports`
    - `CreateMessageDiagnosisTask`
    - `BatchDeleteMessageDiagnosisReports`
    - `ShowMessageDiagnosisReport`
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ ipv6_enable`
  - **ShowInstance**
    - 响应参数变更
      - `+ broker_ssl_enable`
      - `+ new_auth_cert`
      - `+ available_zone_names`
  - **ShowConnectorTask**
    - 响应参数变更
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- ipv6_enable`
  - **ListInstances**
    - 响应参数变更
      - `+ broker_ssl_enable`
      - `+ new_auth_cert`
      - `+ available_zone_names`
      - `+ instances.broker_ssl_enable`
      - `+ instances.available_zone_names`
      - `+ instances.new_auth_cert`
  - **CreateConnectorTask**
    - 请求参数变更
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
    - 响应参数变更
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
  - **ListConnectorTasks**
    - 响应参数变更
      - `+ tasks.source_task.rename_topic_enabled`
      - `- tasks.source_task.rename_topic_enable`
  - **CreateReassignmentTask**
    - 请求参数变更
      - `+ time_estimate`
    - 响应参数变更
      - `+ reassignment_time`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeMvsInvoice**
    - 响应参数变更
      - `+ result.reverse_issue`
  - **RecognizeThailandLicensePlate**
    - 响应参数变更
      - `+ result.province`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`BatchStopInstance`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListMessageTrace**
    - 响应参数变更
      - `* trace.retry_times: string -> int32`
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [4.8.0]`
      - `+ product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.2u8g.single.arm](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
      - `- product_id: enum value [c6.4u8g.cluster.small,c6.4u8g.cluster,c6.8u16g.cluster,c6.12u24g.cluster,c6.16u32g.cluster]`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - 请求参数变更
      - `- createdAt`
      - `- permissions`
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `* groups.createdAt: string -> int64`
  - **BatchUpdateConsumerGroup**
    - 请求参数变更
      - `- groups.createdAt`
      - `- groups.permissions`
      - `* groups: list<ConsumerGroup> -> list<CreateOrUpdateConsumerGroup>`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [4.8.0]`
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
      - `- product_id: enum value [c6.4u8g.cluster,c6.8u16g.cluster,c6.12u24g.cluster,c6.16u32g.cluster]`

# 3.1.86 2024-03-21

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DeletePromInstance**
    - 请求参数变更
      - `+ Enterprise-Project-Id`
  - **ListPromInstance**
    - 请求参数变更
      - `+ Enterprise-Project-Id`
      - `+ prom_type: enum value [default]`
      - `+ prom_type: enum value [DEFAULT]`
    - 响应参数变更
      - `+ prometheus.prom_type: enum value [default]`
      - `- prometheus.prom_type: enum value [DEFAULT]`

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`ShowNodePoolConfigurationDetails`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowVerifyDomainOwnerInfo**
    - 响应参数变更
      - `+ file_verify_domains`

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateApp**
    - 请求参数变更
      - `+ group_id`

### HuaweiCloud SDK DRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowPositionResult**
    - 响应参数变更
      - `+ status`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateFunction**
    - 请求参数变更
      - `+ encrypted_user_data`
      - `+ mount_config`
      - `+ is_stateful_function`
      - `+ enable_dynamic_memory`
  - **UpdateVersionAlias**
    - 请求参数变更
      - `+ additional_version_strategy`
  - **DeleteFunctionTrigger**
    - 请求参数变更
      - `+ trigger_type_code: enum value [IOTDA]`
  - **ShowFunctionTrigger**
    - 请求参数变更
      - `+ trigger_type_code: enum value [IOTDA]`
  - **UpdateTrigger**
    - 请求参数变更
      - `+ trigger_type_code: enum value [IOTDA]`

### HuaweiCloud SDK GEIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSupportMasks**
    - 响应参数变更
      - `+ support_masks.ip_version: enum value [4,6]`
  - **ListGlobalEips**
    - 响应参数变更
      - `+ global_eips.ip_version: enum value [4,6]`
  - **DetachInternetBandwidth**
    - 响应参数变更
      - `+ global_eip.ip_version: enum value [4,6]`
  - **BatchCreateGlobalEip**
    - 响应参数变更
      - `+ global_eip.ip_version: enum value [4,6]`
  - **ShowGlobalEip**
    - 响应参数变更
      - `+ global_eip.ip_version: enum value [4,6]`
  - **AttachInternetBandwidth**
    - 响应参数变更
      - `+ global_eip.ip_version: enum value [4,6]`
  - **ListGlobalEipSegments**
    - 响应参数变更
      - `+ global_eip_segments.ip_version: enum value [4,6]`
  - **ShowGlobalEipSegment**
    - 响应参数变更
      - `+ global_eip_segment.ip_version: enum value [4,6]`
  - **ListGeipPools**
    - 响应参数变更
      - `+ geip_pools.ip_version: enum value [4,6]`

### HuaweiCloud SDK Live

- _新增特性_
  - 支持以下接口：
    - `ListOttChannelInfo`
    - `CreateOttChannelInfo`
    - `DeleteOttChannelInfo`
    - `ModifyOttChannelInfoEndPoints`
    - `ModifyOttChannelInfoInput`
    - `ModifyOttChannelInfoRecordSettings`
    - `ModifyOttChannelInfoGeneral`
    - `ModifyOttChannelInfoStats`
    - `ModifyOttChannelInfoEncoderSettings`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListNatGatewaySnatRules**
    - 请求参数变更
      - `* floating_ip_address: string -> list<string>`
      - `* floating_ip_id: string -> list<string>`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeHouseholdRegister`
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeSmartDocumentRecognizer**
    - 请求参数变更
      - `+ form`
      - `+ kv_map`
    - 响应参数变更
      - `+ result.form_result`
      - `+ result.layout_result.layout_block_list.table_id`
      - `+ result.layout_result.layout_block_list.form_id`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAutoEnlargePolicy**
    - 响应参数变更
      - `+ step_percent`
  - **SetAutoEnlargePolicy**
    - 请求参数变更
      - `+ step_percent`

# 3.1.85 2024-03-14

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持接口`ListAvailableNodeTypes`
- _解决问题_
  - 无
- _特性变更_
  - **BatchSetPolicy**
    - 请求参数变更
      - `+ jobs.ddl_topic`
  - **BatchCreateJobs**
    - 请求参数变更
      - `+ jobs.public_ip_list`
  - **ShowJobList**
    - 响应参数变更
      - `+ jobs.children.job_direction: enum value [non-dbs]`
      - `- jobs.children.job_direction: enum value [no-dbs]`
  - **BatchListJobDetails**
    - 响应参数变更
      - `+ results.public_ip_list`
      - `+ results.bind_public_ip_state`
      - `+ results.children`
  - **ShowUpdateObjectSavingStatus**
    - 响应参数变更
      - `+ job_id`
  - **CollectDbObjectsAsync**
    - 响应参数变更
      - `+ job_id`
  - **ShowDataProcessingRulesResult**
    - 响应参数变更
      - `+ job_id`
  - **CollectDbObjectsInfo**
    - 响应参数变更
      - `+ job_id`
  - **CollectPositionAsync**
    - 响应参数变更
      - `+ job_id`
  - **CollectColumns**
    - 响应参数变更
      - `+ job_id`
  - **CreateJob**
    - 请求参数变更
      - `+ job.public_ip_list`
  - **BatchCreateJobsAsync**
    - 请求参数变更
      - `+ jobs.public_ip_list`
  - **UpdateDataProgress**
    - 响应参数变更
      - `+ job_id`
  - **CheckDataFilter**
    - 响应参数变更
      - `+ job_id`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.public_ip_list`
      - `+ jobs.bind_public_ip_state`
      - `+ jobs.children`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.public_ip_list`
      - `+ job.bind_public_ip_state`
      - `+ job.children`
  - **ExecuteJobAction**
    - 请求参数变更
      - `+ job.action_name: enum value [bind_eip,unbind_eip]`
      - `+ job.action_params.public_ip_config`
  - **BatchExecuteJobActions**
    - 请求参数变更
      - `+ jobs.action_name: enum value [bind_eip,unbind_eip]`
      - `+ jobs.action_params.public_ip_config`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowBinlogClearPolicy**
    - 响应参数变更
      - `+ binlog_clear_type`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **AddOrRemoveServicePermissions**
    - 响应参数变更
      - `- permission_type: enum value [domainId,orgPath]`
  - **ListServiceDescribeDetails**
    - 响应参数变更
      - `- service_type: enum value [interface]`
      - `* created_at: string -> date-time`
  - **ListServiceDetails**
    - 响应参数变更
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `- service_type: enum value [gataway,interface]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **UpdateEndpointService**
    - 响应参数变更
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListServicePermissionsDetails**
    - 响应参数变更
      - `- permissions.permission_type: enum value [domainId,orgPath]`
      - `* permissions.created_at: string -> date-time`
  - **ListServicePublicDetails**
    - 响应参数变更
      - `- endpoint_services.service_type: enum value [interface,gateway]`
      - `* endpoint_services.created_at: string -> date-time`
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `- enable_status: enum value [enable,disable]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `* policy_statement: list<string> -> list<PolicyStatement>`
  - **UpdateEndpointWhite**
    - 响应参数变更
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
  - **BatchAddOrRemoveResourceInstance**
    - 请求参数变更
      - `+ resource_type: enum value [endpoint_service,endpoint]`
      - `+ action: enum value [create,delete]`
      - `* body: object<BatchAddOrRemoveResourceInstanceBody> -> object<BatchAddOrRemoveResourceInstanceRequestBody>`
  - **ListQueryProjectResourceTags**
    - 请求参数变更
      - `+ resource_type: enum value [endpoint_service,endpoint]`
  - **BatchAddEndpointServicePermissions**
    - 请求参数变更
      - `* body: object<BatchAddPermissionRequest> -> object<BatchAddEndpointServicePermissionsRequestBody>`
    - 响应参数变更
      - `* permissions.created_at: string -> date-time`
  - **BatchRemoveEndpointServicePermissions**
    - 请求参数变更
      - `* body: object<BatchRemovePermissionRequest> -> object<BatchRemoveEndpointServicePermissionsRequestBody>`
    - 响应参数变更
      - `* permissions.created_at: string -> date-time`
  - **UpdateEndpointServicePermissionDesc**
    - 请求参数变更
      - `* body: object<UpdatePermissionDescRequest> -> object<UpdateEndpointServicePermissionDescRequestBody>`
    - 响应参数变更
      - `* permissions.created_at: string -> date-time`
  - **UpdateEndpointPolicy**
    - 请求参数变更
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
    - 响应参数变更
      - `- enable_dns`
      - `- dns_names`
      - `- subnet_id`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
  - **DeleteEndpointPolicy**
    - 响应参数变更
      - `- enable_dns`
      - `- dns_names`
      - `- subnet_id`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
  - **CreateEndpointService**
    - 请求参数变更
      - `+ service_type: enum value [gateway,interface]`
    - 响应参数变更
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListEndpointService**
    - 响应参数变更
      - `- endpoint_services.status: enum value [creating,available,failed]`
      - `- endpoint_services.service_type: enum value [VM,VIP,LB]`
      - `* endpoint_services.created_at: string -> date-time`
      - `* endpoint_services.updated_at: string -> date-time`
      - `- endpoint_services.tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListServiceConnections**
    - 请求参数变更
      - `+ status: enum value [pendingAcceptance,accepted,rejected,failed]`
    - 响应参数变更
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
  - **AcceptOrRejectEndpoint**
    - 响应参数变更
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
  - **CreateEndpoint**
    - 响应参数变更
      - `- dns_names`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `* policy_statement: list<string> -> list<PolicyStatement>`
  - **ListEndpoints**
    - 请求参数变更
      - `+ sort_key: enum value [create_at,update_at]`
      - `+ sort_dir: enum value [desc,asc]`
    - 响应参数变更
      - `- endpoint_pool_id`
      - `- endpoint_service_id`
      - `- vpc_id`
      - `- created_at`
      - `- description`
      - `- error`
      - `- updated_at`
      - `- enable_whitelist`
      - `- project_id`
      - `- marker_id`
      - `- id`
      - `- public_border_group`
      - `- policy_statement`
      - `- routetables`
      - `- endpoint_service_name`
      - `- ip`
      - `- whitelist`
      - `- tags`
      - `- enable_dns`
      - `- service_type`
      - `- active_status`
      - `- dns_names`
      - `- subnet_id`
      - `- status`
      - `- endpoints.service_type: enum value [interface,gateway]`
      - `- endpoints.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* endpoints.created_at: string -> date-time`
      - `* endpoints.updated_at: string -> date-time`
      - `+ endpoints.policy_statement.Effect: enum value [Allow,Refuse]`
      - `* endpoints: list<EndpointResp> -> list<EndpointResponseBody>`
  - **ListQuotaDetails**
    - 响应参数变更
      - `- quotas.resources.type: enum value [endpoint_service,endpoint]`
      - `* quotas: object<ResourcesResp> -> object<ResourcesResponseBody>`
  - **ListVersionDetails**
    - 响应参数变更
      - `- versions.status: enum value [CURRENT,SUPPORT,DEPRECATED]`
      - `- versions.id: enum value [v1]`
      - `* versions.updated: string -> date-time`
  - **ListSpecifiedVersionDetails**
    - 响应参数变更
      - `- version.status: enum value [CURRENT,SUPPORT,DEPRECATED]`
      - `- version.id: enum value [v1]`
      - `* version.updated: string -> date-time`
  - **ListResourceInstances**
    - 请求参数变更
      - `+ resource_type: enum value [endpoint_service,endpoint]`
      - `+ action: enum value [filter,count]`
  - **UpdateEndpointConnectionsDesc**
    - 请求参数变更
      - `* body: object<UpdateEpConnections> -> object<UpdateEndpointConnectionsDescRequestBody>`
    - 响应参数变更
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`

# 3.1.84 2024-03-07

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListBareMetalServers**
    - 响应参数变更
      - `* servers.OS-SRV-USG:launched_at: date-time -> string`
      - `* servers.OS-SRV-USG:terminated_at: date-time -> string`
  - **ListBareMetalServerDetails**
    - 响应参数变更
      - `* server.OS-SRV-USG:launched_at: date-time -> string`
      - `* server.OS-SRV-USG:terminated_at: date-time -> string`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateSslSwitch**
    - 响应参数变更
      - `+ result`
      - `+ instance_id`
  - **ListClients**
    - 响应参数变更
      - `+ clients.fd`
      - `+ clients.network`
      - `+ clients.peer`
      - `+ clients.user`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`UpdateDatabases`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **AddCertificate**
    - 响应参数变更
      - `+ template_id`
      - `+ provision_enable`
  - **ListCertificates**
    - 响应参数变更
      - `+ template_id`
      - `+ provision_enable`
      - `+ certificates.provision_enable`
      - `+ certificates.template_id`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `CreateDeleteConnectorOrder`
    - `ListSinkTasks`
    - `CreateSinkTask`
    - `ShowSinkTaskDetail`
    - `DeleteSinkTask`
  - **SendKafkaMessage**
    - 请求参数变更
      - `+ property_list.name`
      - `+ property_list.value`
  - **ShowConnectorTask**
    - 响应参数变更
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
      - `* sink_task.target_db: string -> int32`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ ipv6_enable`
  - **CreateConnectorTask**
    - 请求参数变更
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
    - 响应参数变更
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
      - `* sink_task.target_db: string -> int32`
  - **ListConnectorTasks**
    - 响应参数变更
      - `* tasks.source_task.replication_factor: string -> int32`
      - `* tasks.source_task.task_num: string -> int32`
      - `* tasks.sink_task.target_db: string -> int32`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeIdCard**
    - 请求参数变更
      - `+ return_portrait_image`
      - `+ return_adjusted_image`
    - 响应参数变更
      - `+ result.portrait_image`
      - `+ result.adjusted_image`
      - `+ result.front.portrait_image`
      - `+ result.front.adjusted_image`
      - `+ result.back.adjusted_image`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持以下接口：
    - `ShowStorageUsedSpace`
    - `SwitchSqlLimit`
    - `UpdateSqlLimit`
    - `ListSqlLimit`
    - `CreateSqlLimit`
    - `DeleteSqlLimit`
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 响应参数变更
      - `* instances.volume: object<Volume> -> object<VolumeForInstanceResponse>`
  - **CreateRestoreInstance**
    - 请求参数变更
      - `- replica_of_id`
      - `- unchangeable_param`

# 3.1.83 2024-02-29

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAddressSets**
    - 请求参数变更
      - `+ query_address_set_type`
    - 响应参数变更
      - `+ data.records.object_id`
      - `+ data.records.address_set_type`
  - **UpdateAclRuleOrder**
    - 响应参数变更
      - `+ data.name`
  - **AddBlackWhiteList**
    - 响应参数变更
      - `+ data.name`
  - **UpdateBlackWhiteList**
    - 响应参数变更
      - `+ data.name`
  - **DeleteBlackWhiteList**
    - 响应参数变更
      - `+ data.name`
  - **ChangeIpsProtectMode**
    - 响应参数变更
      - `+ data.name`
  - **AddServiceSet**
    - 响应参数变更
      - `+ data.name`
  - **ListServiceSetDetail**
    - 响应参数变更
      - `+ data.service_set_type`
  - **UpdateServiceSet**
    - 响应参数变更
      - `+ data.name`
  - **DeleteServiceSet**
    - 响应参数变更
      - `+ data.name`
  - **DeleteServiceItem**
    - 响应参数变更
      - `+ data.name`
  - **CreateFirewall**
    - 请求参数变更
      - `- flavor.version: enum value [Platinum]`
    - 响应参数变更
      - `- data.flavor.version: enum value [Platinum]`
  - **ChangeEipStatus**
    - 响应参数变更
      - `+ data.id`
  - **DeleteAddressItem**
    - 响应参数变更
      - `+ data.name`
  - **AddAddressSet**
    - 响应参数变更
      - `+ data.name`
  - **ListAddressSetDetail**
    - 请求参数变更
      - `+ query_address_set_type`
    - 响应参数变更
      - `+ data.address_set_type`
  - **UpdateAddressSet**
    - 响应参数变更
      - `* data: object<IdObject> -> object<UpdateAddressSetResponseData>`
  - **DeleteAddressSet**
    - 响应参数变更
      - `+ data.name`
  - **CreateEastWestFirewall**
    - 响应参数变更
      - `+ data.name`
  - **ListEastWestFirewall**
    - 响应参数变更
      - `+ data.protect_infos.status`
  - **AddAclRule**
    - 响应参数变更
      - `+ data.rules.name`
  - **DeleteAclRule**
    - 响应参数变更
      - `+ data.name`
  - **UpdateAclRule**
    - 响应参数变更
      - `+ data.name`
  - **ListAclRules**
    - 响应参数变更
      - `+ data.records.created_date`
      - `+ data.records.last_open_time`
  - **AddServiceItems**
    - 响应参数变更
      - `+ data.items.name`
  - **AddAddressItem**
    - 响应参数变更
      - `+ data.items.name`
  - **ListServiceSets**
    - 响应参数变更
      - `+ data.records.service_set_type`
      - `+ data.records.project_id`
      - `+ data.records.protocols`
  - **ListProtectedVpcs**
    - 响应参数变更
      - `+ data.total_assets`
  - **ListFirewallDetail**
    - 响应参数变更
      - `+ data.records.is_available_obs`
      - `+ data.records.is_support_threat_tags`
  - **ListFirewallList**
    - 响应参数变更
      - `+ is_support_postpaid`
      - `+ is_support_buy_professional`
      - `+ has_ndr`
      - `+ is_support_basic_version`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateFunctionTrigger**
    - 响应参数变更
      - `+ event_data.triggerid`
      - `+ event_data.api_id`
      - `+ event_data.api_name`
      - `+ event_data.invoke_url`
      - `+ event_data.roma_app_id`
      - `+ event_data.db_user`
      - `+ event_data.instance_addrs`
      - `+ event_data.mode`
      - `* event_data: object<TriggerEventDataRequestBody> -> object<TriggerEventDataResponseBody>`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowRule**
    - 响应参数变更
      - `+ actions.smn_forwarding.message_template_name`
  - **UpdateRule**
    - 请求参数变更
      - `+ actions.smn_forwarding.message_template_name`
    - 响应参数变更
      - `+ actions.smn_forwarding.message_template_name`
  - **CreateRule**
    - 请求参数变更
      - `+ actions.smn_forwarding.message_template_name`
    - 响应参数变更
      - `+ actions.smn_forwarding.message_template_name`
  - **ListRules**
    - 响应参数变更
      - `+ rules.actions.smn_forwarding.message_template_name`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持以下接口：
    - `ListConnectorTasks`
    - `CreateConnectorTask`
    - `ShowConnectorTask`
    - `DeleteConnectorTask`
    - `PauseConnectorTask`
    - `ResumeConnectorTask`
    - `RestartConnectorTask`
- _解决问题_
  - 无
- _特性变更_
  - **ShowInstance**
    - 响应参数变更
      - `+ connector_node_num`
  - **CreateSinkTask**
    - 请求参数变更
      - `+ obs_destination_descriptor.partition_format: enum value [yyyy,yyyy/MM,yyyy/MM/dd,yyyy/MM/dd/HH,yyyy/MM/dd/HH/mm]`
  - **ListInstances**
    - 响应参数变更
      - `+ connector_node_num`
      - `+ instances.connector_node_num`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateLogStream**
    - 请求参数变更
      - `+ log_stream_name_alias`
      - `+ enterprise_project_name`

# 3.1.82 2024-02-22

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateDashboardWidgets**
    - 请求参数变更
      - `* body: list<BaseWidgetInfo> -> list<object>`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ModifyGaussMySqlProxyRouteMode**
    - 请求参数变更
      - `+ new_node_auto_add_status`
      - `+ new_node_weight`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListRecycleInstances**
    - 响应参数变更
      - `+ instances.engine_name`
      - `+ instances.volume_size`
      - `+ instances.enterprise_project_name`
      - `+ instances.backup_level`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListImages**
    - 响应参数变更
      - `+ images.__image_displayname`
  - **UpdateImage**
    - 响应参数变更
      - `+ __image_displayname`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeTrainTicket**
    - 响应参数变更
      - `+ result.invoice_style`
      - `+ result.issue_date`
      - `+ result.discount_mark`
      - `+ result.serial_number`
      - `+ result.tax_amount`
      - `+ result.tax_rate`
      - `+ result.air_conditioning`
      - `+ result.original_invoice_number`
      - `+ result.unified_social_credit_code`
      - `+ result.buyer_name`
      - `+ result.total_amount_excluding_tax`
      - `+ result.invoice_number`
      - `+ result.seal_mark`
      - `+ result.title`
      - `+ result.area`
      - `+ result.receipt_number`
      - `+ result.amount_in_figures`
      - `+ result.amount_in_words`

# 3.1.81 2024-02-20

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ListClients`、`ScanClients`、`HangUpClients`、`HangUpKillAllClients`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.80 2024-02-07

### HuaweiCloud SDK GEIP

- _新增特性_
  - 支持全域弹性公网IP服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持以下接口：
    - `ListTenantVpcIgws`
    - `CreateTenantVpcIgw`
    - `ShowInternalVpcIgw`
    - `UpdateTenantVpcIgw`
    - `DeleteTenantVpcIgw`
    - `ListProjectGeipBindings`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`UpdateNewNodeAutoAddSwitch`
- _解决问题_
  - 无
- _特性变更_
  - **CreateGaussMySqlProxy**
    - 请求参数变更
      - `+ new_node_auto_add_status`
      - `+ new_node_weight`
  - **ShowGaussMySqlProxyList**
    - 响应参数变更
      - `+ proxy_list.proxy.new_node_auto_add_status`
      - `+ proxy_list.proxy.new_node_weight`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持接口`StopBackup`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持以下接口：
    - `UpdateDatabaseOwner`
    - `ExecutePrivilegeDatabaseUserRole`
    - `ExecuteRevokeDatabaseUserRole`
    - `ListDatabaseUserRole`
    - `UpdatePostgresqlExtension`
- _解决问题_
  - 无
- _特性变更_
  - **ListPostgresqlExtension**
    - 响应参数变更
      - `+ extensions.version_update`

# 3.1.79 2024-02-01

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEvents**
    - 响应参数变更
      - `* events.annotations: map<string, string> -> map<string, object>`
      - `* events.attach_rule: map<string, string> -> map<string, object>`
  - **PushEvents**
    - 请求参数变更
      - `* events.annotations: map<string, string> -> map<string, object>`
      - `* events.attach_rule: map<string, string> -> map<string, object>`
  - **CreatePromInstance**
    - 请求参数变更
      - `+ region`

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`CreatePrivateProvider`、`CreatePrivateProviderVersion`
- _解决问题_
  - 无
- _特性变更_
  - **GetExecutionPlan**
    - 响应参数变更
      - `+ execution_plan_items.imported`
  - **GetExecutionPlanMetadata**
    - 响应参数变更
      - `+ summary.resource_import`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowLogs`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateGaussMySqlInstance**
    - 请求参数变更
      - `+ tde_info`
  - **ShowGaussMySqlInstanceInfoUnifyStatus**
    - 响应参数变更
      - `+ instance.tde_info`
  - **ListGaussMySqlInstanceDetailInfoUnifyStatus**
    - 响应参数变更
      - `+ instances.tde_info`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`CreateShrinkageJob`、`ShowShrinkCheckResult`、`UpdateSinkTaskQuota`
  - **CreateInstanceTopic**
    - 响应参数变更
      - `- id`

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListNatGatewayDnatRules**
    - 请求参数变更
      - `+ marker`
  - **ListNatGatewaySnatRules**
    - 请求参数变更
      - `+ marker`
  - **ListNatGateways**
    - 请求参数变更
      - `+ marker`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持以下接口：
    - `StartInstanceReduceVolumeAction`
    - `UpdateHostPrivilege`
    - `ShowIncreBackupPolicy1`
    - `UpdateIncreBackupPolicy1`
    - `ListRdSforMySqlProxy`
    - `DeleteRdSforMySqlProxy`
    - `ModifyRdSforMySqlProxyRouteMode`
    - `RestartRdSforMysqlProxy`
    - `ListRdSforMysqlProxyFlavors`
    - `CreateRdSforMySqlProxy`
- _解决问题_
  - 无
- _特性变更_
  - **SetAuditlogPolicy**
    - 请求参数变更
      - `+ audit_types`
  - **CreateDbUser**
    - 请求参数变更
      - `+ is_privilege`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowGroup**
    - 响应参数变更
      - `* retry_max_time: number -> int32`
  - **UpdateConsumerGroup**
    - 请求参数变更
      - `* retry_max_time: number -> int32`
  - **ResetConsumeOffset**
    - 请求参数变更
      - `* timestamp: number -> string`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - 请求参数变更
      - `+ createdAt`
      - `+ permissions`
      - `+ consume_orderly`
      - `- from_beginning`
      - `* retry_max_time: number -> int32`
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `+ groups.createdAt`
      - `+ groups.permissions`
      - `+ groups.consume_orderly`
      - `- groups.from_beginning`
      - `* groups.retry_max_time: number -> int32`
  - **BatchUpdateConsumerGroup**
    - 请求参数变更
      - `+ groups.createdAt`
      - `+ groups.permissions`
      - `+ groups.consume_orderly`
      - `- groups.from_beginning`
      - `* groups.retry_max_time: number -> int32`

# 3.1.78 2024-01-25

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DeleteserviceDiscoveryRules**
    - 响应参数变更
      - `+ id`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateGaussMySqlReadonlyNode**
    - 请求参数变更
      - `+ availability_zones`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeAutoClassification**
    - 请求参数变更
      - `+ detect_seal`
    - 响应参数变更
      - `+ result.seal_mark`
  - **RecognizeVatInvoice**
    - 响应参数变更
      - `+ result.province`
      - `+ result.city`
      - `+ result.belong_buyer_name`
      - `+ result.belong_seller_name`
      - `+ result.belong_vat_code`
      - `+ result.belong_number`
      - `+ result.belong_pages`
      - `+ result.belong_current_page`
      - `+ result.belong_remarks`
      - `+ result.belong_issue_date`
      - `+ result.sales_mark`
      - `+ result.belong_sum_amount`
      - `+ result.belong_sum_tax`
      - `+ result.belong_subtotal_amount`
      - `+ result.belong_subtotal_tax`
      - `+ result.belong_discount_amount`
      - `+ result.belong_discount_tax`
      - `+ result.belong_item_list`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListFlavors**
    - 请求参数变更
      - `+ is_serverless`
  - **ListInstances**
    - 响应参数变更
      - `+ instances.serverless_info`
  - **CreateInstance**
    - 请求参数变更
      - `+ serverless_info`
  - **CreateRestoreInstance**
    - 请求参数变更
      - `+ serverless_info`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateAssetByFileUpload**
    - 请求参数变更
      - `* category_id: string -> int32`
  - **CreateAssetProcessTask**
    - 请求参数变更
      - `+ hls_storage_type`
  - **ListTopStatistics**
    - 响应参数变更
      - `- top_urls.duration_ms`
  - **ListAssetList**
    - 响应参数变更
      - `- assets.duration_ms`
  - **ShowTakeOverAssetDetails**
    - 响应参数变更
      - `- base_info.meta_data.duration_ms`
  - **PublishAssets**
    - 响应参数变更
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **UnpublishAssets**
    - 响应参数变更
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetMeta**
    - 响应参数变更
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetDetail**
    - 响应参数变更
      - `- base_info.meta_data.duration_ms`
  - **ShowTakeOverTaskDetails**
    - 响应参数变更
      - `- assets.base_info.meta_data.duration_ms`

# 3.1.77 2024-01-18

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPromInstance**
    - 请求参数变更
      - `+ prom_status: enum value [DELETED,NORMAL,ALL]`
      - `+ prom_status: enum value [true,false]`
    - 响应参数变更
      - `- prometheus.cce_spec`
      - `- prometheus.prom_config`
      - `- prometheus.application`
      - `+ prometheus.prom_status: enum value [DELETED,NORMAL,ALL]`
  - **CreatePromInstance**
    - 请求参数变更
      - `- prom_id`
      - `- cce_spec`
      - `- prom_config`
      - `- prom_create_timestamp`
      - `- prom_update_timestamp`
      - `- prom_status`
      - `- is_deleted_tag`
      - `- deleted_time`
      - `- prom_spec_config`
      - `- cce_spec_config`
      - `- application`
      - `- prom_type: enum value [DEFAULT]`
      - `* body: object<PromInstanceEpsModel> -> object<PromInstanceRequestModel>`
    - 响应参数变更
      - `- prometheus.cce_spec`
      - `- prometheus.prom_config`
      - `- prometheus.is_deleted_tag`
      - `- prometheus.application`
      - `- prometheus.prom_type: enum value [DEFAULT]`
      - `+ prometheus.prom_status: enum value [DELETED,NORMAL,ALL]`
      - `* prometheus: list<PromInstanceEpsModel> -> list<PromInstanceEpsCreateModel>`
  - **AddOrUpdateServiceDiscoveryRules**
    - 响应参数变更
      - `+ id`
      - `+ results`

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowCluster**
    - 响应参数变更
      - `+ spec.enableAutopilot`
  - **UpdateCluster**
    - 响应参数变更
      - `+ spec.enableAutopilot`
  - **DeleteCluster**
    - 响应参数变更
      - `+ spec.enableAutopilot`
  - **CreateCluster**
    - 请求参数变更
      - `+ spec.enableAutopilot`
    - 响应参数变更
      - `+ spec.enableAutopilot`
  - **ListClusters**
    - 响应参数变更
      - `+ items.spec.enableAutopilot`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowTopUrl**
    - 请求参数变更
      - `+ service_area: enum value [global]`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ListCdnDomainTopRefers`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ChangeMasterStandbyAsync`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateListener**
    - 请求参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
  - **ListLoadbalancers**
    - 响应参数变更
      - `+ loadbalancers.billing_info`
      - `+ loadbalancers.protection_status`
      - `+ loadbalancers.protection_reason`
  - **CreateLoadbalancer**
    - 响应参数变更
      - `+ loadbalancer_id`
      - `+ order_id`
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ShowLoadbalancer**
    - 响应参数变更
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **UpdateLoadbalancer**
    - 响应参数变更
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeSeal`
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeFlightItinerary**
    - 响应参数变更
      - `+ result.tax`
      - `+ result.tax_rate`
      - `+ result.buyer_name`
      - `+ result.buyer_id`
      - `+ result.number`
      - `+ result.international_flag`
      - `+ result.issue_status`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAuditlogPolicy**
    - 响应参数变更
      - `+ all_audit_log_action`
      - `+ audit_types`
  - **ListRecycleInstances**
    - 响应参数变更
      - `+ instances.is_serverless`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ValidateConsumedMessage**
    - 请求参数变更
      - `+ topic`

# 3.1.76 2024-01-11

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateNodePool**
    - 响应参数变更
      - `- status.jobId`
      - `* status: object<NodePoolStatus> -> object<UpdateNodePoolStatus>`
  - **CreateNodePool**
    - 响应参数变更
      - `- status.jobId`
      - `* status: object<NodePoolStatus> -> object<CreateNodePoolStatus>`

### HuaweiCloud SDK DRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchValidateConnections**
    - 请求参数变更
      - `+ jobs.customized_dns`

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持以下接口：
    - `BatchCreateTags`
    - `BatchDeleteTags`
    - `ListInstanceByTags`
    - `CountInstanceByTags`
    - `ListInstanceTags`
    - `ListTags`
    - `UpdateJobConfigurations`
    - `ListJobParameters`
    - `ListJobHistoryParameters`
- _解决问题_
  - 无
- _特性变更_
  - **ListLinks**
    - 响应参数变更
      - `+ job_links.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
  - **ListJobs**
    - 请求参数变更
      - `+ engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
    - 响应参数变更
      - `+ jobs.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.children.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
  - **CreateJob**
    - 请求参数变更
      - `+ job.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.source_endpoint.customized_dns`
      - `+ job.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.source_endpoint.config.node_num`
  - **BatchCreateJobsAsync**
    - 请求参数变更
      - `+ jobs.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.source_endpoint.customized_dns`
      - `+ jobs.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.source_endpoint.config.node_num`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.source_endpoint.customized_dns`
      - `+ jobs.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.source_endpoint.config.node_num`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.params.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.params.source_endpoint.customized_dns`
      - `+ jobs.params.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.params.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.params.source_endpoint.config.node_num`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.source_endpoint.customized_dns`
      - `+ job.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.source_endpoint.config.node_num`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.params.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.params.source_endpoint.customized_dns`
      - `+ job.params.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.params.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.params.source_endpoint.config.node_num`
  - **ExecuteJobAction**
    - 请求参数变更
      - `+ job.action_name: enum value [column_limit,reload_parameters]`
      - `+ job.action_params.endpoints.customized_dns`
      - `+ job.action_params.endpoints.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.action_params.endpoints.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.action_params.endpoints.config.node_num`
  - **BatchExecuteJobActions**
    - 请求参数变更
      - `+ jobs.action_name: enum value [column_limit,reload_parameters]`
      - `+ jobs.action_params.endpoints.customized_dns`
      - `+ jobs.action_params.endpoints.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.action_params.endpoints.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.action_params.endpoints.config.node_num`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`NovaShowServerInterface`
- _解决问题_
  - 无
- _特性变更_
  - **UpdateServer**
    - 响应参数变更
      - `+ server.OS-EXT-SRV-ATTR:user_data`

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowCertificate**
    - 响应参数变更
      - `+ tenant_id`
      - `+ create_time`
      - `+ certificate`
      - `+ description`
      - `+ expire_time`
      - `+ private_key`
      - `+ type`
      - `+ update_time`
      - `+ admin_state_up`
      - `+ domain`
      - `+ name`
      - `+ id`
  - **UpdateCertificate**
    - 响应参数变更
      - `+ tenant_id`
      - `+ create_time`
      - `+ certificate`
      - `+ description`
      - `+ expire_time`
      - `+ private_key`
      - `+ type`
      - `+ update_time`
      - `+ admin_state_up`
      - `+ domain`
      - `+ name`
      - `+ id`
  - **CreateCertificate**
    - 响应参数变更
      - `+ tenant_id`
      - `+ create_time`
      - `+ certificate`
      - `+ description`
      - `+ expire_time`
      - `+ private_key`
      - `+ type`
      - `+ update_time`
      - `+ admin_state_up`
      - `+ domain`
      - `+ name`
      - `+ id`
  - **ListHealthmonitors**
    - 响应参数变更
      - `+ healthmonitors`
  - **CreateHealthmonitor**
    - 响应参数变更
      - `+ healthmonitor`
  - **ShowHealthmonitors**
    - 响应参数变更
      - `+ healthmonitor`
  - **UpdateHealthmonitor**
    - 响应参数变更
      - `+ healthmonitor`
  - **ListMembers**
    - 响应参数变更
      - `+ members`
  - **CreateMember**
    - 响应参数变更
      - `+ member`
  - **ShowMember**
    - 响应参数变更
      - `+ member`
  - **UpdateMember**
    - 响应参数变更
      - `+ member`
  - **ShowLoadbalancer**
    - 响应参数变更
      - `+ loadbalancer`
  - **UpdateLoadbalancer**
    - 请求参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - 响应参数变更
      - `+ loadbalancer`
  - **ListL7rules**
    - 响应参数变更
      - `+ rules`
  - **CreateL7rule**
    - 响应参数变更
      - `+ rule`
  - **ShowL7rule**
    - 响应参数变更
      - `+ rule`
  - **UpdateL7rule**
    - 响应参数变更
      - `+ rule`
  - **ListPools**
    - 响应参数变更
      - `+ pools`
  - **CreatePool**
    - 请求参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - 响应参数变更
      - `+ pool`
  - **ShowPool**
    - 响应参数变更
      - `+ pool`
  - **UpdatePool**
    - 请求参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - 响应参数变更
      - `+ pool`
  - **ListListeners**
    - 响应参数变更
      - `+ listeners`
  - **CreateListener**
    - 响应参数变更
      - `+ listener`
  - **ShowListener**
    - 响应参数变更
      - `+ listener`
  - **UpdateListener**
    - 请求参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
    - 响应参数变更
      - `+ listener`
  - **CreateLoadbalancer**
    - 请求参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - 响应参数变更
      - `+ loadbalancer`
  - **ListLoadbalancers**
    - 响应参数变更
      - `+ loadbalancers.publicips`
      - `+ loadbalancers.charge_mode`
      - `+ loadbalancers.frozen_scene`
  - **ListL7policies**
    - 响应参数变更
      - `+ l7policies`
  - **CreateL7policy**
    - 响应参数变更
      - `+ l7policy`
  - **UpdateL7policies**
    - 响应参数变更
      - `+ l7policy`

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPools**
    - 请求参数变更
      - `+ connection_drain`
    - 响应参数变更
      - `+ pools.connection_drain`
  - **CreatePool**
    - 请求参数变更
      - `+ pool.connection_drain`
    - 响应参数变更
      - `+ pool.connection_drain`
  - **ShowPool**
    - 响应参数变更
      - `+ pool.connection_drain`
  - **UpdatePool**
    - 请求参数变更
      - `+ pool.connection_drain`
    - 响应参数变更
      - `+ pool.connection_drain`
  - **ListMasterSlavePools**
    - 请求参数变更
      - `+ connection_drain`
    - 响应参数变更
      - `+ pools.connection_drain`
  - **CreateMasterSlavePool**
    - 请求参数变更
      - `+ pool.connection_drain`
    - 响应参数变更
      - `+ pool.connection_drain`
  - **ShowMasterSlavePool**
    - 响应参数变更
      - `+ pool.connection_drain`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateReassignmentTask**
    - 请求参数变更
      - `+ is_schedule`
      - `+ execute_at`

### HuaweiCloud SDK MPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListTranscodingTask**
    - 响应参数变更
      - `+ task_array.progress`
  - **ListTranscodeDetail**
    - 响应参数变更
      - `+ task_array.progress`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeIdCard**
    - 请求参数变更
      - `+ detect_tampering`
      - `+ detect_border_integrity`
      - `+ detect_blocking_within_border`
      - `+ detect_blur`
      - `+ detect_interim`
      - `+ detect_glare`
    - 响应参数变更
      - `+ result.detect_tampering_result`
      - `+ result.detect_border_integrity_result`
      - `+ result.detect_blocking_within_border_result`
      - `+ result.detect_blur_result`
      - `+ result.detect_interim_result`
      - `+ result.detect_glare_result`
      - `+ result.score_info`
      - `+ result.front`
      - `+ result.back`
      - `+ result.verification_result.valid_validity_period`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 请求参数变更
      - `+ eps_id`
  - **BatchRestoreDatabase**
    - 请求参数变更
      - `+ instances.is_fast_restore`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddressGroup**
    - 响应参数变更
      - `+ address_group.ip_extra_set`
  - **UpdateAddressGroup**
    - 请求参数变更
      - `+ address_group.ip_extra_set`
    - 响应参数变更
      - `+ address_group.ip_extra_set`
  - **ListAddressGroup**
    - 响应参数变更
      - `+ address_groups.ip_extra_set`
  - **CreateAddressGroup**
    - 请求参数变更
      - `+ address_group.ip_extra_set`
    - 响应参数变更
      - `+ address_group.ip_extra_set`

# 3.1.75 2024-01-04

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListNotifiedHistories**
    - 响应参数变更
      - `+ notified_histories`
      - `- event_sn`
      - `- notifications`
  - **ListEvent2alarmRule**
    - 响应参数变更
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* : list<event2alarmRuleBody> -> list<Event2alarmRuleBody>`
  - **UpdateEventRule**
    - 请求参数变更
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* body: object<event2alarmRuleBody> -> object<Event2alarmRuleBody>`
  - **AddEvent2alarmRule**
    - 请求参数变更
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* body: object<event2alarmRuleBody> -> object<Event2alarmRuleBody>`
  - **ListMuteRule**
    - 响应参数变更
      - `* mute_config.scope: list<string> -> list<integer>`
  - **UpdateMuteRule**
    - 请求参数变更
      - `* mute_config.scope: list<string> -> list<integer>`
  - **AddMuteRules**
    - 请求参数变更
      - `* mute_config.scope: list<string> -> list<integer>`
  - **ShowActionRule**
    - 响应参数变更
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **ListEvents**
    - 响应参数变更
      - `* events.metadata: object -> map<string, string>`
      - `* events.annotations: object -> map<string, string>`
      - `* events.attach_rule: object -> map<string, string>`
  - **PushEvents**
    - 请求参数变更
      - `* events.metadata: object -> map<string, string>`
      - `* events.annotations: object -> map<string, string>`
      - `* events.attach_rule: object -> map<string, string>`
  - **UpdateActionRule**
    - 请求参数变更
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **AddActionRule**
    - 请求参数变更
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **ListActionRule**
    - 响应参数变更
      - `+ action_rules.type: enum value [1,2]`
      - `- action_rules.type: enum value ["1","2"]`
  - **ListMetricItems**
    - 响应参数变更
      - `+ metaData.offset`
      - `+ metaData.nextToken`
      - `- metaData.start`
      - `* metaData: object<metaData> -> object<MetaDataSeries>`
  - **UpdateAlarmRule**
    - 请求参数变更
      - `+ is_turn_on`
      - `- id_turn_on`
      - `+ comparison_operator: enum value [<,>,<=,>=]`
      - `+ period: enum value [60000,300000,900000,36000000]`
  - **AddAlarmRule**
    - 请求参数变更
      - `+ is_turn_on`
      - `- id_turn_on`
      - `+ comparison_operator: enum value [<,>,<=,>=]`
      - `+ period: enum value [60000,300000,900000,36000000]`
  - **ListServiceDiscoveryRules**
    - 响应参数变更
      - `+ id`
      - `+ appRules.desc`
      - `+ appRules.spec.dataSource`
      - `+ appRules.spec.editable`
      - `+ appRules.spec.aom_metric_relabel_configs`
  - **AddOrUpdateServiceDiscoveryRules**
    - 请求参数变更
      - `+ appRules.desc`
      - `+ appRules.spec.dataSource`
      - `+ appRules.spec.editable`
      - `+ appRules.spec.aom_metric_relabel_configs`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateAccessCode**
    - 请求参数变更
      - `+ force_disconnect`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`ResetMessageOffsetWithEngine`
- _解决问题_
  - 无
- _特性变更_
  - **ShowGroups**
    - 响应参数变更
      - `* group.group_message_offsets.message_current_offset: int32 -> int64`
      - `* group.group_message_offsets.message_log_end_offset: int32 -> int64`
  - **ResetMessageOffset**
    - 请求参数变更
      - `* message_offset: int32 -> int64`
      - `* timestamp: int32 -> int64`
  - **ShowMessages**
    - 响应参数变更
      - `* messages.message_offset: int32 -> int64`
  - **ShowInstanceMessages**
    - 响应参数变更
      - `* messages.message_offset: int32 -> int64`

### HuaweiCloud SDK MPC

- _新增特性_
  - 支持接口`ShowTenantAccessInfo`、`UpdateTenantAccessInfo`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchRestartOrDeleteInstances**
    - 请求参数变更
      - `- action: enum value [restart]`
  - **ListInstancesDetails**
    - 请求参数变更
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **SetOffSiteBackupPolicy**
    - 请求参数变更
      - `* policy_para: list<OffSiteBackupPolicy> -> object<OffSiteBackupPolicy>`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ResizeInstance**
    - 请求参数变更
      - `+ publicip_id`

### HuaweiCloud SDK SMN

- _新增特性_
  - 支持以下接口：
    - `PublishHttpDetect`
    - `ShowHttpDetectResult`
    - `BatchUpdateSubscriptionsFilterPolices`
    - `BatchCreateSubscriptionsFilterPolices`
    - `BatchDeleteSubscriptionsFilterPolices`
    - `AddSubscriptionFromSubscriptionUser`
- _解决问题_
  - 无
- _特性变更_
  - 废弃以下接口：
    - `ListApplicationAttributes`
    - `UpdateApplication`
    - `DeleteApplication`
    - `ListApplicationEndpointAttributes`
    - `UpdateApplicationEndpoint`
    - `DeleteApplicationEndpoint`
    - `PublishAppMessage`
    - `CreateApplication`
    - `ListApplications`
    - `CreateApplicationEndpoint`
    - `ListApplicationEndpoints`
  - **PublishMessage**
    - 请求参数变更
      - `+ message_attributes`
  - **ListTopics**
    - 请求参数变更
      - `+ fuzzy_display_name`
  - **ListSubscriptions**
    - 请求参数变更
      - `+ fuzzy_remark`
    - 响应参数变更
      - `+ subscriptions.filter_polices`
  - **ListSubscriptionsByTopic**
    - 请求参数变更
      - `+ fuzzy_remark`
    - 响应参数变更
      - `+ subscriptions.filter_polices`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPorts**
    - 响应参数变更
      - `+ ports.ipv6_bandwidth_id`
  - **CreatePort**
    - 响应参数变更
      - `+ port.ipv6_bandwidth_id`
  - **ShowPort**
    - 响应参数变更
      - `+ port.ipv6_bandwidth_id`
  - **UpdatePort**
    - 响应参数变更
      - `+ port.ipv6_bandwidth_id`

