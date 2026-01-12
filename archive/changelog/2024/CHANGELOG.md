# 3.1.127 2024-12-26

### HuaweiCloud SDK CBR

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListVault**
    - changes of response param
      - `+ vaults.billing.object_type: enum value [turbo]`
      - `+ vaults.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **CreateVault**
    - changes of response param
      - `+ vault.billing.object_type: enum value [turbo]`
      - `+ vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ShowVault**
    - changes of response param
      - `+ vault.billing.object_type: enum value [turbo]`
      - `+ vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **UpdateVault**
    - changes of response param
      - `+ vault.billing.object_type: enum value [turbo]`
      - `+ vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ListExternalVault**
    - changes of response param
      - `+ vaults.billing.object_type: enum value [turbo]`
      - `+ vaults.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ListProtectable**
    - changes of response param
      - `+ instances.protectable.vault.billing.object_type: enum value [turbo]`
      - `+ instances.protectable.vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ShowProtectable**
    - changes of response param
      - `+ instance.protectable.vault.billing.object_type: enum value [turbo]`
      - `+ instance.protectable.vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`
  - **ShowVaultResourceInstances**
    - changes of request param
      - `+ object_type: enum value [turbo,workspace,vmware,rds,file]`
    - changes of response param
      - `+ resources.resource_detail.vault.billing.object_type: enum value [turbo]`
      - `+ resources.resource_detail.vault.billing.spec_code: enum value [vault.backup.turbo.normal,vault.backup.database.normal,vault.hybrid.server.normal,vault.replication.server.normal]`

### HuaweiCloud SDK CFW

- _API Version_
  - V1
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AllowDbRolePrivileges**
    - changes of request param
      - `+ user.name`
      - `+ user.schema`
      - `+ user.readonly`
      - `+ user.default_privilege_grantee`
      - `* user: object -> object<GaussDBforOpenGaussRoleAttributes>`
  - **ListDatabaseRoles**
    - changes of response param
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

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateImage**
    - changes of request param
      - `+ hw_firmware_type`
  - **ImportImageQuick**
    - changes of request param
      - `+ hw_firmware_type`

### HuaweiCloud SDK LTS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListLogStreams**
    - changes of request param
      - `- offset`
      - `- limit`
  - **CreateLogGroup**
    - changes of request param
      - `+ log_group_name_alias`
  - **UpdateLogStream**
    - changes of request param
      - `- ttl_in_days: enum value [7]`
  - **UpdateTransfer**
    - changes of request param
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
    - changes of response param
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
  - **CreateTransfer**
    - changes of request param
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
    - changes of response param
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
  - **DeleteTransfer**
    - changes of response param
      - `+ log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfer_info.log_transfer_detail.invalid_field_value`
  - **ListTransfers**
    - changes of response param
      - `+ log_transfers.log_transfer_info.log_transfer_detail.lts_tags`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.stream_tags`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.struct_fields`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.invalid_field_value`
  - **UpdateAccessConfig**
    - changes of request param
      - `+ access_config_name`

### HuaweiCloud SDK RDS

- _API Version_
  - V3
- _Features_
  - Support the API `ListDrInfos`
- _Bug Fix_
  - None
- _Change_
  - **ListUpdateBackupEnhancePolicy**
    - changes of response param
      - `* policies.retention_days: string -> int32`

### HuaweiCloud SDK VPCEP

- _API Version_
  - V1
- _Features_
  - Support the API `UpgradeEndpointService`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.126 2024-12-19

### HuaweiCloud SDK AAD

- _API Version_
  - V2
- _Features_
  - Support the APIs `AddWafWhiteIpRule`, `DeleteWafWhiteIpRule`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK AS

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListScalingActivityLogs**
    - changes of response param
      - `+ scaling_activity_log.status: enum value [DOING]`
      - `- scaling_activity_log.status: enum value [DING]`
  - **ListScalingActivityV2Logs**
    - changes of response param
      - `+ scaling_activity_log.status: enum value [DOING]`
      - `- scaling_activity_log.status: enum value [DING]`

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **UpdateAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **RollbackAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **ShowAutopilotAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **UpdateAutopilotAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **RollbackAutopilotAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **CreateAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **ListAddonInstances**
    - changes of response param
      - `+ items.status.currentVersion.supportVersions.category`
  - **ListAddonTemplates**
    - changes of response param
      - `+ items.spec.versions.supportVersions.category`
  - **CreateAutopilotAddonInstance**
    - changes of response param
      - `+ status.currentVersion.supportVersions.category`
  - **ListAutopilotAddonInstances**
    - changes of response param
      - `+ items.status.currentVersion.supportVersions.category`
  - **ListAutopilotAddonTemplates**
    - changes of response param
      - `+ items.spec.versions.supportVersions.category`

### HuaweiCloud SDK DCS

- _API Version_
  - V2
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EVS

- _API Version_
  - V2
- _Features_
  - Support the API `UnsubscribePostpaidVolume`
- _Bug Fix_
  - None
- _Change_
  - **CinderListQuotas**
    - changes of response param
      - `+ quota_set.gigabytes_ESSD`
      - `+ quota_set.snapshots_ESSD`
      - `+ quota_set.volumes_ESSD`

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **ShowUpgradeCandidateVersions**
    - changes of response param
      - `* hotfix_upgrade_infos: object<HotfixUpgradeInfos> -> list<HotfixUpgradeInfos>`
      - `* hotfix_rollback_infos: object<HotfixRollbackInfos> -> list<HotfixRollbackInfos>`

### HuaweiCloud SDK IMS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ImportImageQuick**
    - changes of request param
      - `+ license_type`

### HuaweiCloud SDK OCR

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeAutoClassification**
    - changes of request param
      - `+ pdf_page_number`
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ erase_seal`

### HuaweiCloud SDK RDS

- _API Version_
  - V3
- _Features_
  - Support the API `ListUpdateBackupEnhancePolicy`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.125 2024-12-12

### HuaweiCloud SDK AOS

- _API Version_
  - V1
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the API `SyncNodePool`

### HuaweiCloud SDK CDN

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.cache_rules.force_cache`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.cache_rules.force_cache`

### HuaweiCloud SDK CSMS

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListUsers**
    - changes of request param
      - `+ user_info`
      - `- user_name`

### HuaweiCloud SDK DDS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ResizeInstance**
    - changes of request param
      - `+ resize.target_ids`

### HuaweiCloud SDK GaussDB

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateStarrocksInstance**
    - changes of request param
      - `+ pay_info`
      - `+ region_code`

### HuaweiCloud SDK LTS

- _API Version_
  - V2
- _Features_
  - Support the API `ListLogContext`
- _Bug Fix_
  - None
- _Change_
  - **CreateLogStreamIndex**
    - changes of request param
      - `+ fields.ltsSubFieldsInfoList`
      - `+ fields.fieldType: enum value [json]`
  - **ListAccessConfig**
    - changes of response param
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
    - changes of request param
      - `+ access_config_detail.system_fields`
      - `+ access_config_detail.custom_key_value`
      - `+ access_config_detail.includeLabelsLogical`
      - `+ access_config_detail.excludeLabelsLogical`
      - `+ access_config_detail.includeK8sLabelsLogical`
      - `+ access_config_detail.excludeK8sLabelsLogical`
      - `+ access_config_detail.includeEnvsLogical`
      - `+ access_config_detail.excludeEnvsLogical`
    - changes of response param
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
    - changes of request param
      - `+ access_config_detail.repeat_collect`
      - `+ access_config_detail.system_fields`
      - `+ access_config_detail.custom_key_value`
      - `+ access_config_detail.includeLabelsLogical`
      - `+ access_config_detail.excludeLabelsLogical`
      - `+ access_config_detail.includeK8sLabelsLogical`
      - `+ access_config_detail.excludeK8sLabelsLogical`
      - `+ access_config_detail.includeEnvsLogical`
      - `+ access_config_detail.excludeEnvsLogical`
    - changes of response param
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
    - changes of response param
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

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpgradeNodePool**
    - changes of response param
      - `+ jobid`
      - `- metadata`
      - `- apiVersion`
      - `- kind`
      - `- spec`
      - `- status`

### HuaweiCloud SDK CSMS

- _API Version_
  - V1
- _Features_
  - Support the following APIs:
    - `ListUsers`
    - `ListGrants`
    - `UpdateGrant`
    - `CreateGrants`
    - `DeleteGrant`
    - `GenerateRandomPassword`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DBSS

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListRdsDatabases**
    - changes of request param
      - `+ db_type: enum value [ORACLE,DAMENG,KINGBASE]`
  - **SwitchAuditDatabase**
    - changes of response param
      - `+ status`
      - `- result`

### HuaweiCloud SDK IMS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of response param
      - `+ images.__support_kvm_hi1822_hisriov`
      - `+ images.__support_kvm_hi1822_hivirtionet`
  - **UpdateImage**
    - changes of response param
      - `+ __support_kvm_hi1822_hisriov`
      - `+ __support_kvm_hi1822_hivirtionet`

### HuaweiCloud SDK SWR

- _API Version_
  - V2
- _Features_
  - Support the APIs `ShowShareFeatureGates`, `ShowDomainResourceReports`, `ShowDomainOverview`, `CreateRepoTag`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.123 2024-12-05

### HuaweiCloud SDK AOS

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **EstimateExecutionPlanPrice**
    - changes of response param
      - `+ items.resource_price.best_discount_type`
      - `+ items.resource_price.best_discount_price`
      - `+ items.resource_price.official_website_discount_price`

### HuaweiCloud SDK CES

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAlarmHistories**
    - changes of request param
      - `+ record_id`

### HuaweiCloud SDK CTS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTraces**
    - changes of response param
      - `+ traces.read_only`
      - `+ traces.operation_id`

### HuaweiCloud SDK DDS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowInstanceConfigurationModifyHistory**
    - changes of request param
      - `+ entity_id`

### HuaweiCloud SDK DRS

- _API Version_
  - V5
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.compare_result.data_compare_task_list.dynamic_compare_delay`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.compare_result.data_compare_task_list.dynamic_compare_delay`

### HuaweiCloud SDK FunctionGraph

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAsyncInvocations**
    - changes of response param
      - `* invocations.end_time: date-time -> string`
  - **ListActiveAsyncInvocations**
    - changes of response param
      - `* invocations.end_time: date-time -> string`

### HuaweiCloud SDK GaussDBforNoSQL

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IAM

- _API Version_
  - V3
- _Features_
  - Support the API `KeystoneListFederationProjects`
- _Bug Fix_
  - None
- _Change_
  - **KeystoneListUsersForGroupByAdmin**
    - changes of response param
      - `- users.extra`
  - **UpdateUser**
    - changes of request param
      - `- user.create_time`
      - `- user.xdomain_id`
      - `- user.xdomain_type`
      - `- user.is_domain_owner`
    - changes of response param
      - `+ user.create_time`
      - `+ user.xdomain_id`
      - `+ user.xdomain_type`
      - `+ user.is_domain_owner`
  - **KeystoneUpdateUserByAdmin**
    - changes of response param
      - `- user.extra`
  - **CreateUnscopedTokenWithIdToken**
    - changes of response param
      - `* token.catalog: object -> list<object>`

# 3.1.122 2024-11-28

### HuaweiCloud SDK CBR

- _API Version_
  - V1
- _Features_
  - Support the API `ChangeOrder`
- _Bug Fix_
  - None
- _Change_
  - **AddAgentPath**
    - changes of request param
      - `+ exclude_path`
  - **AddMember**
    - changes of request param
      - `+ domains`
  - **ShowAgent**
    - changes of response param
      - `+ agent.paths.exclude_paths`
  - **UpdateAgent**
    - changes of response param
      - `+ agent.paths.exclude_paths`
  - **ListAgent**
    - changes of response param
      - `+ agents.paths.exclude_paths`
  - **RegisterAgent**
    - changes of response param
      - `+ agent.paths.exclude_paths`
  - **ShowBackup**
    - changes of response param
      - `+ backup.version`
      - `- backup.image_type: enum value [backup,replication]`
      - `- backup.resource_type: enum value [OS::Nova::Server,OS::Cinder::Volume,OS::Workspace::DesktopV2]`
  - **UpdateBackup**
    - changes of response param
      - `+ backup.version`
      - `- backup.image_type: enum value [backup,replication]`
      - `- backup.resource_type: enum value [OS::Nova::Server,OS::Cinder::Volume,OS::Workspace::DesktopV2]`
  - **ListBackups**
    - changes of response param
      - `+ backups.version`
      - `- backups.image_type: enum value [backup,replication]`
      - `- backups.resource_type: enum value [OS::Nova::Server,OS::Cinder::Volume,OS::Workspace::DesktopV2]`
  - **ListOrganizationPolicies**
    - changes of request param
      - `+ limit`
      - `+ offset`
  - **ListProtectable**
    - changes of request param
      - `+ protectable_type: enum value [turbo,workspace,workspace_v2]`

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCluster**
    - changes of response param
      - `+ spec.encryptionConfig`
  - **UpdateCluster**
    - changes of response param
      - `+ spec.encryptionConfig`
  - **DeleteCluster**
    - changes of response param
      - `+ spec.encryptionConfig`
  - **ShowAutopilotCluster**
    - changes of response param
      - `- spec.deletionProtection`
  - **UpdateAutopilotCluster**
    - changes of response param
      - `- spec.deletionProtection`
  - **DeleteAutopilotCluster**
    - changes of response param
      - `- spec.deletionProtection`
  - **CreateCluster**
    - changes of request param
      - `+ spec.encryptionConfig`
    - changes of response param
      - `+ spec.encryptionConfig`
  - **ListClusters**
    - changes of response param
      - `+ items.spec.encryptionConfig`
  - **CreateAutopilotCluster**
    - changes of request param
      - `- spec.deletionProtection`
    - changes of response param
      - `- spec.deletionProtection`
  - **ListAutopilotClusters**
    - changes of response param
      - `- items.spec.deletionProtection`
  - **ShowNode**
    - changes of response param
      - `+ spec.extendParam.securityReinforcementType`
  - **UpdateNode**
    - changes of response param
      - `+ spec.extendParam.securityReinforcementType`
  - **DeleteNode**
    - changes of response param
      - `+ spec.extendParam.securityReinforcementType`
  - **CreateNode**
    - changes of request param
      - `+ spec.extendParam.securityReinforcementType`
    - changes of response param
      - `+ spec.extendParam.securityReinforcementType`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.extendParam.securityReinforcementType`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **UpdateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.securityReinforcementType`
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **AddNode**
    - changes of request param
      - `+ nodeList.spec.securityReinforcementType`
  - **ResetNode**
    - changes of request param
      - `+ nodeList.spec.securityReinforcementType`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.securityReinforcementType`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.extendParam.securityReinforcementType`

### HuaweiCloud SDK CSMS

- _API Version_
  - V1
- _Features_
  - Support the APIs `ListSecretTask`, `ShowAgency`, `CreateAgency`, `ShowSecretFunctionTemplates`
- _Bug Fix_
  - None
- _Change_
  - **RotateSecret**
    - changes of response param
      - `+ rotation_task_id`
  - **ListSecrets**
    - changes of response param
      - `+ secrets.rotation_func_urn`
      - `+ secrets.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **CreateSecret**
    - changes of request param
      - `+ rotation_func_urn`
      - `+ secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
    - changes of response param
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **ShowSecret**
    - changes of response param
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **UpdateSecret**
    - changes of request param
      - `+ rotation_func_urn`
    - changes of response param
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **UploadSecretBlob**
    - changes of response param
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **DeleteSecretForSchedule**
    - changes of response param
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **RestoreSecret**
    - changes of response param
      - `+ secret.rotation_func_urn`
      - `+ secret.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **ListNotificationRecords**
    - changes of request param
      - `- limit`
      - `- marker`
    - changes of response param
      - `+ records.trigger_event_type: enum value [SECRET_VERSION_CREATED,SECRET_VERSION_EXPIRED,SECRET_ROTATED,SECRET_DELETED,SECRET_ROTATED_FAILED]`
      - `+ records.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
      - `+ records.notification_status: enum value [SUCCESS,FAIL,INVALID]`
  - **ListResourceInstances**
    - changes of response param
      - `+ resources.resource_detail.rotation_func_urn`
      - `+ resources.resource_detail.secret_type: enum value [COMMON,RDS-FG,GaussDB-FG]`
  - **ListSecretEvents**
    - changes of response param
      - `+ events.event_types: enum value [SECRET_ROTATED_FAILED]`
  - **CreateSecretEvent**
    - changes of request param
      - `+ event_types: enum value [SECRET_VERSION_CREATED,SECRET_VERSION_EXPIRED,SECRET_ROTATED,SECRET_DELETED,SECRET_ROTATED_FAILED]`
    - changes of response param
      - `+ event.event_types: enum value [SECRET_ROTATED_FAILED]`
  - **ShowSecretEvent**
    - changes of response param
      - `+ event.event_types: enum value [SECRET_ROTATED_FAILED]`
  - **UpdateSecretEvent**
    - changes of request param
      - `+ event_types: enum value [SECRET_VERSION_CREATED,SECRET_VERSION_EXPIRED,SECRET_ROTATED,SECRET_DELETED,SECRET_ROTATED_FAILED]`
    - changes of response param
      - `+ event.event_types: enum value [SECRET_ROTATED_FAILED]`

### HuaweiCloud SDK GaussDB

- _API Version_
  - V3
- _Features_
  - Support the APIs `ShowSlowLogStatistics`, `DownloadSlowLogFile`, `ShowMultiTenant`, `UpdateMultiTenant`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
    - `ShowRedisPitrPolicy`
    - `SetRedisPitrPolicy`
    - `ListRedisPitrRestoreTime`
    - `ShowRedisPitrInfo`
    - `RestoreRedisPitr`
    - `StopBackup`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK KMS

- _API Version_
  - V2
- _Features_
  - Support the APIs `AssociateAlias`, `ListAliases`, `CreateAlias`, `DeleteAlias`
- _Bug Fix_
  - None
- _Change_
  - **ListSupportRegions**
    - changes of request param
      - `+ limit`
      - `+ offset`

### HuaweiCloud SDK KPS

- _API Version_
  - V3
- _Features_
  - Support the APIs `BatchImportKeypair`, `BatchExportPrivateKey`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Live

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSingleStreamDetail**
    - changes of response param
      - `- audio_framerate`

### HuaweiCloud SDK OCR

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeGeneralText**
    - changes of request param
      - `+ pdf_page_number`

### HuaweiCloud SDK RDS

- _API Version_
  - V3
- _Features_
  - Support the APIs `CopyDatabase`, `DeleteMsdtcLocalHost`
- _Bug Fix_
  - None
- _Change_
  - **ListFlavorsResize**
    - changes of response param
      - `* flavor_groups.compute_flavors: object<ComputeFlavor> -> list<ComputeFlavor>`

### HuaweiCloud SDK VOD

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTopStatistics**
    - changes of response param
      - `+ top_urls.duration_ms`
  - **ListAssetList**
    - changes of response param
      - `+ assets.duration_ms`
  - **ModifySubtitle**
    - changes of request param
      - `+ repackage_mode`
      - `+ delete_mode`
  - **ShowTakeOverAssetDetails**
    - changes of response param
      - `+ base_info.meta_data.duration_ms`
  - **PublishAssets**
    - changes of response param
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **UnpublishAssets**
    - changes of response param
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetMeta**
    - changes of response param
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetDetail**
    - changes of response param
      - `+ base_info.meta_data.duration_ms`
  - **ShowTakeOverTaskDetails**
    - changes of response param
      - `+ assets.base_info.meta_data.duration_ms`

# 3.1.121 2024-11-21

### HuaweiCloud SDK AOM

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **PushEvents**
    - changes of request param
      - `+ enterprise-project-id`
      - `- x-enterprise-prject-id`
  - **ListPromInstance**
    - changes of request param
      - `* Enterprise-Project-Id: optional -> required`

### HuaweiCloud SDK CloudRTC

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowUrlAuth`, `UpdateUrlAuth`

### HuaweiCloud SDK DDS

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
    - `ValidateConfigurationName`
    - `ShowInstanceConfigurationModifyHistory`
    - `SetAutoEnlargePolicies`
    - `BatchDeleteBackup`
    - `ShowAutoEnlargePolicy`
    - `ListScheduledTasks`
    - `CancelScheduledTask`
    - `BatchUpgradeDatabaseVersion`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EVS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ChangeVolumeChargeMode`, `UnsubscribePostpaidVolume`
  - **RetypeVolume**
    - changes of request param
      - `+ os-retype.iops`
      - `+ os-retype.throughput`

### HuaweiCloud SDK FunctionGraph

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowFunctionTrigger**
    - changes of response param
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
    - changes of response param
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
    - changes of request param
      - `+ event_data.channel_id`
      - `+ event_data.event_types`
      - `+ event_data.status: enum value [ACTIVE,DISABLE]`
    - changes of response param
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
    - changes of response param
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

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLimitTask**
    - changes of response param
      - `+ job_id`
      - `- jobId`
      - `* key_words: list<string> -> string`
  - **UpdateLimitTask**
    - changes of response param
      - `+ job_id`
      - `- jobId`

# 3.1.120 2024-11-14

### HuaweiCloud SDK AOM

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **PushEvents**
    - changes of request param
      - `+ enterprise-project-id`
      - `- x-enterprise-prject-id`
  - **ListPromInstance**
    - changes of request param
      - `* Enterprise-Project-Id: optional -> required`

### HuaweiCloud SDK CloudRTC

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowUrlAuth`, `UpdateUrlAuth`

### HuaweiCloud SDK DDS

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
    - `ValidateConfigurationName`
    - `ShowInstanceConfigurationModifyHistory`
    - `SetAutoEnlargePolicies`
    - `BatchDeleteBackup`
    - `ShowAutoEnlargePolicy`
    - `ListScheduledTasks`
    - `CancelScheduledTask`
    - `BatchUpgradeDatabaseVersion`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EVS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ChangeVolumeChargeMode`, `UnsubscribePostpaidVolume`
  - **RetypeVolume**
    - changes of request param
      - `+ os-retype.iops`
      - `+ os-retype.throughput`

### HuaweiCloud SDK FunctionGraph

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowFunctionTrigger**
    - changes of response param
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
    - changes of response param
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
    - changes of request param
      - `+ event_data.channel_id`
      - `+ event_data.event_types`
      - `+ event_data.status: enum value [ACTIVE,DISABLE]`
    - changes of response param
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
    - changes of response param
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

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLimitTask**
    - changes of response param
      - `+ job_id`
      - `- jobId`
      - `* key_words: list<string> -> string`
  - **UpdateLimitTask**
    - changes of response param
      - `+ job_id`
      - `- jobId`

# 3.1.119 2024-11-07

### HuaweiCloud SDK AAD

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpgradeInstanceSpec**
    - changes of request param
      - `+ upgrade_data.elastic_service_bandwidth_type`
      - `+ upgrade_data.elastic_service_bandwidth`

### HuaweiCloud SDK GaussDBforNoSQL

- _API Version_
  - V3
- _Features_
  - Support the API `BatchUpgradeDatabaseVersion`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _API Version_
  - V5
- _Features_
  - Support the following APIs:
    - `ListAsyncHistoryCommands`
    - `CountAsyncHistoryCommands`
    - `ListFunctions`
    - `AddFunctions`
    - `DeleteFunctions`
    - `ListAsyncCommands`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK MPC

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateExtractTask**
    - changes of request param
      - `+ encryption`
  - **CreateTranscodingTask**
    - changes of request param
      - `+ av_parameters.video.crf`
      - `+ av_parameters.video.max_bitrate`
  - **ListTranscodingTask**
    - changes of response param
      - `+ task_array.av_parameters.video.crf`
      - `+ task_array.av_parameters.video.max_bitrate`
  - **CreateEditingJob**
    - changes of request param
      - `+ concats.av_parameters.video.crf`
      - `+ concats.av_parameters.video.max_bitrate`
  - **ListEditingJob**
    - changes of response param
      - `+ jobs.edit_task_req.concats.av_parameters.video.crf`
      - `+ jobs.edit_task_req.concats.av_parameters.video.max_bitrate`

### HuaweiCloud SDK VPCEP

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEndpointInfoDetails**
    - changes of response param
      - `* error: object<QueryError> -> list<QueryError>`

# 3.1.118 2024-10-31

### HuaweiCloud SDK CFW

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ChangeEastWestFirewallStatus**
    - changes of response param
      - `- trace_id`
      - `* data: object -> object<ChangeEastWestFirewallStatusResponseData>`
  - **AddServiceSet**
    - changes of response param
      - `+ data.name`
      - `* data: object -> object<ServiceSetId>`
  - **ListJob**
    - changes of response param
      - `- error_msg`
      - `- error_code`
      - `* data: object -> object<GetCreateFirewallJobResponseData>`
  - **ListAddressSets**
    - changes of request param
      - `+ address_type: enum value [0,1]`
  - **BatchUpdateAclRuleActions**
    - changes of request param
      - `+ fw_instance_id`
  - **ListDnsServers**
    - changes of request param
      - `* fw_instance_id: required -> optional`
  - **ChangeIpsSwitchStatus**
    - changes of request param
      - `- X-Language`
      - `- ips_type: enum value [1]`
  - **UpdateAclRuleOrder**
    - changes of response param
      - `- data.name`
      - `* data: object<RuleId> -> object<OrderRuleId>`
  - **AddBlackWhiteList**
    - changes of response param
      - `* data: object<IdObject> -> object<BlackWhiteListId>`
  - **UpdateBlackWhiteList**
    - changes of response param
      - `* data: object<IdObject> -> object<BlackWhiteListId>`
  - **DeleteBlackWhiteList**
    - changes of response param
      - `* data: object<IdObject> -> object<BlackWhiteListId>`
  - **UpdateServiceSet**
    - changes of response param
      - `+ data.name`
      - `* data: object -> object<ServiceSetId>`
  - **DeleteServiceSet**
    - changes of response param
      - `* data: object<IdObject> -> object<ServiceSetId>`
  - **DeleteServiceItem**
    - changes of response param
      - `* data: object<IdObject> -> object<DeleteServiceItemResponseBodyData>`
  - **ListEipCount**
    - changes of response param
      - `- data.object_id`
  - **ChangeEipStatus**
    - changes of response param
      - `+ data.fail_eip_list`
  - **DeleteAddressItem**
    - changes of response param
      - `* data: object<IdObject> -> object<AddressItemId>`
  - **AddAddressSet**
    - changes of request param
      - `- address_type: enum value [0,1]`
    - changes of response param
      - `* data: object<IdObject> -> object<AddressSetId>`
  - **ListAddressSetDetail**
    - changes of response param
      - `- data.address_type: enum value [0,1]`
  - **UpdateAddressSet**
    - changes of response param
      - `+ data.name`
  - **DeleteAddressSet**
    - changes of response param
      - `* data: object<IdObject> -> object<AddressSetId>`
  - **AddDomainSet**
    - changes of request param
      - `* fw_instance_id: optional -> required`
  - **DeleteDomains**
    - changes of request param
      - `+ fw_instance_id`
  - **ListCaptureTask**
    - changes of request param
      - `* fw_instance_id: optional -> required`
    - changes of response param
      - `* data: list<HttpQueryCaptureTaskResponseData> -> object<HttpQueryCaptureTaskResponseData>`
  - **CreateCaptureTask**
    - changes of response param
      - `* data: object<IdObject> -> object<CaptureTaskId>`
  - **DeleteCaptureTask**
    - changes of response param
      - `* data: object<IdObject> -> object<CaptureTaskId>`
  - **CancelCaptureTask**
    - changes of response param
      - `* data: object<IdObject> -> object<CaptureTaskId>`
  - **ListEastWestFirewall**
    - changes of response param
      - `- data.er_associated_subnet`
      - `- data.ew_vpc_route_limit`
      - `- data.firewall_associated_subnets.status`
      - `- data.er.state`
      - `- data.er.enterprise_project_id`
      - `- data.er.enable_ipv6`
      - `- data.inspection_vpc.status`
  - **AddAclRule**
    - changes of request param
      - `- rules.applicationsJsonString`
  - **UpdateAclRule**
    - changes of request param
      - `- sequence`
      - `- applicationsJsonString`
  - **ListAclRules**
    - changes of request param
      - `+ address_type: enum value [2]`
  - **ListEips**
    - changes of request param
      - `+ status: enum value [null,0,1]`
      - `+ sync: enum value [0,1]`
    - changes of response param
      - `- data.records.owner`
  - **AddAddressItem**
    - changes of request param
      - `- address_items.name`
    - changes of response param
      - `- data.items.name`
      - `* data.items: list<IdObject> -> list<AddressItemIdWithoutName>`
  - **ListDomains**
    - changes of response param
      - `- data.records.dns_ips`
  - **ListFirewallDetail**
    - changes of request param
      - `+ service_type: enum value [0,1]`
    - changes of response param
      - `- data.records.status: enum value [-1,0,1,2,3,4,5,6,7,8,9,10,11]`
  - **ListDomainSets**
    - changes of response param
      - `- data.records.message`

### HuaweiCloud SDK DRS

- _API Version_
  - V5
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAsyncJobDetail**
    - changes of response param
      - `- jobs.compare_result.data_compare_task_list.dynamic_compare_delay`
      - `* jobs.compare_result.data_compare_task_list.report_remain_seconds: string -> int64`
  - **ShowJobDetail**
    - changes of response param
      - `- job.compare_result.data_compare_task_list.dynamic_compare_delay`
      - `* job.compare_result.data_compare_task_list.report_remain_seconds: string -> int64`

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - Support the following APIs:
    - `UpdateMysqlCompatibility`
    - `StartMysqlCompatibility`
    - `StopInstance`
    - `ListLimitTask`
    - `CreateLimitTask`
    - `ShowLimitTask`
    - `UpdateLimitTask`
    - `DeleteLimitTask`
    - `ListNodeLimitSqlModel`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK LTS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListLogStreams**
    - changes of response param
      - `+ log_streams.log_stream_name_alias`
      - `+ log_streams.whether_log_storage`
      - `+ log_streams.hot_cold_separation`
      - `+ log_streams.auth_web_tracking`
      - `+ log_streams.ttl_in_days`
      - `+ log_streams.hot_storage_days`
  - **ListLogStream**
    - changes of response param
      - `+ log_streams.log_stream_name_alias`
      - `+ log_streams.whether_log_storage`
      - `+ log_streams.hot_cold_separation`
      - `+ log_streams.auth_web_tracking`
      - `+ log_streams.ttl_in_days`
      - `+ log_streams.hot_storage_days`
  - **ListLogs**
    - changes of response param
      - `* analysisLogs: list<map<string, string>> -> list<object>`
  - **ShowNotificationTemplate**
    - changes of response param
      - `+ templates.topic`
  - **ListActiveOrHistoryAlarms**
    - changes of response param
      - `+ events.metadata.log_group_name`
      - `+ events.metadata.log_stream_name`
  - **DeleteActiveAlarms**
    - changes of request param
      - `+ events.metadata.log_group_name`
      - `+ events.metadata.log_stream_name`
  - **UpdateNotificationTemplate**
    - changes of request param
      - `+ templates.topic`
    - changes of response param
      - `+ templates.topic`
  - **CreateNotificationTemplate**
    - changes of request param
      - `+ templates.topic`
    - changes of response param
      - `+ templates.topic`
  - **ListNotificationTemplates**
    - changes of response param
      - `+ results.templates.topic`
  - **ListAccessConfig**
    - changes of response param
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
    - changes of request param
      - `+ incremental_collect`
      - `+ encoding_format`
      - `+ processor_type`
      - `+ demo_log`
      - `+ demo_fields`
      - `+ processors`
      - `+ application_id`
      - `+ environment_id`
      - `+ component_id`
    - changes of response param
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
    - changes of request param
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
    - changes of response param
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
    - changes of response param
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

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateAudioStreamModerationJob**
    - changes of request param
      - `+ data.return_all_results`

### HuaweiCloud SDK OCR

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ language`

### HuaweiCloud SDK RDS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListDbUsers**
    - changes of response param
      - `+ users.databases`
      - `+ users.hosts`
  - **ListSqlserverDbUsers**
    - changes of response param
      - `+ users.databases`
      - `+ users.hosts`

### HuaweiCloud SDK VOD

- _API Version_
  - V1
- _Features_
  - Support the APIs `ShowStorageModeType`, `UpdateStorageModeType`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.117 2024-10-24

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCluster**
    - changes of response param
      - `+ spec.enableDistMgt`
  - **UpdateCluster**
    - changes of response param
      - `+ spec.enableDistMgt`
  - **DeleteCluster**
    - changes of response param
      - `+ spec.enableDistMgt`
  - **CreateCluster**
    - changes of request param
      - `+ spec.enableDistMgt`
    - changes of response param
      - `+ spec.enableDistMgt`
  - **ListClusters**
    - changes of response param
      - `+ items.spec.enableDistMgt`

### HuaweiCloud SDK CES

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateAgentInvocations**
    - changes of request param
      - `+ version`

### HuaweiCloud SDK DRS

- _API Version_
  - V5
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.compare_result.data_compare_task_list.options`
      - `+ jobs.compare_result.data_compare_task_list.dynamic_compare_delay`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.compare_result.data_compare_task_list.options`
      - `+ job.compare_result.data_compare_task_list.dynamic_compare_delay`

### HuaweiCloud SDK GaussDB

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CheckTableConfig**
    - changes of request param
      - `+ target_database_name`
      - `+ is_create_task`

### HuaweiCloud SDK RAM

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **EnableOrganizationShare**
    - changes of request param
      - `+ X-Security-Token`
  - **DisableOrganizationShare**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowOrganizationShare**
    - changes of request param
      - `+ X-Security-Token`
  - **AssociateResourceSharePermission**
    - changes of request param
      - `+ X-Security-Token`
  - **DisassociateResourceSharePermission**
    - changes of request param
      - `+ X-Security-Token`
  - **AcceptResourceShareInvitation**
    - changes of request param
      - `+ X-Security-Token`
  - **RejectResourceShareInvitation**
    - changes of request param
      - `+ X-Security-Token`
  - **SearchResourceShareInvitation**
    - changes of request param
      - `+ X-Security-Token`
  - **ListPermissions**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowPermission**
    - changes of request param
      - `+ X-Security-Token`
  - **AssociateResourceShare**
    - changes of request param
      - `+ X-Security-Token`
  - **DisassociateResourceShare**
    - changes of request param
      - `+ X-Security-Token`
  - **SearchResourceShareAssociations**
    - changes of request param
      - `+ X-Security-Token`
  - **ListResourceShareTags**
    - changes of request param
      - `+ X-Security-Token`
  - **SearchResourceShareCountByTags**
    - changes of request param
      - `+ X-Security-Token`
  - **BatchCreateResourceShareTags**
    - changes of request param
      - `+ X-Security-Token`
  - **BatchDeleteResourceShareTags**
    - changes of request param
      - `+ X-Security-Token`
  - **ListResourceSharePermissions**
    - changes of request param
      - `+ X-Security-Token`
  - **SearchSharedResources**
    - changes of request param
      - `+ X-Security-Token`
  - **SearchSharedPrincipals**
    - changes of request param
      - `+ X-Security-Token`
  - **ListResourceTypes**
    - changes of request param
      - `+ X-Security-Token`
  - **ListPermissionVersions**
    - changes of request param
      - `+ X-Security-Token`
  - **CreateResourceShare**
    - changes of request param
      - `+ X-Security-Token`
  - **SearchResourceShares**
    - changes of request param
      - `+ X-Security-Token`
  - **DeleteResourceShare**
    - changes of request param
      - `+ X-Security-Token`
  - **UpdateResourceShare**
    - changes of request param
      - `+ X-Security-Token`
  - **ListResourceSharesByTags**
    - changes of request param
      - `+ X-Security-Token`
  - **ListQuota**
    - changes of request param
      - `+ X-Security-Token`

# 3.1.116 2024-10-17

### HuaweiCloud SDK CDN

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDomain**
    - changes of request param
      - `+ domain.sources.http_port`
      - `+ domain.sources.https_port`

### HuaweiCloud SDK DBSS

- _API Version_
  - V1
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **ShowAuditQuota**
    - changes of response param
      - `- quota`
  - **ListAuditRuleRisks**
    - changes of request param
      - `+ risk_levels: enum value [LOW,MEDIUM,HIGH,NO_RISK]`
    - changes of response param
      - `+ rules.rule_type`
  - **ListProjectResourceTags**
    - changes of request param
      - `+ resource_type: enum value [auditInstance]`
  - **BatchAddResourceTag**
    - changes of request param
      - `+ resource_type: enum value [auditInstance]`
      - `* tags: list<KeyValueBean> -> list<object>`
      - `* sys_tags: list<KeyValueBean> -> list<object>`
  - **BatchDeleteResourceTag**
    - changes of request param
      - `+ resource_type: enum value [auditInstance]`
      - `* tags: list<KeyValueBean> -> list<object>`
      - `* sys_tags: list<KeyValueBean> -> list<object>`
      - `* body: object<ResourceTagRequest> -> object<ResourceTagDeleteRequest>`
  - **UpdateAuditSecurityGroup**
    - changes of request param
      - `+ instance_id`
      - `- resource_id`
  - **SwitchAgent**
    - changes of request param
      - `+ status: enum value [0,1]`
  - **ListEcsSpecification**
    - changes of response param
      - `+ specification.az_type`
  - **ListAuditInstanceJobs**
    - changes of response param
      - `+ jobs.resource_id`
  - **ListAuditOperateLogs**
    - changes of request param
      - `+ action`
      - `- operate_name`
      - `+ result: enum value [success,fail]`
      - `+ time.time_range: enum value [HALF_HOUR, HOUR, THREE_HOUR, TWELVE_HOUR, DAY, WEEK, MONTH]`
  - **ListResourceInstanceByTag**
    - changes of request param
      - `+ resource_type: enum value [auditInstance]`
  - **CountResourceInstanceByTag**
    - changes of request param
      - `+ resource_type: enum value [auditInstance]`
  - **ListAuditDatabases**
    - changes of response param
      - `+ databases.database.rds_audit_switch_mismatch`
      - `+ databases.database.rds_id`
      - `+ databases.database.rds_obj_info`
      - `+ databases.database.dws_obj_info`
      - `+ databases.database.clouddb_obj_info`

### HuaweiCloud SDK ECS

- _API Version_
  - V2
- _Features_
  - Support the API `NovaShowFlavorExtraSpecs`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.115 2024-10-10

### HuaweiCloud SDK AAD

- _API Version_
  - V1
- _Features_
  - Support the APIs `AssociateIpToPolicyAndPackage`, `DisassociateIpFromPolicyAndPackage`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAutopilotCluster**
    - changes of response param
      - `+ spec.deletionProtection`
  - **UpdateAutopilotCluster**
    - changes of response param
      - `+ spec.deletionProtection`
  - **DeleteAutopilotCluster**
    - changes of response param
      - `+ spec.deletionProtection`
  - **CreateAutopilotCluster**
    - changes of request param
      - `+ spec.deletionProtection`
    - changes of response param
      - `+ spec.deletionProtection`
  - **ListAutopilotClusters**
    - changes of response param
      - `+ items.spec.deletionProtection`

### HuaweiCloud SDK DRS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchListJobDetails**
    - changes of response param
      - `* results.node_num: string -> int32`

### HuaweiCloud SDK DRS

- _API Version_
  - V5
- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK ELB

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMembers**
    - changes of request param
      - `+ enterprise_project_id`

### HuaweiCloud SDK EVS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVolume**
    - changes of response param
      - `- volume.snapshot_policy_id`
  - **ListVolumes**
    - changes of request param
      - `- snapshot_policy_id`
    - changes of response param
      - `- volumes.snapshot_policy_id`

### HuaweiCloud SDK GaussDB

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateStarrocksInstance**
    - changes of request param
      - `+ security_group_id`
  - **CheckStarrocksParams**
    - changes of response param
      - `+ differences`
      - `- check_starrocks_params_responce`

### HuaweiCloud SDK RDS

- _API Version_
  - V3
- _Features_
  - Support the APIs `ShowRecoveryTimeWindow`, `UpdateToPeriod`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.114 2024-09-26

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **UpdateNode**
    - changes of response param
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **DeleteNode**
    - changes of response param
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **CreateNode**
    - changes of request param
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
    - changes of response param
      - `+ spec.rootVolume.iops`
      - `+ spec.rootVolume.throughput`
      - `+ spec.storage.storageSelectors.matchLabels.iops`
      - `+ spec.storage.storageSelectors.matchLabels.throughput`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.rootVolume.iops`
      - `+ items.spec.rootVolume.throughput`
      - `+ items.spec.storage.storageSelectors.matchLabels.iops`
      - `+ items.spec.storage.storageSelectors.matchLabels.throughput`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **UpdateNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **AddNode**
    - changes of request param
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.iops`
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.throughput`
  - **ResetNode**
    - changes of request param
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.iops`
      - `+ nodeList.spec.volumeConfig.storage.storageSelectors.matchLabels.throughput`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
    - changes of response param
      - `+ spec.nodeTemplate.rootVolume.iops`
      - `+ spec.nodeTemplate.rootVolume.throughput`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.rootVolume.iops`
      - `+ items.spec.nodeTemplate.rootVolume.throughput`
      - `+ items.spec.nodeTemplate.storage.storageSelectors.matchLabels.iops`
      - `+ items.spec.nodeTemplate.storage.storageSelectors.matchLabels.throughput`

### HuaweiCloud SDK CES

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAlarmRules**
    - changes of request param
      - `+ tags`

### HuaweiCloud SDK DDS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ResizeInstance**
    - changes of request param
      - `+ resize.target_type: enum value [config,readonly]`

### HuaweiCloud SDK Live

- _API Version_
  - V1
- _Features_
  - Support the following APIs:
    - `ListHarvestTask`
    - `ModifyHarvestTask`
    - `CreateHarvestTask`
    - `DeleteHarvestTask`
    - `UpdateHarvestJobStatus`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPCEP

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateEndpointService**
    - changes of request param
      - `+ snat_network_id`

# 3.1.113 2024-09-23

### HuaweiCloud SDK AOM

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEvents**
    - changes of response param
      - `* page_info.current_count: string -> int32`
  - **PushEvents**
    - changes of request param
      - `- events.event_sn`
      - `- events.arrives_at`
      - `- events.enterprise_project_id`
      - `- events.policy`

### HuaweiCloud SDK CDN

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateDomainMultiCertificates**
    - changes of request param
      - `+ https.scm_certificate_id`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.user_agent_filter.include_empty`
      - `+ configs.https.scm_certificate_id`
      - `+ configs.https.certificates.certificate_source`
      - `+ configs.https.certificates.scm_certificate_id`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.user_agent_filter.include_empty`
      - `+ configs.https.scm_certificate_id`
      - `+ configs.https.certificates.certificate_source`
      - `+ configs.https.certificates.scm_certificate_id`

### HuaweiCloud SDK DDS

- _API Version_
  - V3
- _Features_
  - Support the API `ListDatabases`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK ECS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListServersDetails**
    - changes of request param
      - `+ marker`

### HuaweiCloud SDK EVS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVolume**
    - changes of response param
      - `+ volume.snapshot_policy_id`
  - **ListVolumes**
    - changes of request param
      - `+ snapshot_policy_id`
    - changes of response param
      - `+ volumes.snapshot_policy_id`

### HuaweiCloud SDK IAM

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAgencies**
    - changes of response param
      - `+ agencies.agency_urn`
  - **CreateAgency**
    - changes of request param
      - `- agency.duration: enum value [FOREVER,ONEDAY]`
    - changes of response param
      - `+ agency.agency_urn`
  - **ShowAgency**
    - changes of response param
      - `+ agency.agency_urn`
  - **UpdateAgency**
    - changes of request param
      - `- agency.duration: enum value [FOREVER,ONEDAY]`
    - changes of response param
      - `+ agency.agency_urn`

### HuaweiCloud SDK Organizations

- _API Version_
  - V1
- _Features_
  - Support the API `UpdateAccount`
- _Bug Fix_
  - None
- _Change_
  - **LeaveOrganization**
    - changes of request param
      - `+ X-Security-Token`
  - **CloseAccount**
    - changes of request param
      - `+ X-Security-Token`
  - **RemoveAccount**
    - changes of request param
      - `+ X-Security-Token`
  - **MoveAccount**
    - changes of request param
      - `+ X-Security-Token`
  - **EnableTrustedService**
    - changes of request param
      - `+ X-Security-Token`
  - **DisableTrustedService**
    - changes of request param
      - `+ X-Security-Token`
  - **RegisterDelegatedAdministrator**
    - changes of request param
      - `+ X-Security-Token`
  - **DeregisterDelegatedAdministrator**
    - changes of request param
      - `+ X-Security-Token`
  - **AttachPolicy**
    - changes of request param
      - `+ X-Security-Token`
  - **DetachPolicy**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowEffectivePolicies**
    - changes of request param
      - `+ X-Security-Token`
  - **UntagResource**
    - changes of request param
      - `+ X-Security-Token`
  - **ListServices**
    - changes of request param
      - `+ X-Security-Token`
  - **DeleteOrganization**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowOrganization**
    - changes of request param
      - `+ X-Security-Token`
  - **CreateOrganization**
    - changes of request param
      - `+ X-Security-Token`
  - **ListOrganizationalUnits**
    - changes of request param
      - `+ X-Security-Token`
  - **CreateOrganizationalUnit**
    - changes of request param
      - `+ X-Security-Token`
  - **DeleteOrganizationalUnit**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowOrganizationalUnit**
    - changes of request param
      - `+ X-Security-Token`
  - **UpdateOrganizationalUnit**
    - changes of request param
      - `+ X-Security-Token`
      - `- X-Auth-Token`
  - **ListAccounts**
    - changes of request param
      - `+ X-Security-Token`
      - `+ with_register_contact_info`
    - changes of response param
      - `+ accounts.mobile_phone`
      - `+ accounts.intl_number_prefix`
      - `+ accounts.email`
      - `+ accounts.description`
  - **CreateAccount**
    - changes of request param
      - `+ X-Security-Token`
      - `+ description`
  - **ShowAccount**
    - changes of request param
      - `+ X-Security-Token`
      - `+ with_register_contact_info`
    - changes of response param
      - `+ account.mobile_phone`
      - `+ account.intl_number_prefix`
      - `+ account.email`
      - `+ account.description`
  - **ListCreateAccountStatuses**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowCreateAccountStatus**
    - changes of request param
      - `+ X-Security-Token`
  - **ListCloseAccountStatuses**
    - changes of request param
      - `+ X-Security-Token`
  - **ListTrustedServices**
    - changes of request param
      - `+ X-Security-Token`
  - **ListDelegatedServices**
    - changes of request param
      - `+ X-Security-Token`
  - **ListDelegatedAdministrators**
    - changes of request param
      - `+ X-Security-Token`
  - **ListEntitiesForPolicy**
    - changes of request param
      - `+ X-Security-Token`
  - **ListTagsForResource**
    - changes of request param
      - `+ X-Security-Token`
  - **TagResource**
    - changes of request param
      - `+ X-Security-Token`
  - **ListEntities**
    - changes of request param
      - `+ X-Security-Token`
  - **ListTagPolicyServices**
    - changes of request param
      - `+ X-Security-Token`
  - **ListTagResources**
    - changes of request param
      - `+ X-Security-Token`
  - **CreateTagResource**
    - changes of request param
      - `+ X-Security-Token`
  - **DeleteTagResource**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowResourceInstancesCount**
    - changes of request param
      - `+ X-Security-Token`
  - **ListResourceTags**
    - changes of request param
      - `+ X-Security-Token`
  - **ListRoots**
    - changes of request param
      - `+ X-Security-Token`
  - **InviteAccount**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshake.expired_at`
  - **ShowHandshake**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshake.expired_at`
  - **AcceptHandshake**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshake.expired_at`
  - **DeclineHandshake**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshake.expired_at`
  - **CancelHandshake**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshake.expired_at`
  - **ListReceivedHandshakes**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshakes.expired_at`
  - **ListHandshakes**
    - changes of request param
      - `+ X-Security-Token`
    - changes of response param
      - `+ handshakes.expired_at`
  - **ListPolicies**
    - changes of request param
      - `+ X-Security-Token`
  - **CreatePolicy**
    - changes of request param
      - `+ X-Security-Token`
  - **DeletePolicy**
    - changes of request param
      - `+ X-Security-Token`
  - **ShowPolicy**
    - changes of request param
      - `+ X-Security-Token`
  - **UpdatePolicy**
    - changes of request param
      - `+ X-Security-Token`
      - `- X-Auth-Token`
  - **EnablePolicyType**
    - changes of request param
      - `+ X-Security-Token`
  - **DisablePolicyType**
    - changes of request param
      - `+ X-Security-Token`
  - **ListResourceInstances**
    - changes of request param
      - `+ X-Security-Token`
  - **ListQuotas**
    - changes of request param
      - `+ X-Security-Token`

# 3.1.112 2024-09-12

### HuaweiCloud SDK AOM

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEvents**
    - changes of request param
      - `+ limit`
      - `+ marker`
    - changes of response param
      - `+ page_info`
      - `+ events.event_sn`
      - `+ events.arrives_at`
      - `+ events.enterprise_project_id`
      - `+ events.policy`
  - **PushEvents**
    - changes of request param
      - `- events`
      - `+ events.event_sn`
      - `+ events.arrives_at`
      - `+ events.enterprise_project_id`
      - `+ events.policy`
  - **DeletePromInstance**
    - changes of request param
      - `* Enterprise-Project-Id: optional -> required`

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - Support the API `AddNodesToNodePool`
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowResourceInstances`, `BatchCreateDeleteResourceTags`, `ShowResourceTags`, `ShowCustomizeClusterTagsByProjectId`

### HuaweiCloud SDK VPCEP

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListServiceDetails**
    - changes of response param
      - `+ ip`
  - **UpdateEndpointService**
    - changes of request param
      - `+ ip`
    - changes of response param
      - `+ ip`
  - **CreateEndpointService**
    - changes of request param
      - `+ ip`
    - changes of response param
      - `+ ip`
  - **ListEndpointService**
    - changes of request param
      - `+ net_type`
    - changes of response param
      - `+ endpoint_services.ip`

# 3.1.111 2024-09-05

### HuaweiCloud SDK BMS

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ChangeBaremetalServerName**
    - changes of response param
      - `* server.hostId: uuid -> string`

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - Support the API `RevokeKubernetesClusterCert`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DNS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowResourceTag**
    - changes of response param
      - `- enterpriseProjectOrDefault`

### HuaweiCloud SDK ECS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListCloudServers**
    - changes of request param
      - `+ marker`
    - changes of response param
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

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **InvokeFunction**
    - changes of request param
      - `+ X-Cff-Instance-Memory`
  - **AsyncInvokeFunction**
    - changes of request param
      - `+ X-Cff-Instance-Memory`

### HuaweiCloud SDK IAM

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAgencies**
    - changes of request param
      - `+ page`
      - `+ per_page`
  - **ShowDomainRoleAssignments**
    - changes of request param
      - `* page: string -> int32`
      - `* per_page: string -> int32`
  - **ListCustomPolicies**
    - changes of response param
      - `- roles.references`
      - `* roles: list<PolicyRoleResult> -> list<ListPolicyRoleResult>`
  - **CreateCloudServiceCustomPolicy**
    - changes of response param
      - `- role.references`
  - **UpdateCloudServiceCustomPolicy**
    - changes of response param
      - `- role.references`
  - **CreateAgencyCustomPolicy**
    - changes of response param
      - `- role.references`
  - **UpdateAgencyCustomPolicy**
    - changes of response param
      - `- role.references`

### HuaweiCloud SDK Live

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainHttpsCert**
    - changes of response param
      - `+ tls_certificate`
      - `+ gm_certificate`
  - **UpdateDomainHttpsCert**
    - changes of request param
      - `+ tls_certificate`
      - `+ gm_certificate`

### HuaweiCloud SDK VPC

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateSubNetworkInterface**
    - changes of request param
      - `- sub_network_interface.instance_id`
      - `- sub_network_interface.instance_type`
      - `- sub_network_interface.tags`
  - **BatchCreateSubNetworkInterface**
    - changes of request param
      - `- sub_network_interface.instance_id`
      - `- sub_network_interface.instance_type`
      - `- sub_network_interface.tags`

# 3.1.110 2024-08-29

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **UpdateNode**
    - changes of response param
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **DeleteNode**
    - changes of response param
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **CreateNode**
    - changes of request param
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
    - changes of response param
      - `+ spec.nodeNicSpec.primaryNic.subnetList`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.nodeNicSpec.primaryNic.subnetList`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **UpdateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.nodeNicSpecUpdate`
    - changes of response param
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
    - changes of response param
      - `+ spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.nodeNicSpec.primaryNic.subnetList`

### HuaweiCloud SDK ECS

- _API Version_
  - V2
- _Features_
  - Support the API `ListCloudServers`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EIP

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListCommonPools**
    - changes of request param
      - `* fields: string -> list<string>`
  - **ListShareBandwidthTypes**
    - changes of request param
      - `* fields: string -> list<string>`
  - **ListTenantVpcIgws**
    - changes of request param
      - `* fields: string -> list<string>`
  - **CreateTenantVpcIgw**
    - changes of request param
      - `* fields: string -> list<string>`
  - **ShowInternalVpcIgw**
    - changes of request param
      - `* fields: string -> list<string>`
  - **UpdateTenantVpcIgw**
    - changes of request param
      - `* fields: string -> list<string>`
  - **ListEipBandwidths**
    - changes of request param
      - `+ fields`
  - **ListBandwidth**
    - changes of request param
      - `+ fields`
  - **ListPublicipPool**
    - changes of request param
      - `* fields: string -> list<string>`
  - **ShowPublicipPool**
    - changes of request param
      - `* fields: string -> list<string>`
  - **ListProjectGeipBindings**
    - changes of request param
      - `* fields: string -> list<string>`

### HuaweiCloud SDK EVS

- _API Version_
  - V2
- _Features_
  - Support the API `RetypeVolume`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowFunctionCode**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`
  - **UpdateFunctionCode**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`
  - **CreateFunction**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`
  - **ShowFunctionConfig**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`
  - **UpdateFunctionConfig**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`
  - **UpdateFunctionMaxInstanceConfig**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`
  - **CreateFunctionTrigger**
    - changes of request param
      - `+ event_data.Key_encode`
      - `+ event_data.agency`
      - `+ event_data.channel_name`
      - `+ event_data.source_name`
      - `+ event_data.created_time`
      - `+ event_data.status`
      - `+ event_data.trigger_name`
  - **CreateFunctionVersion**
    - changes of response param
      - `* dependencies.last_modified: date-time -> int64`

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - Support the API `CreateGaussDbInstance`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateManualBackup**
    - changes of request param
      - `+ backup_database_individually`

### HuaweiCloud SDK VPC

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AddSecurityGroups**
    - changes of response param
      - `+ port.extra_dhcp_opts.opt_name`
      - `+ port.extra_dhcp_opts.opt_value`
      - `* port.extra_dhcp_opts: list<object> -> list<ExtraDhcpOpt>`
  - **RemoveSecurityGroups**
    - changes of response param
      - `+ port.extra_dhcp_opts.opt_name`
      - `+ port.extra_dhcp_opts.opt_value`
      - `* port.extra_dhcp_opts: list<object> -> list<ExtraDhcpOpt>`

# 3.1.109 2024-08-22

### HuaweiCloud SDK CCE

- _API Version_
  - V3
- _Features_
  - Support the APIs `SyncNode`, `BatchSyncNodes`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DRS

- _API Version_
  - V5
- _Features_
  - Support the APIs `UploadUserJdbcDriver`, `SyncUserJdbcDriver`, `ListUserJdbcDrivers`, `DeleteUserJdbcDriver`
- _Bug Fix_
  - None
- _Change_
  - **CreateJob**
    - changes of request param
      - `+ job.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ job.source_endpoint.db_type: enum value [mysql]`
    - changes of response param
      - `+ is_clone_job`
      - `+ create_time`
      - `+ name`
      - `+ id`
      - `+ status`
      - `- job`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.policy_config.is_create_table_with_index`
      - `+ jobs.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ jobs.source_endpoint.db_type: enum value [mysql]`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.status: enum value [CREATING,CREATE_FAILED,CONFIGURATION,STARTJOBING,WAITING_FOR_START,START_JOB_FAILED,PAUSING,FULL_TRANSFER_STARTED,FULL_TRANSFER_FAILED,FULL_TRANSFER_COMPLETE,INCRE_TRANSFER_STARTED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_STARTED,RELEASE_RESOURCE_FAILED,RELEASE_RESOURCE_COMPLETE,REBUILD_NODE_STARTED,REBUILD_NODE_FAILED,CHANGE_JOB_STARTED,CHANGE_JOB_FAILED,DELETED,CHILD_TRANSFER_STARTING,CHILD_TRANSFER_STARTED,CHILD_TRANSFER_COMPLETE,CHILD_TRANSFER_FAILED,RELEASE_CHILD_TRANSFER_STARTED,RELEASE_CHILD_TRANSFER_COMPLETE,NODE_UPGRADE_START,NODE_UPGRADE_COMPLETE,NODE_UPGRADE_FAILED]`
      - `+ jobs.policy_config.is_create_table_with_index`
      - `+ jobs.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ jobs.source_endpoint.db_type: enum value [mysql]`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.params.policy_config.is_create_table_with_index`
      - `+ jobs.params.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ jobs.params.source_endpoint.db_type: enum value [mysql]`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.status: enum value [CREATING,CREATE_FAILED,CONFIGURATION,STARTJOBING,WAITING_FOR_START,START_JOB_FAILED,PAUSING,FULL_TRANSFER_STARTED,FULL_TRANSFER_FAILED,FULL_TRANSFER_COMPLETE,INCRE_TRANSFER_STARTED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_STARTED,RELEASE_RESOURCE_FAILED,RELEASE_RESOURCE_COMPLETE,REBUILD_NODE_STARTED,REBUILD_NODE_FAILED,CHANGE_JOB_STARTED,CHANGE_JOB_FAILED,DELETED,CHILD_TRANSFER_STARTING,CHILD_TRANSFER_STARTED,CHILD_TRANSFER_COMPLETE,CHILD_TRANSFER_FAILED,RELEASE_CHILD_TRANSFER_STARTED,RELEASE_CHILD_TRANSFER_COMPLETE,NODE_UPGRADE_START,NODE_UPGRADE_COMPLETE,NODE_UPGRADE_FAILED]`
      - `+ job.policy_config.is_create_table_with_index`
      - `+ job.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ job.source_endpoint.db_type: enum value [mysql]`
  - **UpdateJob**
    - changes of request param
      - `+ job.params.policy_config.is_create_table_with_index`
      - `+ job.params.base_info.engine_type: enum value [mysql-to-mysql]`
      - `+ job.params.source_endpoint.db_type: enum value [mysql]`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_params.is_only_init_task`
      - `+ job.action_params.endpoints.db_type: enum value [mysql]`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_params.is_only_init_task`
      - `+ jobs.action_params.endpoints.db_type: enum value [mysql]`

### HuaweiCloud SDK GaussDBforopenGauss

- _API Version_
  - V3
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDbInstance**
    - changes of request param
      - `+ ha.instance_mode`

### HuaweiCloud SDK KMS

- _API Version_
  - V2
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDatakey**
    - changes of request param
      - `+ additional_authenticated_data`
  - **CreateDatakeyWithoutPlaintext**
    - changes of request param
      - `+ additional_authenticated_data`
  - **EncryptDatakey**
    - changes of request param
      - `+ additional_authenticated_data`
  - **DecryptDatakey**
    - changes of request param
      - `+ additional_authenticated_data`
  - **EncryptData**
    - changes of request param
      - `+ additional_authenticated_data`
  - **DecryptData**
    - changes of request param
      - `+ additional_authenticated_data`

### HuaweiCloud SDK VPCEP

- _API Version_
  - V1
- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEndpointInfoDetails**
    - changes of response param
      - `* policy_document: string -> object`
  - **UpdateEndpointWhite**
    - changes of response param
      - `* policy_document: string -> object`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `* policy_document: string -> object`
    - changes of response param
      - `* policy_document: string -> object`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `* policy_document: string -> object`
  - **CreateEndpoint**
    - changes of request param
      - `* policy_document: string -> object`
    - changes of response param
      - `* policy_document: string -> object`
  - **ListEndpoints**
    - changes of response param
      - `* endpoints.policy_document: string -> object`

# 3.1.108 2024-08-15

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **EstimateExecutionPlanPrice**
    - changes of response param
      - `+ items.module_address`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNodePool**
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **UpdateNodePool**
    - changes of request param
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **DeleteNodePool**
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **CreateNodePool**
    - changes of request param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **ListNodePools**
    - changes of response param
      - `+ items.status.scaleGroupStatuses`
      - `* items.spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`

### HuaweiCloud SDK DCS

- _Features_
  - Support the API `BatchRestartOnlineMigrationTasks`
- _Bug Fix_
  - None
- _Change_
  - **BatchStopMigrationTasks**
    - changes of response param
      - `+ migration_tasks.error_msg`
      - `+ migration_tasks.error_code`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdatePrePaidBandwidth**
    - changes of request param
      - `+ extendParam.period_type`
      - `+ extendParam.period_num`
  - **ListEipBandwidths**
    - changes of response param
      - `* eip_bandwidths.tenant_id: uuid -> string`
  - **ListProjectGeipBindings**
    - changes of response param
      - `* geip_bindings.vnic.vni: int32 -> string`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAvailabilityZones**
    - changes of response param
      - `+ spec_code`
  - **ListFlavors**
    - changes of request param
      - `- loadbalancer_type`
  - **ShowLoadBalancer**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **UpdateLoadBalancer**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **BatchAddAvailableZones**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **BatchRemoveAvailableZones**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **ListLoadBalancers**
    - changes of response param
      - `+ loadbalancers.gw_flavor_id`
      - `+ loadbalancers.loadbalancer_type`
  - **CreateLoadBalancer**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstance**
    - changes of request param
      - `+ ha.instance_mode`
  - **ShowBatchUpgradeCandidateVersions**
    - changes of response param
      - `+ hotfix_rollback_infos`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of request param
      - `+ visibility: enum value [shared]`
    - changes of response param
      - `+ images.visibility: enum value [shared]`
  - **UpdateImage**
    - changes of response param
      - `+ visibility: enum value [shared]`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListLogs**
    - changes of request param
      - `+ query`
      - `+ is_analysis_query`
    - changes of response param
      - `+ analysisLogs`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeTransportationLicense**
    - changes of response param
      - `+ result.expiry_date`
      - `+ result.review_expiry_date`
      - `+ result.assessed_technical_level`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **UpdateEndpointWhite**
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **CreateEndpoint**
    - changes of request param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **ListEndpoints**
    - changes of response param
      - `+ endpoints.policy_statement.Effect: enum value [Deny]`
      - `- endpoints.policy_statement.Effect: enum value [Refuse]`

# 3.1.107 2024-08-08

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ single_orientation_mode`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSubNetworkInterfaces**
    - changes of response param
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **CreateSubNetworkInterface**
    - changes of request param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.tags`
    - changes of response param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **BatchCreateSubNetworkInterface**
    - changes of request param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.tags`
    - changes of response param
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **ShowSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **UpdateSubNetworkInterface**
    - changes of request param
      - `+ sub_network_interface.allowed_address_pairs`
    - changes of response param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **MigrateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **UpdateTrafficMirrorSession**
    - changes of request param
      - `- traffic_mirror_session.type`

# 3.1.106 2024-08-01

### HuaweiCloud SDK LTS

- _Features_
  - Support the following APIs:
    - `ListConsumerGroup`
    - `CreateConsumerGroup`
    - `ConsumerGroupHeartBeat`
    - `ShowLogStreamShards`
    - `ListDetailsConsumerGroup`
    - `UpdateCheckPoint`
    - `DeleteConsumerGroup`
    - `ShowCursorByTime`
    - `ShowCursorTime`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ policy_document`
  - **UpdateEndpointWhite**
    - changes of response param
      - `+ policy_document`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `+ policy_document`
    - changes of response param
      - `+ policy_document`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `+ policy_document`
  - **CreateEndpoint**
    - changes of request param
      - `+ policy_document`
    - changes of response param
      - `+ policy_document`
  - **ListEndpoints**
    - changes of response param
      - `+ endpoints.policy_document`

# 3.1.105 2024-07-25

### HuaweiCloud SDK CCE

- _Features_
  - Support the following APIs:
    - `SyncNodePool`
    - `UpgradeNodePool`
    - `ShowClusterSupportConfiguration`
    - `ShowResourceInstances`
    - `BatchCreateDeleteResourceTags`
    - `ShowResourceTags`
    - `ShowCustomizeClusterTagsByProjectId`
    - `UpdateAutopilotClusterEip`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - Support the API `BatchCheckImageSync`
- _Bug Fix_
  - None
- _Change_
  - **RunTextModeration**
    - changes of request param
      - `+ Enterprise-Project-Id`
  - **CheckImageModeration**
    - changes of request param
      - `+ Enterprise-Project-Id`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeCambodianIdCard**
    - changes of request param
      - `+ detect_reproduce`
    - changes of response param
      - `+ result.detect_reproduce_result`
      - `+ result.score_info.reproduce_score`

# 3.1.104 2024-07-18

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingV2Policy**
    - changes of request param
      - `+ scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ interval_alarm_actions.percentage`
      - `* interval_alarm_actions.lower_bound: int32 -> double`
      - `* interval_alarm_actions.upper_bound: int32 -> double`
  - **ListAllScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policies.interval_alarm_actions.percentage`
      - `* scaling_policies.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policies.interval_alarm_actions.upper_bound: int32 -> double`
  - **UpdateScalingV2Policy**
    - changes of request param
      - `+ scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ interval_alarm_actions.percentage`
      - `* interval_alarm_actions.lower_bound: int32 -> double`
      - `* interval_alarm_actions.upper_bound: int32 -> double`
  - **ShowScalingV2Policy**
    - changes of response param
      - `+ scaling_policy.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policy.interval_alarm_actions.percentage`
      - `* scaling_policy.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policy.interval_alarm_actions.upper_bound: int32 -> double`
  - **ListScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policies.interval_alarm_actions.percentage`
      - `* scaling_policies.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policies.interval_alarm_actions.upper_bound: int32 -> double`

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBareMetalServers**
    - changes of response param
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`
  - **ListBareMetalServerDetails**
    - changes of response param
      - `+ server.flavor.gpus`
      - `+ server.flavor.asic_accelerators`

### HuaweiCloud SDK CCE

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTraces**
    - changes of request param
      - `+ access_key_id`
      - `+ enterprise_project_id`
    - changes of response param
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

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.node_type: enum value [micro,small,medium,xlarge,2xlarge]`
  - **BatchUpdateJob**
    - changes of request param
      - `+ jobs.node_type: enum value [micro,small,medium,xlarge,2xlarge]`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowServer**
    - changes of response param
      - `+ server.flavor.gpus`
      - `+ server.flavor.asic_accelerators`
  - **ListServersDetails**
    - changes of response param
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`

### HuaweiCloud SDK ELB

- _Features_
  - Support the APIs `ShowCertificatePrivateKeyEcho`, `CreateCertificatePrivateKeyEcho`
- _Bug Fix_
  - None
- _Change_
  - **ShowQuota**
    - changes of response param
      - `+ quota.free_instance_members_per_pool`
      - `+ quota.free_instance_listeners_per_loadbalancer`
  - **ChangeLoadbalancerChargeMode**
    - changes of request param
      - `+ pay_type`
      - `+ prepaid_options.cloud_service_console_url`
  - **ListCertificates**
    - changes of request param
      - `+ common_name`
      - `+ fingerprint`
    - changes of response param
      - `+ certificates.common_name`
      - `+ certificates.fingerprint`
      - `+ certificates.subject_alternative_names`
  - **CreateCertificate**
    - changes of response param
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **ShowCertificate**
    - changes of response param
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **UpdateCertificate**
    - changes of request param
      - `+ certificate.scm_certificate_id`
    - changes of response param
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **ListFlavors**
    - changes of request param
      - `+ loadbalancer_type`
    - changes of response param
      - `+ flavors.public_border_group`
      - `+ flavors.category`
  - **ShowFlavor**
    - changes of response param
      - `+ flavor.public_border_group`
      - `+ flavor.category`
  - **UpdateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.gw_flavor_id`
  - **ListIpGroups**
    - changes of request param
      - `+ enterprise_project_id`
    - changes of response param
      - `+ ipgroups.enterprise_project_id`
  - **CreateIpGroup**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **ShowIpGroup**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **UpdateIpGroup**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **UpdateIpList**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **BatchDeleteIpList**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **ListListeners**
    - changes of response param
      - `+ listeners.insert_headers.X-Nuwa-Trace`
  - **CreateListener**
    - changes of request param
      - `+ listener.insert_headers.X-Nuwa-Trace`
    - changes of response param
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **ShowListener**
    - changes of response param
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **UpdateListener**
    - changes of request param
      - `+ listener.insert_headers.X-Nuwa-Trace`
    - changes of response param
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **ListPools**
    - changes of request param
      - `+ pool_health`
      - `+ any_port_enable`
      - `+ public_border_group`
    - changes of response param
      - `+ pools.enterprise_project_id`
      - `+ pools.pool_health`
      - `+ pools.public_border_group`
  - **CreatePool**
    - changes of request param
      - `+ pool.target_rebalance`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
    - changes of response param
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **ShowPool**
    - changes of response param
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **UpdatePool**
    - changes of request param
      - `+ pool.pool_health`
    - changes of response param
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **ListMembers**
    - changes of response param
      - `- members.pool_id`
      - `- members.device_owner`
      - `- members.device_id`
      - `- members.loadbalancer_id`
      - `- members.loadbalancers`
  - **CreateMember**
    - changes of response param
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **ShowMember**
    - changes of response param
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **UpdateMember**
    - changes of response param
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **ListAllMembers**
    - changes of response param
      - `* members: list<Member> -> list<MemberInfo>`
  - **BatchUpdateMembers**
    - changes of response param
      - `+ members.created_at`
      - `+ members.updated_at`
  - **UpdateHealthMonitor**
    - changes of request param
      - `- healthmonitor.http_method: enum value [PUT,DELETE,TRACE,OPTIONS,CONNECT,PATCH]`
  - **ListLoadBalancers**
    - changes of request param
      - `+ loadbalancer_type`
  - **CreateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
      - `+ loadbalancer.prepaid_options.promotion_info`
      - `+ loadbalancer.prepaid_options.cloud_service_console_url`
  - **ListL7Policies**
    - changes of response param
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
    - changes of request param
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
    - changes of response param
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
    - changes of response param
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
    - changes of request param
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
    - changes of response param
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

- _Features_
  - Support the APIs `ChangeVolumeChargeMode`, `UnsubscribePostpaidVolume`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListWorkflowExecutions**
    - changes of request param
      - `+ offset`

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAgencies**
    - changes of response param
      - `- agencies.duration`
  - **CreateAgency**
    - changes of response param
      - `- agency.duration`
  - **ShowAgency**
    - changes of response param
      - `- agency.duration`
  - **UpdateAgency**
    - changes of response param
      - `- agency.duration`
  - **ListRolesForGroupOnEnterpriseProject**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListPermissions**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneShowPermission**
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListDomainPermissionsForGroup**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListProjectPermissionsForGroup**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListAllProjectPermissionsForGroup**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListDomainPermissionsForAgency**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListProjectPermissionsForAgency**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListRolesForUserOnEnterpriseProject**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **CreateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: object -> list<string>`
    - changes of response param
      - `* role.policy.Statement.Resource: object -> list<string>`
  - **UpdateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: object -> list<string>`
    - changes of response param
      - `* role.policy.Statement.Resource: object -> list<string>`
  - **CreateTemporaryAccessKeyByToken**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: object -> list<string>`
  - **CreateTemporaryAccessKeyByAgency**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: object -> list<string>`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of request param
      - `+ __platform: enum value [Huawei Cloud EulerOS]`

### HuaweiCloud SDK KMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListKeys**
    - changes of response param
      - `- key_details.key_label`
  - **ListKeyDetail**
    - changes of response param
      - `- key_info.key_label`
  - **ListKmsByTags**
    - changes of response param
      - `- resources.resource_detail.key_label`

### HuaweiCloud SDK Live

- _Features_
  - Support the API `ListPlayDomainStreamInfo`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VOD

- _Features_
  - Support the API `DeleteTranscodeProduct`
- _Bug Fix_
  - None
- _Change_
  - **ShowVodStatistics**
    - changes of response param
      - `+ sample_data.storage_warm`
      - `+ sample_data.storage_cold`

# 3.1.103 2024-07-11

### HuaweiCloud SDK CCE

- _Features_
  - Support the API `ScaleNodePool`
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ metadata.ownerReference`
  - **UpdateNode**
    - changes of response param
      - `+ metadata.ownerReference`
  - **DeleteNode**
    - changes of response param
      - `+ metadata.ownerReference`
  - **CreateNode**
    - changes of request param
      - `+ metadata.ownerReference`
    - changes of response param
      - `+ metadata.ownerReference`
  - **ListNodes**
    - changes of response param
      - `+ items.metadata.ownerReference`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **UpdateNodePool**
    - changes of request param
      - `+ spec.extensionScaleGroups`
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.extensionScaleGroups`
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.extensionScaleGroups`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Deprecate the following APIs:
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
    - changes of response param
      - `- top_refer_summary.ratio`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateEvents**
    - changes of request param
      - `+ detail.dimensions`
  - **ListNotificationMasks**
    - changes of response param
      - `+ notification_masks.policies.selected_unit`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **CreateApp**
    - changes of request param
      - `+ arrange_infos.operation_list.id`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.info:gpus`
      - `+ flavors.os_extra_specs.info:asic_accelerators`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.info:gpus`
      - `+ flavors.extra_specs.info:asic_accelerators`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the following APIs:
    - `ListSupportKernelPlugins`
    - `ListKernelPlugins`
    - `SetKernelPluginLicense`
    - `InstallKernelPlugin`
    - `ListPluginExtensions`
    - `ResumePluginExtensions`
- _Bug Fix_
  - None
- _Change_
  - **RestoreInstance**
    - changes of request param
      - `- source.table_list`
      - `- source.schema_type`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreatePostPaidInstance**
    - changes of request param
      - `- kafka_manager_user`
      - `- kafka_manager_password`

### HuaweiCloud SDK Live

- _Features_
  - Support the following APIs:
    - `ShowRefererChain`
    - `SetRefererChain`
    - `DeleteRefererChain`
    - `ListHlsConfig`
    - `UpdateHlsConfig`
- _Bug Fix_
  - None
- _Change_
  - **ShowPullSourcesConfig**
    - changes of response param
      - `+ source_port`
  - **UpdatePullSourcesConfig**
    - changes of request param
      - `+ source_port`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeBankReceipt**
    - changes of request param
      - `+ page_num`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs,fcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs,fcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs,fcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs,fcs),[c6.4u16g.cluster.arm](tag:hcs,fcs),[c6.8u32g.cluster.arm](tag:hcs,fcs),[c6.16u64g.cluster.arm](tag:hcs,fcs),[c6.32u128g.cluster.arm](tag:hcs,fcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs,fcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs,fcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs,fcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs,fcs),[c6.4u16g.cluster.arm](tag:hcs,fcs),[c6.8u32g.cluster.arm](tag:hcs,fcs),[c6.16u64g.cluster.arm](tag:hcs,fcs),[c6.32u128g.cluster.arm](tag:hcs,fcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`

# 3.1.102 2024-07-04

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.url_auth.time_arg`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.url_auth.time_arg`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `ResizeStarRocksFlavor`
    - `ShowStarrocksParams`
    - `UpdateStarrocksParams`
    - `SyncStarRocksUsers`
    - `CheckStarrocksParams`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.datastore.target_version`
      - `+ instances.datastore.hotfix_finished_times`
  - **ListInstancesDetails**
    - changes of response param
      - `+ instances.datastore.target_version`
      - `+ instances.datastore.hotfix_finished_times`

### HuaweiCloud SDK KMS

- _Features_
  - Support the APIs `UpdatePrimaryRegion`, `ReplicateKey`, `ListSupportRegions`
- _Bug Fix_
  - None
- _Change_
  - **ListKeys**
    - changes of response param
      - `- key_details.partition_type`
  - **ListKeyDetail**
    - changes of response param
      - `- key_info.partition_type`
  - **ListKmsByTags**
    - changes of response param
      - `- resources.resource_detail.partition_type`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeCambodianIdCard**
    - changes of request param
      - `+ detect_border_integrity`
      - `+ detect_blocking_within_border`
      - `+ detect_blur`
      - `+ detect_glare`
      - `+ return_adjusted_image`
      - `+ detect_tampering`
    - changes of response param
      - `+ result.adjusted_image`
      - `+ result.detect_border_integrity_result`
      - `+ result.detect_blocking_within_border_result`
      - `+ result.detect_blur_result`
      - `+ result.detect_glare_result`
      - `+ result.detect_tampering_result`
      - `+ result.score_info`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **CreatePostPaidInstanceByEngine**
    - changes of request param
      - `- engine_version: enum value [3.8.35]`
  - **UpdateInstance**
    - changes of request param
      - `+ enable_acl`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- engine_version: enum value [3.8.35]`

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `CreateInstanceIam5`, `UnlockNodeReadonlyStatus`, `DeleteDisasterRecovery`, `ListFlavorsResize`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.101 2024-06-27

### HuaweiCloud SDK Core

- _Features_
  - None
- _Bug Fix_
  - Solve the problem of failed signature verification when calling some service apis.
- _Change_
  - None

### HuaweiCloud SDK AOM

- _Features_
  - Support the APIs `ListMetricOrEventAlarmRule`, `AddOrUpdateMetricOrEventAlarmRule`, `DeleteMetricOrEventAlarmRule`
- _Bug Fix_
  - None
- _Change_
  - **ListEvent2alarmRule**
    - changes of response param
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **UpdateEventRule**
    - changes of request param
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **AddEvent2alarmRule**
    - changes of request param
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **ListNotifiedHistories**
    - changes of response param
      - `* notified_histories.notifications.smn_channel.smn_notified_history.smn_subscription_status: string -> int32`
  - **CreateApp**
    - changes of request param
      - `+ register_type: enum value [CONSOLESERVICE_DISCOVERY]`
      - `- register_type: enum value [CONSOLE,SERVICE_DISCOVERY]`
  - **UpdateApp**
    - changes of request param
      - `+ register_type: enum value [CONSOLESERVICE_DISCOVERY]`
      - `- register_type: enum value [CONSOLE,SERVICE_DISCOVERY]`
  - **CreateComponent**
    - changes of request param
      - `- model_type: enum value [APPLICATION,SUB_APPLICATION]`
  - **CreateEnv**
    - changes of request param
      - `- env_type: enum value [DEV,TEST,PRE,ONLINE]`
      - `- os_type: enum value [LINUX,WINDOWS]`
      - `- register_type: enum value [API,CONSOLE,SERVICE_DISCOVERY]`
  - **ListResourceUnderNode**
    - changes of request param
      - `- ci_type: enum value [APPLICATION,SUB_APPLICATION,COMPONENT,ENVIRONMENT]`
  - **UpdateEnv**
    - changes of request param
      - `- env_type: enum value [DEV,TEST,PRE,ONLINE]`
      - `- os_type: enum value [LINUX,WINDOWS]`
      - `- register_type: enum value [API,CONSOLE,SERVICE_DISCOVERY]`

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **GetStackTemplate**
    - changes of request param
      - `+ access_control_source_ips`
      - `+ access_control_source_vpc_ids`
  - **ShowStackSetTemplate**
    - changes of request param
      - `+ access_control_source_ips`
      - `+ access_control_source_vpc_ids`
      - `+ call_identity`
  - **ShowStackInstance**
    - changes of request param
      - `+ call_identity`
  - **ShowTemplateVersionContent**
    - changes of request param
      - `+ access_control_source_vpc_ids`
      - `+ access_control_source_ips`
  - **ListStackSets**
    - changes of request param
      - `+ call_identity`
    - changes of response param
      - `+ stack_sets.permission_model: enum value [SERVICE_MANAGED]`
  - **CreateStackSet**
    - changes of request param
      - `+ call_identity`
      - `+ permission_model: enum value [SERVICE_MANAGED]`
  - **ListStackSetOperations**
    - changes of request param
      - `+ call_identity`
  - **ShowStackSetMetadata**
    - changes of request param
      - `+ call_identity`
    - changes of response param
      - `+ organizational_unit_ids`
      - `+ permission_model: enum value [SERVICE_MANAGED]`
  - **ListStackInstances**
    - changes of request param
      - `+ call_identity`
  - **CreateStackInstance**
    - changes of request param
      - `+ call_identity`
  - **DeleteStackInstanceDeprecated**
    - changes of request param
      - `+ call_identity`
  - **UpdateStackInstances**
    - changes of request param
      - `+ call_identity`
  - **DeleteStackInstance**
    - changes of request param
      - `+ call_identity`
  - **DeployStackSet**
    - changes of request param
      - `+ call_identity`
      - `- var_overrides`
  - **DeleteStackSet**
    - changes of request param
      - `+ call_identity`
  - **UpdateStackSet**
    - changes of request param
      - `+ call_identity`
      - `- permission_model`
  - **ShowStackSetOperationMetadata**
    - changes of request param
      - `+ call_identity`

### HuaweiCloud SDK CFW

- _Features_
  - Support the following APIs:
    - `CreateTag`
    - `DeleteTag`
    - `ListCaptureTask`
    - `CreateCaptureTask`
    - `DeleteCaptureTask`
    - `ListCaptureResult`
    - `CancelCaptureTask`
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of request param
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
      - `+ protocol: enum value [6,17,1,58]`
    - changes of response param
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
  - **ListAccessControlLogs**
    - changes of request param
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
    - changes of response param
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
  - **ListBlackWhiteLists**
    - changes of request param
      - `+ address_type: enum value [0,1,2]`
    - changes of response param
      - `- data.object_id`
  - **AddServiceSet**
    - changes of response param
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **ListDomainParseDetail**
    - changes of request param
      - `* address_type: string -> int32`
  - **UpdateDnsServers**
    - changes of request param
      - `* fw_instance_id: optional -> required`
  - **ListDnsServers**
    - changes of request param
      - `* fw_instance_id: optional -> required`
  - **ChangeIpsSwitchStatus**
    - changes of response param
      - `- trace_id`
  - **ListAttackLogs**
    - changes of request param
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
      - `- source`
      - `+ protocol: enum value [6,17,1,58]`
      - `+ action: enum value [0,1]`
      - `+ direction: enum value [0,1]`
    - changes of response param
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
    - changes of request param
      - `- list_type`
      - `- object_id`
  - **ChangeIpsProtectMode**
    - changes of response param
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **UpdateServiceSet**
    - changes of response param
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **ListServiceItems**
    - changes of response param
      - `- data.records.name`
  - **AddServiceItems**
    - changes of request param
      - `- service_items.item_id`
      - `- service_items.name`
    - changes of response param
      - `- data.items.name`
      - `* data.items: list<IdObject> -> list<object>`
  - **CreateFirewall**
    - changes of request param
      - `- X-Trace-Id`
  - **UpdateAddressSet**
    - changes of request param
      - `- address_type`
  - **UpdateDomainSet**
    - changes of request param
      - `* fw_instance_id: optional -> required`
      - `- set_id`
      - `- domain_set_type`
  - **ListProtectedVpcs**
    - changes of response param
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
    - changes of response param
      - `+ data.er`
      - `+ data.inspertion_vpc`
      - `- data.name`
      - `* data: object<IdObject> -> object<CreateEWFirewallResp>`
  - **ListEastWestFirewall**
    - changes of request param
      - `* fw_instance_id: optional -> required`
    - changes of response param
      - `+ data.er.attachment_id`
  - **AddAclRule**
    - changes of request param
      - `- rules.profile`
      - `+ rules.source.address_group`
      - `* rules.service.service_group_names: list<AddressGroupVO> -> list<ServiceGroupVO>`
  - **UpdateAclRule**
    - changes of request param
      - `- profile`
      - `+ source.address_group_names.address_set_type`
      - `- source.address_group_names.protocols`
      - `- source.address_group_names.service_set_type`
  - **ListAclRules**
    - changes of request param
      - `- protocol`
    - changes of response param
      - `- data.records.sequence`
      - `- data.records.source.predefined_group`
      - `+ data.records.source.address_group_names.address_set_type`
      - `- data.records.source.address_group_names.protocols`
      - `- data.records.source.address_group_names.service_set_type`
      - `* data.records.source: object<RuleAddressDto> -> object<RuleAddressDtoForResponse>`
      - `- data.records.service.predefined_group`
      - `* data.records.service: object<RuleServiceDto> -> object<RuleServiceDtoForResponse>`
  - **ListServiceSets**
    - changes of response param
      - `- data.records.status`
  - **ListDomains**
    - changes of request param
      - `- description`
      - `- set_id`
  - **ListFirewallDetail**
    - changes of response param
      - `- data.records.flavor.session_concurrent`
      - `- data.records.flavor.session_create`
      - `- data.records.flavor.total_rule_count`
      - `- data.records.flavor.used_rule_count`
      - `- data.records.flavor.vpc_bandwith`
  - **ListFirewallList**
    - changes of response param
      - `- data.records.flavor.session_concurrent`
      - `- data.records.flavor.session_create`
      - `- data.records.flavor.total_rule_count`
      - `- data.records.flavor.used_rule_count`
      - `- data.records.flavor.vpc_bandwith`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.is_open_fast_clean`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.is_open_fast_clean`
  - **ShowDbObjectTemplateResult**
    - changes of request param
      - `+ file_export_object_level`
  - **DownloadDbObjectTemplate**
    - changes of request param
      - `+ file_import_db_level: enum value [column]`
  - **UploadDbObjectTemplate**
    - changes of request param
      - `+ file_import_db_level: enum value [column]`
  - **ShowDbObjectTemplateProgress**
    - changes of request param
      - `+ type`
  - **ShowSupportObjectType**
    - changes of response param
      - `+ is_import_cloumn`
  - **ShowReplayResults**
    - changes of request param
      - `+ is_sample`
      - `+ error_type`
      - `+ sql_template_md5`
      - `+ type: enum value [error_classification]`
    - changes of response param
      - `+ error_classifications`
      - `+ slow_sql_templates.sql_template_md5`
      - `+ error_sql_templates.sql_template_md5`
  - **CreateJob**
    - changes of request param
      - `+ job.base_info.is_open_fast_clean`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.base_info.is_open_fast_clean`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.base_info.is_open_fast_clean`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.params.base_info.is_open_fast_clean`
      - `+ jobs.params.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.base_info.is_open_fast_clean`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **UpdateJob**
    - changes of request param
      - `+ job.params.base_info.is_open_fast_clean`
      - `+ job.params.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [set_readonly]`
      - `+ job.action_params.endpoints.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [set_readonly]`
      - `+ jobs.action_params.endpoints.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.network_interface:traffic_mirroring_supported`
      - `+ flavors.os_extra_specs.security:enclave_supported`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.network_interface:traffic_mirroring_supported`
      - `+ flavors.extra_specs.security:enclave_supported`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListQuotas**
    - changes of response param
      - `+ quotas.resources.type: enum value [fgs_on_demand_instance_limit,fgs_func_qos_limit]`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the following APIs:
    - `SetNewBackupPolicy`
    - `ListInstanceDetails`
    - `ShowBatchUpgradeCandidateVersions`
    - `UpgradeInstancesVersion`
    - `ConfirmRestoredData`
- _Bug Fix_
  - None
- _Change_
  - **CreateInstance**
    - changes of request param
      - `- replica_num: enum value [2]`
  - **CreateDbInstance**
    - changes of request param
      - `- replica_num: enum value [2]`

### HuaweiCloud SDK VPC

- _Features_
  - Support the following APIs:
    - `CountPortsByTags`
    - `ListPortsByTags`
    - `ShowPortTags`
    - `CreatePortTag`
    - `ListPortTags`
    - `BatchCreatePortTags`
    - `DeletePortTag`
    - `BatchDeletePortTags`
- _Bug Fix_
  - None
- _Change_
  - **ListFirewallTags**
    - changes of request param
      - `+ limit`
      - `+ offset`
    - changes of response param
      - `+ total_count`
      - `* tags: object<ListTag> -> list<ListTag>`
  - **ShowFirewallTags**
    - changes of response param
      - `- sys_tags`
      - `* tags: object<ResourceTag> -> list<ResourceTag>`
  - **BatchDeleteFirewallTags**
    - changes of request param
      - `* tags: list<ResourceTag> -> list<DeleteResourceTagRequestBody>`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateEndpointService**
    - changes of response param
      - `+ ip_version`
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ ipv6_address`
  - **CreateEndpointService**
    - changes of request param
      - `+ ip_version`
      - `- enable_policy`
    - changes of response param
      - `+ ip_version`
  - **CreateEndpoint**
    - changes of request param
      - `+ policy_statement`
      - `+ ip_version`
      - `+ ipv6_address`
    - changes of response param
      - `+ ipv6_address`
  - **ListEndpoints**
    - changes of request param
      - `- public_border_group`

# 3.1.100 2024-06-20

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowConnectorTask**
    - changes of response param
      - `- sink_task.connector_class`
      - `- sink_task.storage_class`
      - `- sink_task.format_class`
  - **CreateConnectorTask**
    - changes of response param
      - `- sink_task.connector_class`
      - `- sink_task.storage_class`
      - `- sink_task.format_class`
  - **ListConnectorTasks**
    - changes of response param
      - `- tasks.sink_task.connector_class`
      - `- tasks.sink_task.storage_class`
      - `- tasks.sink_task.format_class`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateAudioStreamModerationJob**
    - changes of request param
      - `+ data.language`
  - **RunCreateAudioModerationJob**
    - changes of request param
      - `+ data.language`

# 3.1.99 2024-06-13

### HuaweiCloud SDK Core

- _Features_
  - Support retry for request.
- _Bug Fix_
  - None
- _Change_
  - Add non-null check to method SetAk/SetSk of Credentials.

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingV2Policy**
    - changes of request param
      - `+ interval_alarm_actions`
  - **ListAllScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.interval_alarm_actions`
  - **UpdateScalingV2Policy**
    - changes of request param
      - `+ interval_alarm_actions`
  - **ShowScalingV2Policy**
    - changes of response param
      - `+ scaling_policy.interval_alarm_actions`
  - **ListScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.interval_alarm_actions`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateMigrationTask**
    - changes of request param
      - `+ target_instance.task_status`
  - **ShowMigrationTask**
    - changes of response param
      - `+ target_instance.task_status`
  - **StopMigrationTask**
    - changes of response param
      - `+ target_instance.task_status`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowServer**
    - changes of response param
      - `- server.fault.code`
      - `- server.fault.created`
      - `- server.fault.message`
      - `- server.fault.details`
      - `* server.fault: object<ServerFault> -> object`
  - **ListServersDetails**
    - changes of response param
      - `- servers.fault.code`
      - `- servers.fault.created`
      - `- servers.fault.message`
      - `- servers.fault.details`
      - `* servers.fault: object<ServerFault> -> object`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DisassociatePublicips**
    - changes of response param
      - `- publicip.associate_instance_type: enum value [null]`
  - **AssociatePublicips**
    - changes of response param
      - `- publicip.associate_instance_type: enum value [null]`
  - **UpdatePublicip**
    - changes of request param
      - `+ publicip.associate_instance_type: enum value [VPN]`
      - `- publicip.associate_instance_type: enum value []`
    - changes of response param
      - `- publicip.associate_instance_type: enum value [null]`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDedicatedResourceInfo**
    - changes of response param
      - `+ resource_name`
      - `- name`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowReplayDelayStatus**
    - changes of response param
      - `+ delay_time_value_range`

### HuaweiCloud SDK VPC

- _Features_
  - Support the following APIs:
    - `ListSecurityGroupsByTags`
    - `BatchCreateSecurityGroupTags`
    - `BatchDeleteSecurityGroupTags`
    - `ShowSecurityGroupTags`
    - `CreateSecurityGroupTag`
    - `DeleteSecurityGroupTag`
    - `ListSecurityGroupTags`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.98 2024-06-06

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **UpdateNode**
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **DeleteNode**
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **CreateNode**
    - changes of request param
      - `+ spec.serverEnterpriseProjectID`
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.serverEnterpriseProjectID`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **UpdateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.serverEnterpriseProjectID`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ChangeVpc**
    - changes of request param
      - `* nic.security_groups: object<ChangeVpcSecurityGroups> -> list<ChangeVpcSecurityGroups>`
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.cond:storage:type`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.cond:storage:type`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **ShowProxyIpgroup**
    - changes of response param
      - `+ ip_group.id`
      - `+ ip_group.name`
      - `+ ip_group.ip_list`
      - `* ip_group: object -> object<ProxyIpGroupDetail>`
  - **UpdateGaussMySqlInstanceName**
    - changes of request param
      - `+ is_modify_node_name`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **OfflineNodes**
    - changes of response param
      - `+ job_id`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAvailableFlavors**
    - changes of response param
      - `+ flavors.spec_code`
      - `- flavors.spec_cpde`
  - **ListRestorableInstances**
    - changes of response param
      - `* instances.version: number -> string`
  - **ListDbUsers**
    - changes of response param
      - `+ users.attribute`
      - `+ users.lock_status`
      - `- users.attributes`
  - **ShowUpgradeCandidateVersions**
    - changes of response param
      - `+ hotfix_upgrade_infos`
      - `+ hotfix_rollback_infos`

### HuaweiCloud SDK ImageSearch

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunSearch**
    - changes of request param
      - `+ text`
      - `+ search_type: enum value [TEXT]`
      - `+ optional_params.text_lang`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLogStreamIndex**
    - changes of request param
      - `+ sqlAnalysisEnable`

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `ShowReplayDelayStatus`, `SwitchLogReplay`, `ListShareBackups`
- _Bug Fix_
  - None
- _Change_
  - **ListBackups**
    - changes of request param
      - `+ status`

# 3.1.97 2024-05-30

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowHistoryTaskDetails**
    - changes of response param
      - `+ urls.fail_classify`
      - `+ urls.fail_desc`
  - **ListDomains**
    - changes of response param
      - `+ domains.sources.obs_bucket_type`
  - **CreateDomain**
    - changes of request param
      - `+ domain.sources.obs_bucket_type`
      - `* domain.sources: list<Sources> -> list<SourcesRequestBody>`
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **DeleteDomain**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **EnableDomain**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **DisableDomain**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.access_area_filter`
      - `* configs.sources: list<SourcesConfig> -> list<SourcesConfigResponseBody>`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.access_area_filter`

### HuaweiCloud SDK ECS

- _Features_
  - Support the API `ChangeServerNetworkInterface`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the APIs `UpgradeProxyVersion`, `UpdateProxyName`, `ShowProxyIpgroup`, `ShowProxyVersion`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **SearchAutoEnlargePolicy**
    - changes of response param
      - `+ step_percent`
      - `+ step_size`
  - **UpdateInstanceConfiguration**
    - changes of response param
      - `+ job_id`
  - **CreateConfigurationTemplate**
    - changes of request param
      - `+ datastore.instance_mode: enum value [ha:readonly]`
  - **ListDatabases**
    - changes of response param
      - `+ databases.datctype`
      - `+ databases.compatibility_type`
  - **ListTasks**
    - changes of response param
      - `+ tasks.created_at`
      - `+ tasks.ended_at`
  - **ListComponentInfos**
    - changes of response param
      - `+ nodes.components.type`
      - `+ nodes.components.detail`
  - **ShowUpgradeCandidateVersions**
    - changes of response param
      - `+ upgrade_type_list.is_parallel_upgrade`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
    - `ListBridges`
    - `AddBridge`
    - `DeleteBridge`
    - `ResetBridgeSecret`
    - `ListDeviceGroupsByDevice`
    - `UpdateCertificate`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPC

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **ListSecurityGroups**
    - changes of response param
      - `+ security_groups.tags`
  - **CreateSecurityGroup**
    - changes of request param
      - `+ security_group.tags`
    - changes of response param
      - `+ security_group.tags`
  - **ShowSecurityGroup**
    - changes of response param
      - `+ security_group.tags`
  - **UpdateSecurityGroup**
    - changes of response param
      - `+ security_group.tags`
  - **CreateFirewall**
    - changes of request param
      - `+ firewall.tags`

# 3.1.96 2024-05-23

### HuaweiCloud SDK Organizations

- _Features_
  - Support `Organizations`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingGroup**
    - changes of request param
      - `+ tags`
  - **ListScalingGroups**
    - changes of response param
      - `+ scaling_groups.tags`
  - **ShowScalingGroup**
    - changes of response param
      - `+ scaling_group.tags`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the APIs `ShowRedisBigKeys`, `ShowPasswordlessConfig`, `UpdatePasswordlessConfig`
- _Bug Fix_
  - None
- _Change_
  - **OfflineNodes**
    - changes of request param
      - `* x-auth-token: optional -> required`

### HuaweiCloud SDK RDS

- _Features_
  - Support the API `DownloadErrorlog`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.95 2024-05-16

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Deprecate the APIs `UpdateDomainFullConfig`, `ShowDomainFullConfig`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.https.enc_certificate_value`
      - `+ configs.https.certificates`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.https.enc_certificate_value`
      - `+ configs.https.enc_private_key`
      - `+ configs.https.certificates`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListClients**
    - changes of response param
      - `* clients.idle: string -> int32`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the API `RestoreInstance`
- _Bug Fix_
  - None
- _Change_
  - **CreateDbInstance**
    - changes of request param
      - `+ enable_single_float_ip`

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListCustomPolicies**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **CreateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: list<string> -> object`
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **ShowCustomPolicy**
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **UpdateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: list<string> -> object`
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **CreateTemporaryAccessKeyByToken**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: list<string> -> object`
  - **CreateTemporaryAccessKeyByAgency**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: list<string> -> object`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListLogs**
    - changes of request param
      - `+ __time__`
  - **ListStructuredLogsWithTimeRange**
    - changes of request param
      - `* time_range.start_time: string -> int64`
      - `* time_range.end_time: string -> int64`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ pdf_page_number`

# 3.1.94 2024-05-09

### HuaweiCloud SDK DRS

- _Features_
  - Support the following APIs:
    - `ListObejectLevelCompareOverview`
    - `CreateObjectLevelCompareJob`
    - `ListObejectLevelCompareDetail`
    - `ListContentCompareDifference`
    - `DownloadCompareResultFile`
    - `CreateCompareResultFile`
    - `ShowHealthCompareJobDetail`
    - `ShowHealthObjectCompareJobOverview`
    - `UpdateComparePolicy`
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.source_endpoint.kafka_security_config`
  - **BatchValidateConnections**
    - changes of request param
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
    - changes of response param
      - `+ jobs.children.job_direction: enum value [no-dbs]`
      - `- jobs.children.job_direction: enum value [non-dbs]`
  - **BatchUpdateJob**
    - changes of request param
      - `+ jobs.source_endpoint.kafka_security_config`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.source_endpoint.kafka_security_config`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.is_writable`
      - `+ jobs.compare_result.content_diff_detail_info`
      - `+ jobs.compare_result.content_compare_overview_infos.status: enum value [WAIT_FOR_COMPARE,CANCELED]`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.type: enum value [notify]`
  - **ShowJobDetail**
    - changes of request param
      - `+ type: enum value [is_writable,cloud_connection]`
    - changes of response param
      - `+ job.is_writable`
      - `+ job.compare_result.content_diff_detail_info`
      - `+ job.compare_result.content_compare_overview_infos.status: enum value [WAIT_FOR_COMPARE,CANCELED]`
  - **UpdateJob**
    - changes of request param
      - `+ job.type: enum value [notify]`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [set_writable,cloud_connection]`
      - `+ job.action_params.replay_config`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [set_writable,cloud_connection]`
      - `+ jobs.action_params.replay_config`

### HuaweiCloud SDK ECS

- _Features_
  - Support the API `ChangeVpc`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateFunctionCode**
    - changes of request param
      - `- depend_list`
  - **CreateFunction**
    - changes of request param
      - `+ gpu_type`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `ListStarRocksDataReplications`
    - `CreateStarRocksDataReplication`
    - `DeleteStarRocksDataReplication`
    - `CheckDataBaseConfig`
    - `CheckTableConfig`
    - `ListStarRocksDataReplicationConfig`
    - `ListStarRocksDbParameters`
    - `ListStarRocksDataBases`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK MPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateTranscodingTask**
    - changes of request param
      - `+ video_process.hls_segment_type`

# 3.1.93 2024-04-30

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **EstimateExecutionPlanPrice**
    - changes of response param
      - `- currency: enum value [CNY,USD]`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `+ product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
  - **ShowInstance**
    - changes of response param
      - `+ available_zone_names`
      - `+ enterprise_project_id`
  - **CreateTopicOrBatchDeleteTopic**
    - changes of request param
      - `+ queues`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
  - **ListInstances**
    - changes of response param
      - `+ available_zone_names`
      - `+ enterprise_project_id`
      - `+ instances.available_zone_names`
      - `+ instances.enterprise_project_id`

# 3.1.92 2024-04-25

### HuaweiCloud SDK AAD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowUnblockRecord**
    - changes of response param
      - `* unblock_record.block_id: string -> int64`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDeployTaskDetail**
    - changes of response param
      - `+ is_disable`
      - `+ can_disable`
  - **ListDeployTasks**
    - changes of response param
      - `+ is_disable`
      - `+ can_disable`
      - `+ result.can_disable`
      - `+ result.is_disable`
  - **ListAllApp**
    - changes of response param
      - `+ result.is_disable`
      - `+ result.can_disable`
  - **ShowAppDetailById**
    - changes of response param
      - `+ result.is_disable`
      - `+ result.can_disable`
      - `+ result.arrange_infos.can_disable`
      - `+ result.arrange_infos.is_disable`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateMigrationTask**
    - changes of request param
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
    - changes of response param
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
    - changes of response param
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

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.availability_zone`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
    - `ListDeviceProxies`
    - `CreateDeviceProxy`
    - `ShowDeviceProxy`
    - `UpdateDeviceProxy`
    - `DeleteDeviceProxy`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateVideoModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateAudioStreamModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateDocumentModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateVideoStreamModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateAudioModerationJob**
    - changes of request param
      - `+ seed`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizeBankReceipt`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeBusinessLicense**
    - changes of response param
      - `+ result.organization_form`
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ formula`
    - changes of response param
      - `+ result.formula_result`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **ShowFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **UpdateFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **UpdateFirewallRules**
    - changes of request param
      - `+ firewall.ingress_rules.enabled`
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **AddFirewallRules**
    - changes of request param
      - `+ firewall.ingress_rules.enabled`
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **RemoveFirewallRules**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **AssociateSubnetFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **DisassociateSubnetFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`

# 3.1.91 2024-04-18

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEvents**
    - changes of request param
      - `+ Enterprise-Project-Id`
  - **CountEvents**
    - changes of response param
      - `+ summary`
  - **UpdateAlarmRule**
    - changes of request param
      - `+ period: enum value [3600000]`
      - `- period: enum value [36000000]`
  - **AddAlarmRule**
    - changes of request param
      - `+ period: enum value [3600000]`
      - `- period: enum value [36000000]`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMigrationTask**
    - changes of response param
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
    - changes of response param
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
    - changes of response param
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
    - changes of response param
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
    - changes of response param
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

- _Features_
  - Support the APIs `ListTopIoTraffics`, `ShowErrorLogSwitchStatus`, `ListInstanceErrorLogs`, `DeleteInstanceTag`
- _Bug Fix_
  - None
- _Change_
  - Remove the API `ShowInstancesStatistics`
  - **UpgradeInstanceVersion**
    - changes of request param
      - `+ upgrade_action`
      - `- upgrde_action`
      - `- is_parallel_upgrade`
  - **ShowBackupPolicy**
    - changes of response param
      - `* backup_policy.differential_period: string -> int32`

### HuaweiCloud SDK TMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeleteResourceTag**
    - changes of request param
      - `+ tags.value`

# 3.1.90 2024-04-11

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowStackSetMetadata**
    - changes of response param
      - `+ managed_operation`
  - **UpdateStackSet**
    - changes of request param
      - `+ managed_operation`
  - **CreateStackSet**
    - changes of request param
      - `+ managed_operation`
  - **CreateStackInstance**
    - changes of request param
      - `+ operation_preferences`
  - **DeleteStackInstanceDeprecated**
    - changes of request param
      - `+ operation_preferences`
  - **UpdateStackInstances**
    - changes of request param
      - `+ operation_preferences`
  - **DeleteStackInstance**
    - changes of request param
      - `+ operation_preferences`
  - **DeployStackSet**
    - changes of request param
      - `+ operation_preferences`
  - **ShowStackSetOperationMetadata**
    - changes of response param
      - `+ operation_preferences`

### HuaweiCloud SDK CDN

- _Features_
  - Support the API `ShowQuota`
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.sni`
      - `+ configs.request_url_rewrite`
      - `+ configs.browser_cache_rules`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.sni`
      - `+ configs.request_url_rewrite`
      - `+ configs.browser_cache_rules`

### HuaweiCloud SDK DRS

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **ShowDataFilteringResult**
    - changes of response param
      - `+ db_object_filtering_result.source`
      - `+ db_object_filtering_result.target_result`
      - `+ db_object_filtering_result.source_result`
      - `+ db_object_filtering_result.target_message`
      - `+ db_object_filtering_result.source_message`
  - **ShowDataProgress**
    - changes of response param
      - `+ data_process_info.source`
  - **UpdateDataProgress**
    - changes of request param
      - `+ data_process_info.source`
  - **CheckDataFilter**
    - changes of request param
      - `+ data_process_info.source`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_params.compare_task_param.data_process_info`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_params.compare_task_param.data_process_info`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the following APIs:
    - `ShowInstancesStatistics`
    - `ShowSlowLogDownload`
    - `CreateSlowLogDownload`
    - `UpgradeInstanceVersion`
    - `SearchAutoEnlargePolicy`
    - `ListCnInfosBeforeReduce`
    - `StartInstance`
    - `ShowUpgradeCandidateVersions`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `* engine: optional -> required`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the API `BatchListAssociatedIssues`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstancesDetails**
    - changes of request param
      - `* engine: optional -> required`
      - `+ engine: enum value [rabbitmq]`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowReplayDelayStatus`, `SwitchLogReplay`
  - **StartResizeFlavorAction**
    - changes of request param
      - `+ resize_flavor.is_delay`
  - **ListPostgresqlDatabases**
    - changes of request param
      - `+ db`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `* engine: optional -> required`
      - `+ engine: enum value [rocketmq]`
      - `+ engine: enum value [reliability]`

### HuaweiCloud SDK SWR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSharedReposDetails**
    - changes of request param
      - `* center: optional -> required`

# 3.1.89 2024-04-03

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of request param
      - `+ src_region_name`
      - `+ dst_region_name`
    - changes of response param
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
  - **ListAccessControlLogs**
    - changes of request param
      - `+ src_region_name`
      - `+ dst_region_name`
  - **ListAddressSets**
    - changes of request param
      - `+ address_set_type`
  - **ListAttackLogs**
    - changes of request param
      - `+ attack_rule_id`
      - `+ src_region_name`
      - `+ dst_region_name`
  - **UpdateAclRuleOrder**
    - changes of request param
      - `+ bottom`
  - **ListServiceSetDetail**
    - changes of request param
      - `+ query_service_set_type`
  - **AddAclRule**
    - changes of request param
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
    - changes of request param
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
    - changes of request param
      - `+ application`
    - changes of response param
      - `+ data.records.sequence.bottom`
      - `+ data.records.source.address_set_type`
      - `+ data.records.source.predefined_group`
      - `+ data.records.source.address_group_names.protocols`
      - `+ data.records.source.address_group_names.service_set_type`
      - `+ data.records.service.protocols`
      - `+ data.records.service.predefined_group`
      - `+ data.records.service.service_set_type`
  - **ListServiceItems**
    - changes of request param
      - `+ query_service_set_type`
  - **ListAddressItems**
    - changes of request param
      - `+ query_address_set_type`
  - **ListServiceSets**
    - changes of request param
      - `+ query_service_set_type`
  - **ListDomainSets**
    - changes of response param
      - `+ data.records.rules`
  - **ListFirewallDetail**
    - changes of request param
      - `+ name`
    - changes of response param
      - `+ data.records.tags`
      - `+ data.records.flavor.default_bandwidth`
      - `+ data.records.flavor.default_eip_count`
      - `+ data.records.flavor.default_log_storage`
      - `+ data.records.flavor.default_vpc_count`
  - **ListFirewallList**
    - changes of response param
      - `+ data.records.tags`
      - `+ data.records.flavor.default_bandwidth`
      - `+ data.records.flavor.default_eip_count`
      - `+ data.records.flavor.default_log_storage`
      - `+ data.records.flavor.default_vpc_count`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowServerAutoRecovery`, `RegisterServerAutoRecovery`
  - **ResizePostPaidServer**
    - changes of request param
      - `+ resize.cpu_options`
  - **ShowServer**
    - changes of response param
      - `+ server.cpu_options.hw:cpu_threads: enum value [1,2]`
  - **ListServersDetails**
    - changes of response param
      - `+ servers.cpu_options.hw:cpu_threads: enum value [1,2]`
  - **ChangeServerOsWithCloudInit**
    - changes of request param
      - `+ os-change.isAutoPay`
  - **ChangeServerOsWithoutCloudInit**
    - changes of request param
      - `+ os-change.isAutoPay`
  - **ResizeServer**
    - changes of request param
      - `+ resize.cpu_options`
  - **CreateServers**
    - changes of request param
      - `+ server.cpu_options`
  - **CreatePostPaidServers**
    - changes of request param
      - `+ server.cpu_options`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTenantVpcIgws**
    - changes of request param
      - `+ offset`
      - `+ marker`
  - **ListProjectGeipBindings**
    - changes of request param
      - `+ offset`
      - `+ marker`
    - changes of response param
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

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDependencyVersion**
    - changes of request param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowDependencyVersion**
    - changes of response param
      - `+ is_shared`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListDependencies**
    - changes of response param
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListDependencyVersion**
    - changes of response param
      - `+ dependencies.is_shared`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowFunctionCode**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionCode**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ImportFunction**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListFunctions**
    - changes of response param
      - `+ functions.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **CreateFunction**
    - changes of request param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0,Custom Image]`
    - changes of response param
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowFunctionConfig**
    - changes of response param
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionConfig**
    - changes of request param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0,Custom Image]`
    - changes of response param
      - `+ enable_cloud_debug`
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionMaxInstanceConfig**
    - changes of response param
      - `+ is_return_stream`
      - `+ enable_cloud_debug`
      - `+ enable_auth_in_header`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListBridgeFunctions**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListStatistics**
    - changes of response param
      - `+ gpu_gbs`
  - **CreateFunctionVersion**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListFunctionVersions**
    - changes of response param
      - `- versions.enable_cloud_debug`
      - `+ versions.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`

### HuaweiCloud SDK GEIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CountGlobalEips**
    - changes of response param
      - `+ global_eip`
      - `- global_eips`
      - `- page_info`
  - **BatchCreateGlobalEip**
    - changes of response param
      - `+ global_eips`
      - `- global_eip`
  - **CountGlobalEipSegment**
    - changes of response param
      - `+ global_eip_segment`
      - `- global_eip_segments`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowConnectorTask**
    - changes of response param
      - `+ topics_regex`
  - **CreateConnectorTask**
    - changes of response param
      - `+ topics_regex`
  - **ListConnectorTasks**
    - changes of response param
      - `+ topics_regex`
      - `+ tasks.topics_regex`

### HuaweiCloud SDK KMS

- _Features_
  - Support the APIs `GenerateMac`, `VerifyMac`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `ShowReplayDelayStatus`, `SwitchLogReplay`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateConsumerGroup**
    - changes of request param
      - `- from_beginning`
  - **ListMessageTrace**
    - changes of response param
      - `+ trace.trace_type: enum value [SubBefore,SubAfter]`
      - `- trace.trace_type: enum value [Sub]`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `* max: number -> int32`
      - `* remaining: number -> int32`
      - `* next_offset: number -> int32`
      - `* previous_offset: number -> int32`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSubNetworkInterfaces**
    - changes of response param
      - `+ sub_network_interfaces.security_enabled`
  - **CreateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.security_enabled`
  - **BatchCreateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interfaces.security_enabled`
  - **ShowSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.security_enabled`
  - **UpdateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.security_enabled`
  - **MigrateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interfaces.security_enabled`

# 3.1.88 2024-04-01

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBareMetalServers**
    - changes of response param
      - `- servers.image.name`
      - `- servers.image.__os_type`
      - `- servers.image.links`
  - **ListBareMetalServerDetails**
    - changes of response param
      - `- server.image.name`
      - `- server.image.__os_type`
      - `- server.image.links`

### HuaweiCloud SDK KPS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateKeypair**
    - changes of request param
      - `+ keypair.key_protection.encryption.kms_key_id`
  - **ImportPrivateKey**
    - changes of request param
      - `+ keypair.key_protection.encryption.kms_key_id`
    - changes of response param
      - `+ keypair.key_protection.encryption.kms_key_id`

# 3.1.87 2024-03-28

### HuaweiCloud SDK CBR

- _Features_
  - Support the following APIs:
    - `ListOrganizationPolicies`
    - `CreateOrganizationPolicy`
    - `ShowOrganizationPolicy`
    - `UpdateOrganizationPolicy`
    - `DeleteOrganizationPolicy`
    - `ListOrganizationPolicyDetail`
- _Bug Fix_
  - None
- _Change_
  - **ShowBackup**
    - changes of response param
      - `+ backup.incremental`
      - `- backup.extend_info.incremental`
  - **UpdateBackup**
    - changes of response param
      - `+ backup.incremental`
      - `- backup.extend_info.incremental`
  - **ListBackups**
    - changes of response param
      - `+ backups.incremental`
      - `- backups.extend_info.incremental`
  - **ListVault**
    - changes of response param
      - `- sys_lock_source_service`
  - **CreateVault**
    - changes of request param
      - `+ vault.sys_lock_source_service`
  - **ListExternalVault**
    - changes of response param
      - `- sys_lock_source_service`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNodePoolConfigurationDetails**
    - changes of response param
      - `- kubelet`
  - **ShowClusterConfigurationDetails**
    - changes of response param
      - `- kube-apiserver`
  - **ShowCluster**
    - changes of response param
      - `- spec.enableAutopilot`
  - **UpdateCluster**
    - changes of response param
      - `- spec.enableAutopilot`
  - **DeleteCluster**
    - changes of request param
      - `+ lts_reclaim_policy`
    - changes of response param
      - `- spec.enableAutopilot`
  - **CreateCluster**
    - changes of request param
      - `- spec.enableAutopilot`
    - changes of response param
      - `- spec.enableAutopilot`
  - **ListClusters**
    - changes of response param
      - `- items.spec.enableAutopilot`

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of response param
      - `* data.records.bytes: int32 -> double`

### HuaweiCloud SDK CTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateTracker**
    - changes of request param
      - `+ agency_name`
  - **CreateTracker**
    - changes of request param
      - `+ agency_name`
    - changes of response param
      - `+ agency_name`
  - **ListTrackers**
    - changes of response param
      - `+ trackers.agency_name`
  - **UpdateNotification**
    - changes of request param
      - `+ agency_name`
    - changes of response param
      - `+ agency_name`
  - **CreateNotification**
    - changes of request param
      - `+ agency_name`
    - changes of response param
      - `+ agency_name`
  - **ListNotifications**
    - changes of response param
      - `+ notifications.agency_name`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunImageMediaTagging**
    - changes of request param
      - `- use_default_tags`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the API `UpdateApplication`
- _Bug Fix_
  - None
- _Change_
  - **CreateBatchTask**
    - changes of request param
      - `+ task_mode`
      - `+ task_ext_info`
    - changes of response param
      - `+ task_ext_info`
      - `+ task_mode`
  - **ListBatchTasks**
    - changes of response param
      - `+ task_ext_info`
      - `+ task_mode`
      - `+ batchtasks.task_mode`
      - `+ batchtasks.task_ext_info`
  - **ShowBatchTask**
    - changes of response param
      - `+ task_ext_info`
      - `+ task_mode`
      - `+ batchtask.task_mode`
      - `+ batchtask.task_ext_info`
  - **CreateOtaPackage**
    - changes of request param
      - `+ file_location.obs_location.sign`
    - changes of response param
      - `+ file_location.obs_location.sign`
  - **ShowOtaPackage**
    - changes of response param
      - `+ file_location.obs_location.sign`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the following APIs:
    - `ShowDiagnosisPreCheck`
    - `ListMessageDiagnosisReports`
    - `CreateMessageDiagnosisTask`
    - `BatchDeleteMessageDiagnosisReports`
    - `ShowMessageDiagnosisReport`
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ ipv6_enable`
  - **ShowInstance**
    - changes of response param
      - `+ broker_ssl_enable`
      - `+ new_auth_cert`
      - `+ available_zone_names`
  - **ShowConnectorTask**
    - changes of response param
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- ipv6_enable`
  - **ListInstances**
    - changes of response param
      - `+ broker_ssl_enable`
      - `+ new_auth_cert`
      - `+ available_zone_names`
      - `+ instances.broker_ssl_enable`
      - `+ instances.available_zone_names`
      - `+ instances.new_auth_cert`
  - **CreateConnectorTask**
    - changes of request param
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
    - changes of response param
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
  - **ListConnectorTasks**
    - changes of response param
      - `+ tasks.source_task.rename_topic_enabled`
      - `- tasks.source_task.rename_topic_enable`
  - **CreateReassignmentTask**
    - changes of request param
      - `+ time_estimate`
    - changes of response param
      - `+ reassignment_time`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeMvsInvoice**
    - changes of response param
      - `+ result.reverse_issue`
  - **RecognizeThailandLicensePlate**
    - changes of response param
      - `+ result.province`

### HuaweiCloud SDK RDS

- _Features_
  - Support the API `BatchStopInstance`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMessageTrace**
    - changes of response param
      - `* trace.retry_times: string -> int32`
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [4.8.0]`
      - `+ product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.2u8g.single.arm](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
      - `- product_id: enum value [c6.4u8g.cluster.small,c6.4u8g.cluster,c6.8u16g.cluster,c6.12u24g.cluster,c6.16u32g.cluster]`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - changes of request param
      - `- createdAt`
      - `- permissions`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `* groups.createdAt: string -> int64`
  - **BatchUpdateConsumerGroup**
    - changes of request param
      - `- groups.createdAt`
      - `- groups.permissions`
      - `* groups: list<ConsumerGroup> -> list<CreateOrUpdateConsumerGroup>`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [4.8.0]`
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
      - `- product_id: enum value [c6.4u8g.cluster,c6.8u16g.cluster,c6.12u24g.cluster,c6.16u32g.cluster]`

# 3.1.86 2024-03-21

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeletePromInstance**
    - changes of request param
      - `+ Enterprise-Project-Id`
  - **ListPromInstance**
    - changes of request param
      - `+ Enterprise-Project-Id`
      - `+ prom_type: enum value [default]`
      - `+ prom_type: enum value [DEFAULT]`
    - changes of response param
      - `+ prometheus.prom_type: enum value [default]`
      - `- prometheus.prom_type: enum value [DEFAULT]`

### HuaweiCloud SDK CCE

- _Features_
  - Support the API `ShowNodePoolConfigurationDetails`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVerifyDomainOwnerInfo**
    - changes of response param
      - `+ file_verify_domains`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateApp**
    - changes of request param
      - `+ group_id`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowPositionResult**
    - changes of response param
      - `+ status`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateFunction**
    - changes of request param
      - `+ encrypted_user_data`
      - `+ mount_config`
      - `+ is_stateful_function`
      - `+ enable_dynamic_memory`
  - **UpdateVersionAlias**
    - changes of request param
      - `+ additional_version_strategy`
  - **DeleteFunctionTrigger**
    - changes of request param
      - `+ trigger_type_code: enum value [IOTDA]`
  - **ShowFunctionTrigger**
    - changes of request param
      - `+ trigger_type_code: enum value [IOTDA]`
  - **UpdateTrigger**
    - changes of request param
      - `+ trigger_type_code: enum value [IOTDA]`

### HuaweiCloud SDK GEIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSupportMasks**
    - changes of response param
      - `+ support_masks.ip_version: enum value [4,6]`
  - **ListGlobalEips**
    - changes of response param
      - `+ global_eips.ip_version: enum value [4,6]`
  - **DetachInternetBandwidth**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **BatchCreateGlobalEip**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **ShowGlobalEip**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **AttachInternetBandwidth**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **ListGlobalEipSegments**
    - changes of response param
      - `+ global_eip_segments.ip_version: enum value [4,6]`
  - **ShowGlobalEipSegment**
    - changes of response param
      - `+ global_eip_segment.ip_version: enum value [4,6]`
  - **ListGeipPools**
    - changes of response param
      - `+ geip_pools.ip_version: enum value [4,6]`

### HuaweiCloud SDK Live

- _Features_
  - Support the following APIs:
    - `ListOttChannelInfo`
    - `CreateOttChannelInfo`
    - `DeleteOttChannelInfo`
    - `ModifyOttChannelInfoEndPoints`
    - `ModifyOttChannelInfoInput`
    - `ModifyOttChannelInfoRecordSettings`
    - `ModifyOttChannelInfoGeneral`
    - `ModifyOttChannelInfoStats`
    - `ModifyOttChannelInfoEncoderSettings`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNatGatewaySnatRules**
    - changes of request param
      - `* floating_ip_address: string -> list<string>`
      - `* floating_ip_id: string -> list<string>`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizeHouseholdRegister`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ form`
      - `+ kv_map`
    - changes of response param
      - `+ result.form_result`
      - `+ result.layout_result.layout_block_list.table_id`
      - `+ result.layout_result.layout_block_list.form_id`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAutoEnlargePolicy**
    - changes of response param
      - `+ step_percent`
  - **SetAutoEnlargePolicy**
    - changes of request param
      - `+ step_percent`

# 3.1.85 2024-03-14

### HuaweiCloud SDK DRS

- _Features_
  - Support the API `ListAvailableNodeTypes`
- _Bug Fix_
  - None
- _Change_
  - **BatchSetPolicy**
    - changes of request param
      - `+ jobs.ddl_topic`
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.public_ip_list`
  - **ShowJobList**
    - changes of response param
      - `+ jobs.children.job_direction: enum value [non-dbs]`
      - `- jobs.children.job_direction: enum value [no-dbs]`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.public_ip_list`
      - `+ results.bind_public_ip_state`
      - `+ results.children`
  - **ShowUpdateObjectSavingStatus**
    - changes of response param
      - `+ job_id`
  - **CollectDbObjectsAsync**
    - changes of response param
      - `+ job_id`
  - **ShowDataProcessingRulesResult**
    - changes of response param
      - `+ job_id`
  - **CollectDbObjectsInfo**
    - changes of response param
      - `+ job_id`
  - **CollectPositionAsync**
    - changes of response param
      - `+ job_id`
  - **CollectColumns**
    - changes of response param
      - `+ job_id`
  - **CreateJob**
    - changes of request param
      - `+ job.public_ip_list`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.public_ip_list`
  - **UpdateDataProgress**
    - changes of response param
      - `+ job_id`
  - **CheckDataFilter**
    - changes of response param
      - `+ job_id`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.public_ip_list`
      - `+ jobs.bind_public_ip_state`
      - `+ jobs.children`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.public_ip_list`
      - `+ job.bind_public_ip_state`
      - `+ job.children`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [bind_eip,unbind_eip]`
      - `+ job.action_params.public_ip_config`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [bind_eip,unbind_eip]`
      - `+ jobs.action_params.public_ip_config`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowBinlogClearPolicy**
    - changes of response param
      - `+ binlog_clear_type`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AddOrRemoveServicePermissions**
    - changes of response param
      - `- permission_type: enum value [domainId,orgPath]`
  - **ListServiceDescribeDetails**
    - changes of response param
      - `- service_type: enum value [interface]`
      - `* created_at: string -> date-time`
  - **ListServiceDetails**
    - changes of response param
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `- service_type: enum value [gataway,interface]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **UpdateEndpointService**
    - changes of response param
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListServicePermissionsDetails**
    - changes of response param
      - `- permissions.permission_type: enum value [domainId,orgPath]`
      - `* permissions.created_at: string -> date-time`
  - **ListServicePublicDetails**
    - changes of response param
      - `- endpoint_services.service_type: enum value [interface,gateway]`
      - `* endpoint_services.created_at: string -> date-time`
  - **ListEndpointInfoDetails**
    - changes of response param
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `- enable_status: enum value [enable,disable]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `* policy_statement: list<string> -> list<PolicyStatement>`
  - **UpdateEndpointWhite**
    - changes of response param
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
  - **BatchAddOrRemoveResourceInstance**
    - changes of request param
      - `+ resource_type: enum value [endpoint_service,endpoint]`
      - `+ action: enum value [create,delete]`
      - `* body: object<BatchAddOrRemoveResourceInstanceBody> -> object<BatchAddOrRemoveResourceInstanceRequestBody>`
  - **ListQueryProjectResourceTags**
    - changes of request param
      - `+ resource_type: enum value [endpoint_service,endpoint]`
  - **BatchAddEndpointServicePermissions**
    - changes of request param
      - `* body: object<BatchAddPermissionRequest> -> object<BatchAddEndpointServicePermissionsRequestBody>`
    - changes of response param
      - `* permissions.created_at: string -> date-time`
  - **BatchRemoveEndpointServicePermissions**
    - changes of request param
      - `* body: object<BatchRemovePermissionRequest> -> object<BatchRemoveEndpointServicePermissionsRequestBody>`
    - changes of response param
      - `* permissions.created_at: string -> date-time`
  - **UpdateEndpointServicePermissionDesc**
    - changes of request param
      - `* body: object<UpdatePermissionDescRequest> -> object<UpdateEndpointServicePermissionDescRequestBody>`
    - changes of response param
      - `* permissions.created_at: string -> date-time`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
    - changes of response param
      - `- enable_dns`
      - `- dns_names`
      - `- subnet_id`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `- enable_dns`
      - `- dns_names`
      - `- subnet_id`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
  - **CreateEndpointService**
    - changes of request param
      - `+ service_type: enum value [gateway,interface]`
    - changes of response param
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListEndpointService**
    - changes of response param
      - `- endpoint_services.status: enum value [creating,available,failed]`
      - `- endpoint_services.service_type: enum value [VM,VIP,LB]`
      - `* endpoint_services.created_at: string -> date-time`
      - `* endpoint_services.updated_at: string -> date-time`
      - `- endpoint_services.tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListServiceConnections**
    - changes of request param
      - `+ status: enum value [pendingAcceptance,accepted,rejected,failed]`
    - changes of response param
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
  - **AcceptOrRejectEndpoint**
    - changes of response param
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
  - **CreateEndpoint**
    - changes of response param
      - `- dns_names`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `* policy_statement: list<string> -> list<PolicyStatement>`
  - **ListEndpoints**
    - changes of request param
      - `+ sort_key: enum value [create_at,update_at]`
      - `+ sort_dir: enum value [desc,asc]`
    - changes of response param
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
    - changes of response param
      - `- quotas.resources.type: enum value [endpoint_service,endpoint]`
      - `* quotas: object<ResourcesResp> -> object<ResourcesResponseBody>`
  - **ListVersionDetails**
    - changes of response param
      - `- versions.status: enum value [CURRENT,SUPPORT,DEPRECATED]`
      - `- versions.id: enum value [v1]`
      - `* versions.updated: string -> date-time`
  - **ListSpecifiedVersionDetails**
    - changes of response param
      - `- version.status: enum value [CURRENT,SUPPORT,DEPRECATED]`
      - `- version.id: enum value [v1]`
      - `* version.updated: string -> date-time`
  - **ListResourceInstances**
    - changes of request param
      - `+ resource_type: enum value [endpoint_service,endpoint]`
      - `+ action: enum value [filter,count]`
  - **UpdateEndpointConnectionsDesc**
    - changes of request param
      - `* body: object<UpdateEpConnections> -> object<UpdateEndpointConnectionsDescRequestBody>`
    - changes of response param
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`

# 3.1.84 2024-03-07

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBareMetalServers**
    - changes of response param
      - `* servers.OS-SRV-USG:launched_at: date-time -> string`
      - `* servers.OS-SRV-USG:terminated_at: date-time -> string`
  - **ListBareMetalServerDetails**
    - changes of response param
      - `* server.OS-SRV-USG:launched_at: date-time -> string`
      - `* server.OS-SRV-USG:terminated_at: date-time -> string`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateSslSwitch**
    - changes of response param
      - `+ result`
      - `+ instance_id`
  - **ListClients**
    - changes of response param
      - `+ clients.fd`
      - `+ clients.network`
      - `+ clients.peer`
      - `+ clients.user`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the API `UpdateDatabases`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AddCertificate**
    - changes of response param
      - `+ template_id`
      - `+ provision_enable`
  - **ListCertificates**
    - changes of response param
      - `+ template_id`
      - `+ provision_enable`
      - `+ certificates.provision_enable`
      - `+ certificates.template_id`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following APIs:
    - `CreateDeleteConnectorOrder`
    - `ListSinkTasks`
    - `CreateSinkTask`
    - `ShowSinkTaskDetail`
    - `DeleteSinkTask`
  - **SendKafkaMessage**
    - changes of request param
      - `+ property_list.name`
      - `+ property_list.value`
  - **ShowConnectorTask**
    - changes of response param
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
      - `* sink_task.target_db: string -> int32`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ ipv6_enable`
  - **CreateConnectorTask**
    - changes of request param
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
    - changes of response param
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
      - `* sink_task.target_db: string -> int32`
  - **ListConnectorTasks**
    - changes of response param
      - `* tasks.source_task.replication_factor: string -> int32`
      - `* tasks.source_task.task_num: string -> int32`
      - `* tasks.sink_task.target_db: string -> int32`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeIdCard**
    - changes of request param
      - `+ return_portrait_image`
      - `+ return_adjusted_image`
    - changes of response param
      - `+ result.portrait_image`
      - `+ result.adjusted_image`
      - `+ result.front.portrait_image`
      - `+ result.front.adjusted_image`
      - `+ result.back.adjusted_image`

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
    - `ShowStorageUsedSpace`
    - `SwitchSqlLimit`
    - `UpdateSqlLimit`
    - `ListSqlLimit`
    - `CreateSqlLimit`
    - `DeleteSqlLimit`
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `* instances.volume: object<Volume> -> object<VolumeForInstanceResponse>`
  - **CreateRestoreInstance**
    - changes of request param
      - `- replica_of_id`
      - `- unchangeable_param`

# 3.1.83 2024-02-29

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAddressSets**
    - changes of request param
      - `+ query_address_set_type`
    - changes of response param
      - `+ data.records.object_id`
      - `+ data.records.address_set_type`
  - **UpdateAclRuleOrder**
    - changes of response param
      - `+ data.name`
  - **AddBlackWhiteList**
    - changes of response param
      - `+ data.name`
  - **UpdateBlackWhiteList**
    - changes of response param
      - `+ data.name`
  - **DeleteBlackWhiteList**
    - changes of response param
      - `+ data.name`
  - **ChangeIpsProtectMode**
    - changes of response param
      - `+ data.name`
  - **AddServiceSet**
    - changes of response param
      - `+ data.name`
  - **ListServiceSetDetail**
    - changes of response param
      - `+ data.service_set_type`
  - **UpdateServiceSet**
    - changes of response param
      - `+ data.name`
  - **DeleteServiceSet**
    - changes of response param
      - `+ data.name`
  - **DeleteServiceItem**
    - changes of response param
      - `+ data.name`
  - **CreateFirewall**
    - changes of request param
      - `- flavor.version: enum value [Platinum]`
    - changes of response param
      - `- data.flavor.version: enum value [Platinum]`
  - **ChangeEipStatus**
    - changes of response param
      - `+ data.id`
  - **DeleteAddressItem**
    - changes of response param
      - `+ data.name`
  - **AddAddressSet**
    - changes of response param
      - `+ data.name`
  - **ListAddressSetDetail**
    - changes of request param
      - `+ query_address_set_type`
    - changes of response param
      - `+ data.address_set_type`
  - **UpdateAddressSet**
    - changes of response param
      - `* data: object<IdObject> -> object<UpdateAddressSetResponseData>`
  - **DeleteAddressSet**
    - changes of response param
      - `+ data.name`
  - **CreateEastWestFirewall**
    - changes of response param
      - `+ data.name`
  - **ListEastWestFirewall**
    - changes of response param
      - `+ data.protect_infos.status`
  - **AddAclRule**
    - changes of response param
      - `+ data.rules.name`
  - **DeleteAclRule**
    - changes of response param
      - `+ data.name`
  - **UpdateAclRule**
    - changes of response param
      - `+ data.name`
  - **ListAclRules**
    - changes of response param
      - `+ data.records.created_date`
      - `+ data.records.last_open_time`
  - **AddServiceItems**
    - changes of response param
      - `+ data.items.name`
  - **AddAddressItem**
    - changes of response param
      - `+ data.items.name`
  - **ListServiceSets**
    - changes of response param
      - `+ data.records.service_set_type`
      - `+ data.records.project_id`
      - `+ data.records.protocols`
  - **ListProtectedVpcs**
    - changes of response param
      - `+ data.total_assets`
  - **ListFirewallDetail**
    - changes of response param
      - `+ data.records.is_available_obs`
      - `+ data.records.is_support_threat_tags`
  - **ListFirewallList**
    - changes of response param
      - `+ is_support_postpaid`
      - `+ is_support_buy_professional`
      - `+ has_ndr`
      - `+ is_support_basic_version`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateFunctionTrigger**
    - changes of response param
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

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowRule**
    - changes of response param
      - `+ actions.smn_forwarding.message_template_name`
  - **UpdateRule**
    - changes of request param
      - `+ actions.smn_forwarding.message_template_name`
    - changes of response param
      - `+ actions.smn_forwarding.message_template_name`
  - **CreateRule**
    - changes of request param
      - `+ actions.smn_forwarding.message_template_name`
    - changes of response param
      - `+ actions.smn_forwarding.message_template_name`
  - **ListRules**
    - changes of response param
      - `+ rules.actions.smn_forwarding.message_template_name`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the following APIs:
    - `ListConnectorTasks`
    - `CreateConnectorTask`
    - `ShowConnectorTask`
    - `DeleteConnectorTask`
    - `PauseConnectorTask`
    - `ResumeConnectorTask`
    - `RestartConnectorTask`
- _Bug Fix_
  - None
- _Change_
  - **ShowInstance**
    - changes of response param
      - `+ connector_node_num`
  - **CreateSinkTask**
    - changes of request param
      - `+ obs_destination_descriptor.partition_format: enum value [yyyy,yyyy/MM,yyyy/MM/dd,yyyy/MM/dd/HH,yyyy/MM/dd/HH/mm]`
  - **ListInstances**
    - changes of response param
      - `+ connector_node_num`
      - `+ instances.connector_node_num`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLogStream**
    - changes of request param
      - `+ log_stream_name_alias`
      - `+ enterprise_project_name`

# 3.1.82 2024-02-22

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDashboardWidgets**
    - changes of request param
      - `* body: list<BaseWidgetInfo> -> list<object>`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ModifyGaussMySqlProxyRouteMode**
    - changes of request param
      - `+ new_node_auto_add_status`
      - `+ new_node_weight`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListRecycleInstances**
    - changes of response param
      - `+ instances.engine_name`
      - `+ instances.volume_size`
      - `+ instances.enterprise_project_name`
      - `+ instances.backup_level`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of response param
      - `+ images.__image_displayname`
  - **UpdateImage**
    - changes of response param
      - `+ __image_displayname`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeTrainTicket**
    - changes of response param
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

- _Features_
  - Support the APIs `ListClients`, `ScanClients`, `HangUpClients`, `HangUpKillAllClients`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.80 2024-02-07

### HuaweiCloud SDK GEIP

- _Features_
  - Support `GEIP`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EIP

- _Features_
  - Support the following APIs:
    - `ListTenantVpcIgws`
    - `CreateTenantVpcIgw`
    - `ShowInternalVpcIgw`
    - `UpdateTenantVpcIgw`
    - `DeleteTenantVpcIgw`
    - `ListProjectGeipBindings`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the API `UpdateNewNodeAutoAddSwitch`
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlProxy**
    - changes of request param
      - `+ new_node_auto_add_status`
      - `+ new_node_weight`
  - **ShowGaussMySqlProxyList**
    - changes of response param
      - `+ proxy_list.proxy.new_node_auto_add_status`
      - `+ proxy_list.proxy.new_node_weight`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the API `StopBackup`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
    - `UpdateDatabaseOwner`
    - `ExecutePrivilegeDatabaseUserRole`
    - `ExecuteRevokeDatabaseUserRole`
    - `ListDatabaseUserRole`
    - `UpdatePostgresqlExtension`
- _Bug Fix_
  - None
- _Change_
  - **ListPostgresqlExtension**
    - changes of response param
      - `+ extensions.version_update`

# 3.1.79 2024-02-01

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEvents**
    - changes of response param
      - `* events.annotations: map<string, string> -> map<string, object>`
      - `* events.attach_rule: map<string, string> -> map<string, object>`
  - **PushEvents**
    - changes of request param
      - `* events.annotations: map<string, string> -> map<string, object>`
      - `* events.attach_rule: map<string, string> -> map<string, object>`
  - **CreatePromInstance**
    - changes of request param
      - `+ region`

### HuaweiCloud SDK AOS

- _Features_
  - Support the APIs `CreatePrivateProvider`, `CreatePrivateProviderVersion`
- _Bug Fix_
  - None
- _Change_
  - **GetExecutionPlan**
    - changes of response param
      - `+ execution_plan_items.imported`
  - **GetExecutionPlanMetadata**
    - changes of response param
      - `+ summary.resource_import`

### HuaweiCloud SDK CDN

- _Features_
  - Support the API `ShowLogs`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlInstance**
    - changes of request param
      - `+ tde_info`
  - **ShowGaussMySqlInstanceInfoUnifyStatus**
    - changes of response param
      - `+ instance.tde_info`
  - **ListGaussMySqlInstanceDetailInfoUnifyStatus**
    - changes of response param
      - `+ instances.tde_info`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `CreateShrinkageJob`, `ShowShrinkCheckResult`, `UpdateSinkTaskQuota`
  - **CreateInstanceTopic**
    - changes of response param
      - `- id`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNatGatewayDnatRules**
    - changes of request param
      - `+ marker`
  - **ListNatGatewaySnatRules**
    - changes of request param
      - `+ marker`
  - **ListNatGateways**
    - changes of request param
      - `+ marker`

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
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
- _Bug Fix_
  - None
- _Change_
  - **SetAuditlogPolicy**
    - changes of request param
      - `+ audit_types`
  - **CreateDbUser**
    - changes of request param
      - `+ is_privilege`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowGroup**
    - changes of response param
      - `* retry_max_time: number -> int32`
  - **UpdateConsumerGroup**
    - changes of request param
      - `* retry_max_time: number -> int32`
  - **ResetConsumeOffset**
    - changes of request param
      - `* timestamp: number -> string`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - changes of request param
      - `+ createdAt`
      - `+ permissions`
      - `+ consume_orderly`
      - `- from_beginning`
      - `* retry_max_time: number -> int32`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `+ groups.createdAt`
      - `+ groups.permissions`
      - `+ groups.consume_orderly`
      - `- groups.from_beginning`
      - `* groups.retry_max_time: number -> int32`
  - **BatchUpdateConsumerGroup**
    - changes of request param
      - `+ groups.createdAt`
      - `+ groups.permissions`
      - `+ groups.consume_orderly`
      - `- groups.from_beginning`
      - `* groups.retry_max_time: number -> int32`

# 3.1.78 2024-01-25

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeleteserviceDiscoveryRules**
    - changes of response param
      - `+ id`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlReadonlyNode**
    - changes of request param
      - `+ availability_zones`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeAutoClassification**
    - changes of request param
      - `+ detect_seal`
    - changes of response param
      - `+ result.seal_mark`
  - **RecognizeVatInvoice**
    - changes of response param
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

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of request param
      - `+ is_serverless`
  - **ListInstances**
    - changes of response param
      - `+ instances.serverless_info`
  - **CreateInstance**
    - changes of request param
      - `+ serverless_info`
  - **CreateRestoreInstance**
    - changes of request param
      - `+ serverless_info`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAssetByFileUpload**
    - changes of request param
      - `* category_id: string -> int32`
  - **CreateAssetProcessTask**
    - changes of request param
      - `+ hls_storage_type`
  - **ListTopStatistics**
    - changes of response param
      - `- top_urls.duration_ms`
  - **ListAssetList**
    - changes of response param
      - `- assets.duration_ms`
  - **ShowTakeOverAssetDetails**
    - changes of response param
      - `- base_info.meta_data.duration_ms`
  - **PublishAssets**
    - changes of response param
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **UnpublishAssets**
    - changes of response param
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetMeta**
    - changes of response param
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetDetail**
    - changes of response param
      - `- base_info.meta_data.duration_ms`
  - **ShowTakeOverTaskDetails**
    - changes of response param
      - `- assets.base_info.meta_data.duration_ms`

# 3.1.77 2024-01-18

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPromInstance**
    - changes of request param
      - `+ prom_status: enum value [DELETED,NORMAL,ALL]`
      - `+ prom_status: enum value [true,false]`
    - changes of response param
      - `- prometheus.cce_spec`
      - `- prometheus.prom_config`
      - `- prometheus.application`
      - `+ prometheus.prom_status: enum value [DELETED,NORMAL,ALL]`
  - **CreatePromInstance**
    - changes of request param
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
    - changes of response param
      - `- prometheus.cce_spec`
      - `- prometheus.prom_config`
      - `- prometheus.is_deleted_tag`
      - `- prometheus.application`
      - `- prometheus.prom_type: enum value [DEFAULT]`
      - `+ prometheus.prom_status: enum value [DELETED,NORMAL,ALL]`
      - `* prometheus: list<PromInstanceEpsModel> -> list<PromInstanceEpsCreateModel>`
  - **AddOrUpdateServiceDiscoveryRules**
    - changes of response param
      - `+ id`
      - `+ results`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCluster**
    - changes of response param
      - `+ spec.enableAutopilot`
  - **UpdateCluster**
    - changes of response param
      - `+ spec.enableAutopilot`
  - **DeleteCluster**
    - changes of response param
      - `+ spec.enableAutopilot`
  - **CreateCluster**
    - changes of request param
      - `+ spec.enableAutopilot`
    - changes of response param
      - `+ spec.enableAutopilot`
  - **ListClusters**
    - changes of response param
      - `+ items.spec.enableAutopilot`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowTopUrl**
    - changes of request param
      - `+ service_area: enum value [global]`

### HuaweiCloud SDK CDN

- _Features_
  - Support the API `ListCdnDomainTopRefers`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - Support the API `ChangeMasterStandbyAsync`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateListener**
    - changes of request param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
  - **ListLoadbalancers**
    - changes of response param
      - `+ loadbalancers.billing_info`
      - `+ loadbalancers.protection_status`
      - `+ loadbalancers.protection_reason`
  - **CreateLoadbalancer**
    - changes of response param
      - `+ loadbalancer_id`
      - `+ order_id`
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ShowLoadbalancer**
    - changes of response param
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **UpdateLoadbalancer**
    - changes of response param
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizeSeal`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeFlightItinerary**
    - changes of response param
      - `+ result.tax`
      - `+ result.tax_rate`
      - `+ result.buyer_name`
      - `+ result.buyer_id`
      - `+ result.number`
      - `+ result.international_flag`
      - `+ result.issue_status`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAuditlogPolicy**
    - changes of response param
      - `+ all_audit_log_action`
      - `+ audit_types`
  - **ListRecycleInstances**
    - changes of response param
      - `+ instances.is_serverless`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ValidateConsumedMessage**
    - changes of request param
      - `+ topic`

# 3.1.76 2024-01-11

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateNodePool**
    - changes of response param
      - `- status.jobId`
      - `* status: object<NodePoolStatus> -> object<UpdateNodePoolStatus>`
  - **CreateNodePool**
    - changes of response param
      - `- status.jobId`
      - `* status: object<NodePoolStatus> -> object<CreateNodePoolStatus>`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchValidateConnections**
    - changes of request param
      - `+ jobs.customized_dns`

### HuaweiCloud SDK DRS

- _Features_
  - Support the following APIs:
    - `BatchCreateTags`
    - `BatchDeleteTags`
    - `ListInstanceByTags`
    - `CountInstanceByTags`
    - `ListInstanceTags`
    - `ListTags`
    - `UpdateJobConfigurations`
    - `ListJobParameters`
    - `ListJobHistoryParameters`
- _Bug Fix_
  - None
- _Change_
  - **ListLinks**
    - changes of response param
      - `+ job_links.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
  - **ListJobs**
    - changes of request param
      - `+ engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
    - changes of response param
      - `+ jobs.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.children.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
  - **CreateJob**
    - changes of request param
      - `+ job.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.source_endpoint.customized_dns`
      - `+ job.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.source_endpoint.config.node_num`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.source_endpoint.customized_dns`
      - `+ jobs.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.source_endpoint.config.node_num`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.source_endpoint.customized_dns`
      - `+ jobs.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.source_endpoint.config.node_num`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.params.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.params.source_endpoint.customized_dns`
      - `+ jobs.params.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.params.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.params.source_endpoint.config.node_num`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.source_endpoint.customized_dns`
      - `+ job.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.source_endpoint.config.node_num`
  - **UpdateJob**
    - changes of request param
      - `+ job.params.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.params.source_endpoint.customized_dns`
      - `+ job.params.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.params.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.params.source_endpoint.config.node_num`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [column_limit,reload_parameters]`
      - `+ job.action_params.endpoints.customized_dns`
      - `+ job.action_params.endpoints.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.action_params.endpoints.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.action_params.endpoints.config.node_num`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [column_limit,reload_parameters]`
      - `+ jobs.action_params.endpoints.customized_dns`
      - `+ jobs.action_params.endpoints.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.action_params.endpoints.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.action_params.endpoints.config.node_num`

### HuaweiCloud SDK ECS

- _Features_
  - Support the API `NovaShowServerInterface`
- _Bug Fix_
  - None
- _Change_
  - **UpdateServer**
    - changes of response param
      - `+ server.OS-EXT-SRV-ATTR:user_data`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCertificate**
    - changes of response param
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
    - changes of response param
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
    - changes of response param
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
    - changes of response param
      - `+ healthmonitors`
  - **CreateHealthmonitor**
    - changes of response param
      - `+ healthmonitor`
  - **ShowHealthmonitors**
    - changes of response param
      - `+ healthmonitor`
  - **UpdateHealthmonitor**
    - changes of response param
      - `+ healthmonitor`
  - **ListMembers**
    - changes of response param
      - `+ members`
  - **CreateMember**
    - changes of response param
      - `+ member`
  - **ShowMember**
    - changes of response param
      - `+ member`
  - **UpdateMember**
    - changes of response param
      - `+ member`
  - **ShowLoadbalancer**
    - changes of response param
      - `+ loadbalancer`
  - **UpdateLoadbalancer**
    - changes of request param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - changes of response param
      - `+ loadbalancer`
  - **ListL7rules**
    - changes of response param
      - `+ rules`
  - **CreateL7rule**
    - changes of response param
      - `+ rule`
  - **ShowL7rule**
    - changes of response param
      - `+ rule`
  - **UpdateL7rule**
    - changes of response param
      - `+ rule`
  - **ListPools**
    - changes of response param
      - `+ pools`
  - **CreatePool**
    - changes of request param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - changes of response param
      - `+ pool`
  - **ShowPool**
    - changes of response param
      - `+ pool`
  - **UpdatePool**
    - changes of request param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - changes of response param
      - `+ pool`
  - **ListListeners**
    - changes of response param
      - `+ listeners`
  - **CreateListener**
    - changes of response param
      - `+ listener`
  - **ShowListener**
    - changes of response param
      - `+ listener`
  - **UpdateListener**
    - changes of request param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
    - changes of response param
      - `+ listener`
  - **CreateLoadbalancer**
    - changes of request param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - changes of response param
      - `+ loadbalancer`
  - **ListLoadbalancers**
    - changes of response param
      - `+ loadbalancers.publicips`
      - `+ loadbalancers.charge_mode`
      - `+ loadbalancers.frozen_scene`
  - **ListL7policies**
    - changes of response param
      - `+ l7policies`
  - **CreateL7policy**
    - changes of response param
      - `+ l7policy`
  - **UpdateL7policies**
    - changes of response param
      - `+ l7policy`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPools**
    - changes of request param
      - `+ connection_drain`
    - changes of response param
      - `+ pools.connection_drain`
  - **CreatePool**
    - changes of request param
      - `+ pool.connection_drain`
    - changes of response param
      - `+ pool.connection_drain`
  - **ShowPool**
    - changes of response param
      - `+ pool.connection_drain`
  - **UpdatePool**
    - changes of request param
      - `+ pool.connection_drain`
    - changes of response param
      - `+ pool.connection_drain`
  - **ListMasterSlavePools**
    - changes of request param
      - `+ connection_drain`
    - changes of response param
      - `+ pools.connection_drain`
  - **CreateMasterSlavePool**
    - changes of request param
      - `+ pool.connection_drain`
    - changes of response param
      - `+ pool.connection_drain`
  - **ShowMasterSlavePool**
    - changes of response param
      - `+ pool.connection_drain`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateReassignmentTask**
    - changes of request param
      - `+ is_schedule`
      - `+ execute_at`

### HuaweiCloud SDK MPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTranscodingTask**
    - changes of response param
      - `+ task_array.progress`
  - **ListTranscodeDetail**
    - changes of response param
      - `+ task_array.progress`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeIdCard**
    - changes of request param
      - `+ detect_tampering`
      - `+ detect_border_integrity`
      - `+ detect_blocking_within_border`
      - `+ detect_blur`
      - `+ detect_interim`
      - `+ detect_glare`
    - changes of response param
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

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `+ eps_id`
  - **BatchRestoreDatabase**
    - changes of request param
      - `+ instances.is_fast_restore`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddressGroup**
    - changes of response param
      - `+ address_group.ip_extra_set`
  - **UpdateAddressGroup**
    - changes of request param
      - `+ address_group.ip_extra_set`
    - changes of response param
      - `+ address_group.ip_extra_set`
  - **ListAddressGroup**
    - changes of response param
      - `+ address_groups.ip_extra_set`
  - **CreateAddressGroup**
    - changes of request param
      - `+ address_group.ip_extra_set`
    - changes of response param
      - `+ address_group.ip_extra_set`

# 3.1.75 2024-01-04

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNotifiedHistories**
    - changes of response param
      - `+ notified_histories`
      - `- event_sn`
      - `- notifications`
  - **ListEvent2alarmRule**
    - changes of response param
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* : list<event2alarmRuleBody> -> list<Event2alarmRuleBody>`
  - **UpdateEventRule**
    - changes of request param
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* body: object<event2alarmRuleBody> -> object<Event2alarmRuleBody>`
  - **AddEvent2alarmRule**
    - changes of request param
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* body: object<event2alarmRuleBody> -> object<Event2alarmRuleBody>`
  - **ListMuteRule**
    - changes of response param
      - `* mute_config.scope: list<string> -> list<integer>`
  - **UpdateMuteRule**
    - changes of request param
      - `* mute_config.scope: list<string> -> list<integer>`
  - **AddMuteRules**
    - changes of request param
      - `* mute_config.scope: list<string> -> list<integer>`
  - **ShowActionRule**
    - changes of response param
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **ListEvents**
    - changes of response param
      - `* events.metadata: object -> map<string, string>`
      - `* events.annotations: object -> map<string, string>`
      - `* events.attach_rule: object -> map<string, string>`
  - **PushEvents**
    - changes of request param
      - `* events.metadata: object -> map<string, string>`
      - `* events.annotations: object -> map<string, string>`
      - `* events.attach_rule: object -> map<string, string>`
  - **UpdateActionRule**
    - changes of request param
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **AddActionRule**
    - changes of request param
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **ListActionRule**
    - changes of response param
      - `+ action_rules.type: enum value [1,2]`
      - `- action_rules.type: enum value ["1","2"]`
  - **ListMetricItems**
    - changes of response param
      - `+ metaData.offset`
      - `+ metaData.nextToken`
      - `- metaData.start`
      - `* metaData: object<metaData> -> object<MetaDataSeries>`
  - **UpdateAlarmRule**
    - changes of request param
      - `+ is_turn_on`
      - `- id_turn_on`
      - `+ comparison_operator: enum value [<,>,<=,>=]`
      - `+ period: enum value [60000,300000,900000,36000000]`
  - **AddAlarmRule**
    - changes of request param
      - `+ is_turn_on`
      - `- id_turn_on`
      - `+ comparison_operator: enum value [<,>,<=,>=]`
      - `+ period: enum value [60000,300000,900000,36000000]`
  - **ListServiceDiscoveryRules**
    - changes of response param
      - `+ id`
      - `+ appRules.desc`
      - `+ appRules.spec.dataSource`
      - `+ appRules.spec.editable`
      - `+ appRules.spec.aom_metric_relabel_configs`
  - **AddOrUpdateServiceDiscoveryRules**
    - changes of request param
      - `+ appRules.desc`
      - `+ appRules.spec.dataSource`
      - `+ appRules.spec.editable`
      - `+ appRules.spec.aom_metric_relabel_configs`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAccessCode**
    - changes of request param
      - `+ force_disconnect`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the API `ResetMessageOffsetWithEngine`
- _Bug Fix_
  - None
- _Change_
  - **ShowGroups**
    - changes of response param
      - `* group.group_message_offsets.message_current_offset: int32 -> int64`
      - `* group.group_message_offsets.message_log_end_offset: int32 -> int64`
  - **ResetMessageOffset**
    - changes of request param
      - `* message_offset: int32 -> int64`
      - `* timestamp: int32 -> int64`
  - **ShowMessages**
    - changes of response param
      - `* messages.message_offset: int32 -> int64`
  - **ShowInstanceMessages**
    - changes of response param
      - `* messages.message_offset: int32 -> int64`

### HuaweiCloud SDK MPC

- _Features_
  - Support the APIs `ShowTenantAccessInfo`, `UpdateTenantAccessInfo`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchRestartOrDeleteInstances**
    - changes of request param
      - `- action: enum value [restart]`
  - **ListInstancesDetails**
    - changes of request param
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **SetOffSiteBackupPolicy**
    - changes of request param
      - `* policy_para: list<OffSiteBackupPolicy> -> object<OffSiteBackupPolicy>`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ResizeInstance**
    - changes of request param
      - `+ publicip_id`

### HuaweiCloud SDK SMN

- _Features_
  - Support the following APIs:
    - `PublishHttpDetect`
    - `ShowHttpDetectResult`
    - `BatchUpdateSubscriptionsFilterPolices`
    - `BatchCreateSubscriptionsFilterPolices`
    - `BatchDeleteSubscriptionsFilterPolices`
    - `AddSubscriptionFromSubscriptionUser`
- _Bug Fix_
  - None
- _Change_
  - Deprecate the following APIs:
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
    - changes of request param
      - `+ message_attributes`
  - **ListTopics**
    - changes of request param
      - `+ fuzzy_display_name`
  - **ListSubscriptions**
    - changes of request param
      - `+ fuzzy_remark`
    - changes of response param
      - `+ subscriptions.filter_polices`
  - **ListSubscriptionsByTopic**
    - changes of request param
      - `+ fuzzy_remark`
    - changes of response param
      - `+ subscriptions.filter_polices`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPorts**
    - changes of response param
      - `+ ports.ipv6_bandwidth_id`
  - **CreatePort**
    - changes of response param
      - `+ port.ipv6_bandwidth_id`
  - **ShowPort**
    - changes of response param
      - `+ port.ipv6_bandwidth_id`
  - **UpdatePort**
    - changes of response param
      - `+ port.ipv6_bandwidth_id`

