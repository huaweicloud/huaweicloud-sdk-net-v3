# 3.1.12 2022-11-30

### HuaweiCloud SDK DDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`AddReadonlyNode`请求参数`num`类型调整 `string` -> `int32`

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持接口`DisassociatePublicips`、`AssociatePublicips`
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
  - 接口`ShowTenantMetric`新增请求参数 `metric_type`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持以下接口：
    - `ListAvailableFlavorInfos`
    - `CheckWeekPassword`
    - `ModifyPort`
    - `UpdateClientNetwork`
    - `DeleteEnlargeFailNode`
    - `ShowIpNumRequirement`
    - `ShowAutoEnlargePolicy`
    - `ShowSlowLogDesensitization`
    - `SwitchSlowlogDesensitization`
    - `ShowErrorLog`
    - `CopyConfiguration`
    - `CompareConfiguration`
    - `ListConfigurationDatastores`
    - `ShowAllInstancesBackups`
    - `CreateBack`
    - `ShowRecyclePolicy`
    - `SetRecyclePolicy`
    - `ListRecycleInstances`
    - `ShowPauseResumeStutus`
    - `PauseResumeDataSynchronization`
    - `ListProjectTags`
    - `ListEpsQuotas`
    - `ModifyEpsQuotas`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ModifyPublicIp`请求参数`public_ip`、`public_ip_id`改为非必填
  - 接口`SwitchToMaster`新增请求参数 `SwitchToMasterDisasterRecoveryBody`

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`PushTranscriberJobs`请求参数`property`新增枚举值`chinese_8k_general`
  - 接口`RunTts`请求参数`property`新增枚举值`chinese_huaxiaoru_common`、`chinese_huaxiaohan_common`、`chinese_huaxiaoning_common`、`chinese_huaxiaozhen_common`、`english_alvin_common`、`english_amy_common`

# 3.1.11 2022-11-24

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`ListStackEvents`、`ListStackResources`、`DeleteStack`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowBackup`新增响应参数 `children`
  - 接口`ListBackups`新增响应参数 `children`

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateCluster`新增请求参数 `configurationsOverride`
  - 接口`ListClusters`新增响应参数 `configurationsOverride`
  - 接口`UpdateCluster`:
    - 新增请求参数 `eniNetwork`、`hostNetwork`
    - 新增响应参数 `configurationsOverride`
  - 接口`DeleteCluster`:
    - 新增请求参数 `delete_sfs30`
    - 新增响应参数 `configurationsOverride`
  - 接口`ShowCluster`新增响应参数 `configurationsOverride`
  - 接口`CreateNode`新增请求参数 `initializedConditions`
  - 接口`ListNodes`新增响应参数 `initializedConditions`
  - 接口`UpdateNode`新增响应参数 `initializedConditions`
  - 接口`DeleteNode`新增响应参数 `initializedConditions`
  - 接口`ShowNode`新增响应参数 `initializedConditions`
  - 接口`AddNode`新增请求参数 `initializedConditions`
  - 接口`ResetNode`新增请求参数 `initializedConditions`
  - 接口`CreateNodePool`新增请求参数 `customSecurityGroups`、`initializedConditions`
  - 接口`ListNodePools`新增响应参数 `customSecurityGroups`、`initializedConditions`
  - 接口`UpdateNodePool`:
    - 新增请求参数 `initializedConditions`
    - 新增响应参数 `customSecurityGroups`、`initializedConditions`
  - 接口`DeleteNodePool`新增响应参数 `customSecurityGroups`、`initializedConditions`
  - 接口`ShowNodePool`新增响应参数 `customSecurityGroups`、`initializedConditions`

### HuaweiCloud SDK CES

- _新增特性_
  - 支持以下接口：
    - `ListAlarmTemplates`
    - `CreateAlarmTemplate`
    - `BatchDeleteAlarmTemplates`
    - `ShowAlarmTemplate`
    - `UpdateAlarmTemplate`
    - `ListAlarmTemplateAssociationAlarms`
    - `ListResourceGroups`
    - `CreateResourceGroup`
    - `ShowResourceGroup`
    - `UpdateResourceGroup`
    - `ListResourceGroupsServicesResources`
    - `BatchDeleteResourceGroups`
    - `BatchCreateResources`
    - `BatchDeleteResources`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持以下接口：
    - `ListAppliedInstances`
    - `ShowConfigurationAppliedHistory`
    - `ShowConfigurationModifyHistory`
    - `CompareConfiguration`
    - `CopyConfiguration`
    - `ResetConfiguration`
    - `ListTasks`
- _解决问题_
  - 无
- _特性变更_
  - 接口`AddReadonlyNode`新增请求参数 `is_auto_pay`

### HuaweiCloud SDK DNS

- _新增特性_
  - 支持以下接口：
    - `SetPrivateZoneProxyPattern`
    - `AssociateHealthCheck`
    - `DisassociateHealthCheck`
    - `CreateRetrieval`
    - `ShowRetrieval`
    - `CreateRetrievalVerification`
    - `ShowRetrievalVerification`
    - `CreateEndpoint`
    - `ShowEndpoint`
    - `ListEndpoints`
    - `UpdateEndpoint`
    - `DeleteEndpoint`
    - `AssociateEndpointIpaddress`
    - `ListEndpointIpaddresses`
    - `DisassociateEndpointIpaddress`
    - `ListEndpointVpcs`
    - `CreateResolveRule`
    - `ShowResoleRule`
    - `ListResoleRules`
    - `UpdateResolveRule`
    - `DeleteResolveRule`
    - `CreateLineGroup`
    - `ListLineGroups`
    - `ShowLineGroup`
    - `UpdateLineGroups`
    - `DeleteLineGroup`
    - `BatchDeleteZones`
    - `BatchDeletePtrRecords`
    - `BatchSetZonesStatus`
    - `BatchSetRecordSetsStatus`
    - `BatchDeleteRecordSets`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持以下接口：
    - `CreateDependencyVersion`
    - `ListDependencyVersion`
    - `ShowDependencyVersion`
    - `DeleteDependencyVersion`
    - `ListReservedInstanceConfigs`
    - `ListFunctionReservedInstances`
    - `ListFunctionAsMetric`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`AsyncInvokeReservedFunction`
  - 接口`UpdateFunctionConfig`新增请求参数 `custom_image`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持以下接口：
    - `ResizeColdVolume`
    - `CreateColdVolume`
    - `ModifyPublicIp`
    - `SwitchSsl`
    - `SetAutoEnlargePolicy`
    - `RestartInstance`
    - `ShowApplicableInstances`
    - `ShowModifyHistory`
    - `ShowApplyHistory`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateInstance`新增请求参数 `restore_info`、`port`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeHealthCode`新增响应参数 `test_interval`

# 3.1.10 2022-11-17

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持应用编排服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DeleteServerNics`请求参数`id`改为必填

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ResizeInstance`请求参数`new_capacity`类型调整 `integer` -> `int32`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RegisterServerMonitor`请求参数`monitorMetrics`类型调整 `string` -> `enum`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DisassociatePublicips`请求参数`associate_instance_type`新增枚举值`VPN`
  - 接口`AssociatePublicips`请求参数`associate_instance_type`新增枚举值`VPN`

### HuaweiCloud SDK EPS

- _新增特性_
  - 支持接口`ListProviders`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ShowInstanceRole`、`SwitchToMaster`、`SwitchToSlave`
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
  - 接口`CreateMessage`新增请求参数 `ttl`
  - 接口`ListCertificates`新增请求参数 `Sp-Auth-Token`、`Stage-Auth-Token`
  - 接口`AddCertificate`:
    - 新增请求参数 `Sp-Auth-Token`、`Stage-Auth-Token`、`addCertificateRequestBody`
    - 移除请求参数 `AddCertificateRequestBody`
  - 接口`DeleteCertificate`新增请求参数 `Sp-Auth-Token`、`Stage-Auth-Token`
  - 接口`CheckCertificate`:
    - 新增请求参数 `Sp-Auth-Token`、`Stage-Auth-Token`、`checkCertificateRequestBody`
    - 移除请求参数 `CheckCertificateRequestBody`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ResetPassword`请求参数`new_password`改为必填

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeGeneralTable`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeVatInvoice`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeInvoiceVerification`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeGeneralText`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeWebImage`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeHealthCode`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeQuotaInvoice`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeIdCard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeHandwriting`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeVehicleLicense`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeTransportationLicense`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeTaxiInvoice`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeAutoClassification`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeTollInvoice`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeMvsInvoice`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeLicensePlate`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeFlightItinerary`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeBusinessLicense`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeDriverLicense`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeBusinessCard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeTrainTicket`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeVin`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizePassport`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeBankcard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeInsurancePolicy`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeFinancialStatement`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeQualificationCertificate`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeThailandIdcard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeMyanmarIdcard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeMyanmarDriverLicense`:
    - 新增请求参数 `Enterprise-Project-Id`
    - 新增响应参数 `birth`、`birth`
    - 移除响应参数 `Birth`、`Birth`
  - 接口`RecognizeChileIdCard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeThailandLicensePlate`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeWaybillElectronic`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizePcrTestRecord`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeIdDocument`:
    - 新增请求参数 `Enterprise-Project-Id`
    - 响应参数`result`类型调整 `object` -> `object`
  - 接口`RecognizeHkIdCard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeCambodianIdCard`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeExitEntryPermit`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeMainlandTravelPermit`新增请求参数 `Enterprise-Project-Id`
  - 接口`RecognizeMacaoIdCard`新增请求参数 `Enterprise-Project-Id`

### HuaweiCloud SDK TMS

- _新增特性_
  - 支持接口`ListProviders`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateSubnet`:
    - 请求参数`opt_name`新增枚举值`addresstime`
    - 响应参数`opt_name`新增枚举值`addresstime`
  - 接口`ListSubnets`响应参数`opt_name`新增枚举值`addresstime`
  - 接口`ShowSubnet`响应参数`opt_name`新增枚举值`addresstime`
  - 接口`UpdateSubnet`请求参数`opt_name`新增枚举值`addresstime`

# 3.1.9 2022-11-14

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DeleteServerNics`响应参数`job_id`改为必填
  - 接口`UpdateBaremetalServerInterfaceAttachments`:
    - 请求参数`delete_on_termination`类型调整 `string` -> `boolean`
    - 请求参数`delete_on_termination`改为必填
  - 接口`ShowServerRemoteConsole`新增响应参数 `remote_console`

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持以下接口：
    - `ShowSlowlogDesensitizationSwitch`
    - `ListRecycleInstances`
    - `CheckWeakPassword`
    - `ShowUpgradeDuration`
    - `ShowDiskUsage`
    - `ListSslCertDownloadAddress`
    - `DeleteAuditLog`
    - `ShowRecyclePolicy`
- _解决问题_
  - 无
- _特性变更_
  - 接口`SwitchSlowlogDesensitization`新增请求参数 `X-Language`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`ShowWorkflowExecutionForPage`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListWorkflow`新增响应参数 `enable_stream_response`
  - 接口`UpdateWorkFlow`新增响应参数 `enable_stream_response`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListEndpoints`响应参数`Action`类型调整 `string` -> `array`
  - 接口`DeleteEndpointPolicy`响应参数`Action`类型调整 `string` -> `array`
  - 接口`UpdateEndpointPolicy`:
    - 请求参数`Action`类型调整 `string` -> `array`
    - 响应参数`Action`类型调整 `string` -> `array`

# 3.1.8 2022-11-03

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`NovaCreateServers`请求参数`destination_type`改为非必填

### HuaweiCloud SDK EPS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`MigrateResource`新增请求参数 `region_id`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeGeneralText`:
    - 新增请求参数 `character_mode`
    - 新增响应参数 `confidence`、`char_list`
  - 接口`RecognizeThailandIdcard`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`

# 3.1.7 2022-11-02

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowUrlTaskInfo`:
    - 响应参数`modify_time`类型调整 `int32` -> `int64`
    - 响应参数`create_time`类型调整 `int32` -> `int64`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`UpdateServerBlockDevice`、`RegisterServerMonitor`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`PushTranscriberJobs`请求参数`property`新增枚举值`sichuan_8k_common`
  - 接口`RunTts`请求参数`property`新增枚举值`chinese_huaxiaolong_common`、`chinese_huaxiaorui_common`

# 3.1.6 2022-10-27

### HuaweiCloud SDK BMS

- _新增特性_
  - 支持接口`DeleteServerNics`、`UpdateBaremetalServerInterfaceAttachments`、`AddServerNics`、`ShowServerRemoteConsole`
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
  - 接口`ShowUrlTaskInfo`响应参数`id`类型调整 `int32` -> `int64`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowInstance`:
    - 响应参数`begin_time`类型调整 `string` -> `int64`
    - 响应参数`end_time`类型调整 `string` -> `int64`
    - 响应参数`current_time`类型调整 `string` -> `int64`
    - 响应参数`next_expand_time`类型调整 `string` -> `int64`
    - 响应参数`expand_effect_time`类型调整 `string` -> `int64`
    - 响应参数`expand_interval_time`类型调整 `string` -> `int64`
  - 接口`ResizeInstance`请求参数`new_capacity`类型调整 `int32` -> `integer`
  - 接口`ListMigrationTask`新增响应参数 `target_instance_address`、`migration_method`、`task_name`、`target_instance_id`、`source_instance_name`、`target_instance_name`、`migrate_type`、`created_at`、`source_instance_id`、`task_id`、`data_source`、`status`
  - 接口`ListRedislog`:
    - 新增响应参数 `backup_id`
    - 移除响应参数 `backupId`
  - 接口`ListBackgroundTask`新增响应参数 `enable_show`

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持以下接口：
    - `AddReadonlyNode`
    - `UpgradeDatabaseVersion`
    - `ShowSecondLevelMonitoringStatus`
    - `SwitchSecondLevelMonitoring`
    - `ChangeOpsWindow`
    - `SetRecyclePolicy`
    - `ExpandReplicasetNode`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListConfigurations`新增响应参数 `node_type`
  - 接口`ListInstances`新增响应参数 `patch_available`
  - 接口`ResizeInstanceVolume`新增请求参数 `node_ids`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateServers`新增请求参数 `X-Client-Token`、`batch_create_in_multi_az`
  - 接口`CreatePostPaidServers`新增请求参数 `X-Client-Token`

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateListener`请求参数`tls_ciphers_policy`新增枚举值`tls-1-1`、`tls-1-2`、`tls-1-2-strict`, 移除枚举值` tls-1-1`、` tls-1-2`、` tls-1-2-strict`
  - 接口`DeleteListener`移除请求参数 `cascade`
  - 接口`DeleteLoadbalancer`移除请求参数 `cascade`
  - 接口`ListApiVersions`:
    - 新增响应参数 `versions`
    - 移除响应参数 `id`、`status`
  - 接口`CreateLoadBalancer`移除请求参数 `global_eip_ids`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ShowRestorableList`、`ListRestoreTime`、`DeleteBackup`、`RestoreExistingInstance`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListTags`请求参数`__imagetype`新增枚举值`market`
  - 接口`GlanceListImages`:
    - 请求参数`__imagetype`新增枚举值`market`
    - 响应参数`__imagetype`新增枚举值`market`
  - 接口`GlanceShowImage`响应参数`__imagetype`新增枚举值`market`
  - 接口`GlanceUpdateImage`响应参数`__imagetype`新增枚举值`market`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateMessage`新增请求参数 `properties`
  - 接口`ListDeviceMessages`新增响应参数 `properties`
  - 接口`ShowDeviceMessage`新增响应参数 `properties`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidInstance`:
    - 新增请求参数 `disk_encrypted_enable`、`disk_encrypted_key`
    - 请求参数`engine_version`新增枚举值`2.7`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunCreateVideoModerationJob`的请求参数`frame_interval`类型变更 `float` -> `integer`
  - 接口`RunQueryAudioModerationJob`的响应参数`start_time`、`end_time`类型变更 `integer` -> `float`
  - 接口`RunQueryVideoModerationJob`
    - 响应参数`time`类型变更 `integer` -> `float`
    - 响应参数`start_time`、`end_time`类型变更 `integer` -> `float`

# 3.1.5 2022-09-28

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListDomains`新增响应参数 `domain_id`
  - 接口`CreateDomain`:
    - 新增请求参数 `domain_id`
    - 新增响应参数 `domain_id`
  - 接口`ShowDomainDetail`新增响应参数 `domain_id`
  - 接口`DeleteDomain`新增响应参数 `domain_id`
  - 接口`EnableDomain`新增响应参数 `domain_id`
  - 接口`DisableDomain`新增响应参数 `domain_id`
  - 接口`UpdateDomainOrigin`:
    - 新增请求参数 `domain_id`
    - 新增响应参数 `domain_id`
  - 接口`ShowDomainFullConfig`新增响应参数 `origin_range_status`、`user_agent_filter`、`origin_request_url_rewrite`、`error_code_redirect_rules`
  - 接口`UpdateDomainFullConfig`新增请求参数 `origin_range_status`、`user_agent_filter`、`origin_request_url_rewrite`、`error_code_redirect_rules`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowInstance`:
    - 响应参数`begin_time`类型调整 `string` -> `int64`
    - 响应参数`end_time`类型调整 `string` -> `int64`
    - 响应参数`current_time`类型调整 `string` -> `int64`
    - 响应参数`next_expand_time`类型调整 `string` -> `int64`
    - 响应参数`expand_effect_time`类型调整 `string` -> `int64`
    - 响应参数`expand_interval_time`类型调整 `string` -> `int64`
  - 接口`ResizeInstance`请求参数`new_capacity`类型调整 `int32` -> `integer`
  - 接口`ListMigrationTask`新增响应参数 `target_instance_address`、`migration_method`、`task_name`、`target_instance_id`、`source_instance_name`、`target_instance_name`、`migrate_type`、`created_at`、`source_instance_id`、`task_id`、`data_source`、`status`
  - 接口`ListRedislog`:
    - 新增响应参数 `backup_id`
    - 移除响应参数 `backupId`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFlavors`请求参数`region`改为必填

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeHealthCode`新增响应参数 `type`、`idcard_number`、`phone_number`、`province`、`city`、`vaccination_status`、`pcr_test_result`、`pcr_test_organization`、`pcr_test_time`、`pcr_sampling_time`、`reached_city`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 支持以下接口：
    - `UpdateEndpointServiceName`
    - `UpdateEndpointConnectionsDesc`
    - `BatchAddEndpointServicePermissions`
    - `BatchRemoveEndpointServicePermissions`
    - `UpdateEndpointServicePermissionDesc`
    - `UpdateEndpointPolicy`
    - `DeleteEndpointPolicy`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateEndpointService`:
    - 新增请求参数 `description`
    - 新增响应参数 `description`
  - 接口`ListEndpointService`:
    - 新增请求参数 `public_border_group`
    - 新增响应参数 `description`、`public_border_group`
    - 响应参数`service_type`类型调整 `string` -> `enum`
    - 响应参数`server_type`类型调整 `enum` -> `string`
  - 接口`UpdateEndpointService`:
    - 新增请求参数 `description`
    - 新增响应参数 `description`
  - 接口`ListServiceDetails`:
    - 新增响应参数 `description`
    - 响应参数`service_type`类型调整 `string` -> `enum`
  - 接口`ListServiceConnections`移除响应参数 `id`、`marker_id`、`created_at`、`updated_at`、`domain_id`、`status`
  - 接口`AcceptOrRejectEndpoint`新增响应参数 `description`
  - 接口`ListServicePermissionsDetails`移除响应参数 `id`、`permission`、`created_at`
  - 接口`CreateEndpoint`:
    - 新增请求参数 `description`
    - 新增响应参数 `specification_name`、`description`、`policy_statement`、`enable_status`
  - 接口`ListEndpoints`:
    - 新增请求参数 `public_border_group`
    - 新增响应参数 `description`、`policy_statement`、`endpoint_pool_id`、`public_border_group`
  - 接口`ListEndpointInfoDetails`新增响应参数 `description`、`policy_statement`
  - 接口`ListVersionDetails`移除响应参数 `status`、`id`、`updated`、`version`、`min_version`、`links`
  - 接口`ListSpecifiedVersionDetails`移除响应参数 `status`、`id`、`updated`、`version`、`min_version`、`links`
  - 接口`ListResourceInstances`:
    - 新增请求参数 `sys_tags`、`without_any_tag`
    - 移除请求参数 `key`、`value`、`key`、`value`、`key`、`value`、`key`、`value`

# 3.1.4 2022-09-26

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateDependency`新增响应参数 `version`、`last_modified`
  - 接口`ListDependencies`新增响应参数 `version`、`last_modified`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `disk_encrypted_key`、`public_management_connect_address`、`subnet_cidr`、`subnet_name`、`enable_acl`
  - 接口`ShowInstance`新增响应参数 `disk_encrypted_key`、`public_management_connect_address`、`subnet_cidr`、`subnet_name`、`enable_acl`
  - 接口`ResizeInstance`新增请求参数 `oper_type`、`new_broker_num`、`new_product_id`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 修复接口`CheckImageModeration`响应参数类型错误的问题
- _特性变更_
  - 无

# 3.1.3 2022-09-22

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateEvents`新增请求参数 `event_type`
  - 接口`ListEventDetail`新增响应参数 `event_type`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePublicip`新增请求参数 `port_id`
  - 接口`CreatePrePaidPublicip`新增请求参数 `port_id`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListDeviceMessages`新增响应参数 `error_info`
  - 接口`ShowDeviceMessage`新增响应参数 `error_info`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`CheckImageModeration`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunCreateAudioModerationJob`请求参数`url`、`categories`改为必填

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeIdCard`:
    - 新增请求参数 `detect_copy`
    - 新增响应参数 `detect_copy_result`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`DownloadImageFile`、`ListScrumProjectStatuses`、`UploadAttachments`
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
  - 接口`BatchRestartOrDeleteInstances`请求参数`all_failure`新增枚举值`rabbitmq`, 移除枚举值`true`、`false`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`PublishAssets`新增响应参数 `pack_type`、`pack_type`
  - 接口`UnpublishAssets`新增响应参数 `pack_type`、`pack_type`
  - 接口`ShowAssetMeta`新增响应参数 `pack_type`、`pack_type`
  - 接口`ShowAssetDetail`新增响应参数 `pack_type`、`pack_type`
  - 接口`ShowTakeOverTaskDetails`新增响应参数 `pack_type`、`pack_type`
  - 接口`ShowTakeOverAssetDetails`新增响应参数 `pack_type`、`pack_type`

# 3.1.2 2022-09-15

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowTags`、`CreateTags`、`BatchDeleteTags`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowUrlTaskInfo`:
    - 新增响应参数 `result`
    - 移除响应参数 `results`
  - 接口`ShowDomainFullConfig`新增响应参数 `error_code_cache`
  - 接口`UpdateDomainFullConfig`新增请求参数 `error_code_cache`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowInstance`新增响应参数 `enterprise_project_name`、`update_at`、`product_type`、`storage_type`、`launched_at`、`cache_mode`、`support_slow_log_flag`、`db_number`、`replica_count`、`sharding_count`、`bandwidth_info`
  - 接口`ListRedislog`新增响应参数 `backupId`
  - 接口`ShowIpWhitelist`新增响应参数 `instance_id`
  - 接口`UpdateIpWhitelist`新增请求参数 `instance_id`
  - 接口`ListBackgroundTask`新增响应参数 `updated_at`、`created_at`、`status`

### HuaweiCloud SDK EVS

- _新增特性_
  - 支持以下接口：
    - `ShowVersion`
    - `ListVersions`
    - `CinderShowVolumeTransfer`
    - `CinderDeleteVolumeTransfer`
    - `CinderListVolumeTransfers`
    - `CinderCreateVolumeTransfer`
    - `CinderAcceptVolumeTransfer`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`RunCreateVideoModerationJob`、`RunQueryVideoModerationJob`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunCreateAudioModerationJob`请求参数`url`改为非必填

# 3.1.1 2022-09-08

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowTags`、`CreateTags`、`BatchDeleteTags`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowUrlTaskInfo`:
    - 新增响应参数 `result`
    - 移除响应参数 `results`
  - 接口`ShowDomainFullConfig`新增响应参数 `error_code_cache`
  - 接口`UpdateDomainFullConfig`新增请求参数 `error_code_cache`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowInstance`新增响应参数 `enterprise_project_name`、`update_at`、`product_type`、`storage_type`、`launched_at`、`cache_mode`、`support_slow_log_flag`、`db_number`、`replica_count`、`sharding_count`、`bandwidth_info`
  - 接口`ListRedislog`新增响应参数 `backupId`
  - 接口`ShowIpWhitelist`新增响应参数 `instance_id`
  - 接口`UpdateIpWhitelist`新增请求参数 `instance_id`
  - 接口`ListBackgroundTask`新增响应参数 `updated_at`、`created_at`、`status`

### HuaweiCloud SDK EVS

- _新增特性_
  - 支持以下接口：
    - `ShowVersion`
    - `ListVersions`
    - `CinderShowVolumeTransfer`
    - `CinderDeleteVolumeTransfer`
    - `CinderListVolumeTransfers`
    - `CinderCreateVolumeTransfer`
    - `CinderAcceptVolumeTransfer`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`RunCreateVideoModerationJob`、`RunQueryVideoModerationJob`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunCreateAudioModerationJob`请求参数`url`改为非必填

# 3.0.104 2022-09-01

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateDependency`移除响应参数 `version`、`last_modified`
  - 接口`ListDependencies`移除响应参数 `version`、`last_modified`

### HuaweiCloud SDK IAM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateDomainProtectPolicy`:
    - 新增请求参数 `allow_user`、`mobile`、`admin_check`、`email`、`scene`
    - 移除响应参数 `operation_protection`
  - 接口`ShowDomainProtectPolicy`移除响应参数 `operation_protection`
  - 接口`UpdateDomainPasswordPolicy`请求参数`maximum_consecutive_identical_chars`、`minimum_password_age`、`minimum_password_length`、`number_of_recent_passwords_disallowed`、`password_not_username_or_invert`、`password_validity_period`、`password_char_combination`改为非必填
  - 接口`UpdateDomainLoginPolicy`请求参数`account_validity_period`、`custom_info_for_login`、`lockout_duration`、`login_failed_times`、`period_with_login_failures`、`session_timeout`、`show_recent_login_info`改为非必填
  - 接口`ShowDomainQuota`请求参数`type`新增枚举值`mapping`

# 3.0.103 2022-08-29

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidServers`新增请求参数 `batch_create_in_multi_az`

### HuaweiCloud SDK IMS

- _新增特性_
  - 支持接口`ShowJobProgress`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.102 2022-08-25

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `ListMasterSlavePools`
    - `CreateMasterSlavePool`
    - `ShowMasterSlavePool`
    - `DeleteMasterSlavePool`
  - 接口`ListLoadBalancers`新增响应参数 `waf_failure_action`
  - 接口`CreateLoadBalancer`新增请求参数 `waf_failure_action`
  - 接口`ShowLoadBalancer`新增响应参数 `waf_failure_action`
  - 接口`UpdateLoadBalancer`:
    - 新增请求参数 `waf_failure_action`
    - 新增响应参数 `waf_failure_action`
    - 移除请求参数 `cloud_service_console_url`
  - 接口`ListCertificates`新增响应参数 `enc_certificate`、`enc_private_key`
  - 接口`CreateCertificate`新增请求参数 `enc_certificate`、`enc_private_key`
  - 接口`ShowCertificate`新增响应参数 `enc_certificate`、`enc_private_key`
  - 接口`UpdateCertificate`:
    - 新增请求参数 `enc_certificate`、`enc_private_key`
    - 新增响应参数 `enc_certificate`、`enc_private_key`
  - 接口`ListListeners`新增响应参数 `sni_match_algo`
  - 接口`CreateListener`新增请求参数 `sni_match_algo`
  - 接口`ShowListener`新增响应参数 `sni_match_algo`
  - 接口`UpdateListener`:
    - 新增请求参数 `sni_match_algo`
    - 新增响应参数 `sni_match_algo`
  - 接口`ListMembers`新增请求参数 `instance_id`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeWebImage`:
    - 新增请求参数 `detect_font`
    - 新增响应参数 `font_list`、`font_scores`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CheckMd5Duplication`请求参数`size`类型调整 `int32` -> `int64`

# 3.0.101 2022-08-18

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`ListServersByTag`
- _解决问题_
  - 无
- _特性变更_
  - 接口`NovaCreateServers`请求参数`destination_type`改为必填

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateFunction`:
    - 新增响应参数 `enable_dynamic_memory`、`is_stateful_function`、`enable_auth_in_header`、`custom_image`
    - 请求参数`file`、`link`改为必填
    - 响应参数`user_id`类型调整 `int32` -> `string`
    - 响应参数`user_group_id`类型调整 `int32` -> `string`
    - 响应参数`concurrent_num`改为必填
    - 响应参数`mount_share_path`改为非必填
  - 接口`ListFunctions`:
    - 新增响应参数 `fail_count`
    - 移除请求参数 `X-Auth-Token`
    - 响应参数`concurrent_num`改为必填
  - 接口`ShowFunctionCode`:
    - 移除响应参数 `id`
    - 响应参数`file`、`link`、`concurrent_num`改为必填
  - 接口`UpdateFunctionCode`:
    - 移除响应参数 `id`
    - 请求参数`file`、`link`改为必填
    - 响应参数`file`、`link`、`concurrent_num`改为必填
  - 接口`ShowFunctionConfig`:
    - 新增响应参数 `is_stateful_function`、`enable_auth_in_header`、`custom_image`
    - 移除响应参数 `id`
    - 响应参数`user_id`类型调整 `int32` -> `string`
    - 响应参数`user_group_id`类型调整 `int32` -> `string`
    - 响应参数`concurrent_num`改为必填
    - 响应参数`mount_share_path`改为非必填
  - 接口`UpdateFunctionConfig`:
    - 新增响应参数 `enable_auth_in_header`、`custom_image`
    - 移除请求参数 `X-Auth-Token`
    - 移除响应参数 `id`
    - 请求参数`user_id`类型调整 `int32` -> `string`
    - 请求参数`user_group_id`类型调整 `int32` -> `string`
    - 请求参数`concurrent_num`改为必填
    - 请求参数`mount_share_path`改为非必填
    - 响应参数`user_id`类型调整 `int32` -> `string`
    - 响应参数`user_group_id`类型调整 `int32` -> `string`
    - 响应参数`concurrent_num`改为必填
    - 响应参数`mount_share_path`改为非必填
  - 接口`UpdateFunctionMaxInstanceConfig`:
    - 移除响应参数 `id`
    - 响应参数`user_id`类型调整 `int32` -> `string`
    - 响应参数`user_group_id`类型调整 `int32` -> `string`
    - 响应参数`concurrent_num`改为必填
    - 响应参数`mount_share_path`改为非必填
  - 接口`CreateFunctionVersion`:
    - 移除响应参数 `id`
    - 响应参数`user_id`类型调整 `int32` -> `string`
    - 响应参数`user_group_id`类型调整 `int32` -> `string`
    - 响应参数`concurrent_num`改为必填
    - 响应参数`mount_share_path`改为非必填
  - 接口`ListFunctionVersions`:
    - 新增响应参数 `is_stateful_function`、`enable_auth_in_header`、`custom_image`、`reserved_instance_idle_mode`
    - 移除响应参数 `log_group_id`、`log_stream_id`
    - 响应参数`concurrent_num`改为必填
  - 接口`CreateFunctionTrigger`请求参数`trigger_type_code`新增枚举值`SMN`、`RABBITMQ`、`DEDICATEDGATEWAY`、`OPENSOURCEKAFKA`、`APIC`、`GAUSSMONGO`、`EVENTGRID`
  - 接口`ListFunctionTriggers`:
    - 响应参数`trigger_type_code`新增枚举值`RABBITMQ`、`DEDICATEDGATEWAY`、`OPENSOURCEKAFKA`、`APIC`、`GAUSSMONGO`、`EVENTGRID`
    - 响应参数`trigger_status`新增枚举值`DISABLE`, 移除枚举值`DISABLED`
  - 接口`DeleteFunctionTrigger`请求参数`trigger_type_code`新增枚举值`RABBITMQ`、`DEDICATEDGATEWAY`、`OPENSOURCEKAFKA`、`APIC`、`GAUSSMONGO`、`EVENTGRID`
  - 接口`ShowFunctionTrigger`:
    - 请求参数`trigger_type_code`新增枚举值`RABBITMQ`、`DEDICATEDGATEWAY`、`OPENSOURCEKAFKA`、`APIC`、`GAUSSMONGO`、`EVENTGRID`
    - 响应参数`trigger_type_code`新增枚举值`RABBITMQ`、`DEDICATEDGATEWAY`、`OPENSOURCEKAFKA`、`APIC`、`GAUSSMONGO`、`EVENTGRID`
    - 响应参数`trigger_status`新增枚举值`DISABLE`, 移除枚举值`DISABLED`
  - 接口`UpdateTrigger`:
    - 请求参数`trigger_status`新增枚举值`DISABLE`, 移除枚举值`DISABLED`
    - 请求参数`trigger_type_code`新增枚举值`RABBITMQ`、`DEDICATEDGATEWAY`、`OPENSOURCEKAFKA`、`APIC`、`GAUSSMONGO`、`EVENTGRID`
    - 请求参数`trigger_status`改为非必填
  - 接口`ListStatistics`响应参数`value`类型调整 `float` -> `int32`
  - 接口`UpdateFunctionReservedInstancesCount`:
    - 新增请求参数 `UpdateFunctionReservedInstancesCountRequestBody`
    - 新增响应参数 `idle_mode`、`tactics_config`
    - 移除请求参数 `UpdateFunctionReservedInstancesRequestBody`
  - 接口`CreateDependency`:
    - 新增响应参数 `version`、`last_modified`
    - 响应参数`runtime`类型调整 `enum` -> `string`
  - 接口`ListDependencies`:
    - 新增请求参数 `maxitems`、`ispublic`
    - 新增响应参数 `version`、`last_modified`
    - 响应参数`count`类型调整 `int32` -> `int64`
  - 接口`ShowDependcy`:
    - 新增响应参数 `version`、`last_modified`
    - 响应参数`runtime`类型调整 `enum` -> `string`
  - 接口`UpdateDependcy`:
    - 新增请求参数 `UpdateDependcyRequestBody`
    - 移除请求参数 `UpdateDependencyRequestBody`
    - 响应参数`runtime`类型调整 `enum` -> `string`
  - 接口`CreateEvent`移除响应参数 `content`、`last_modified`
  - 接口`UpdateEvent`移除响应参数 `content`、`last_modified`
  - 接口`ImportFunction`:
    - 新增请求参数 `package`
    - 移除请求参数 `X-Auth-Token`
    - 响应参数`concurrent_num`改为必填
  - 接口`EnableLtsLogs`新增请求参数 `X-Auth-Token`
  - 接口`ShowLtsLogDetails`新增响应参数 `group_name`
  - 接口`CancelAsyncInvocation`请求参数`request_id`改为必填
  - 接口`CreateWorkflow`:
    - 新增请求参数 `duration`
    - 请求参数`trigger_type`新增枚举值`SMN`、`APIG`、`APIG_DE`
  - 接口`ListWorkflow`:
    - 新增请求参数 `enterprise_project`、`mode`
    - 移除响应参数 `id`、`workflow_urn`、`name`、`description`、`created_time`、`updated_time`、`created_by`
  - 接口`StartWorkflowExecution`新增请求参数 `X-WorkflowRun-MergeFnParameters`
  - 接口`ListWorkflowExecutions`移除响应参数 `workflow_id`、`workflow_urn`、`execution_id`、`status`、`begin_time`、`end_time`、`last_update_time`、`created_by`
  - 接口`ShowWorkflowExecution`:
    - 新增请求参数 `X-Get-Workflow-Full-History-Data`
    - 响应参数`workflow_urn`类型调整 `string` -> `object`
  - 接口`ShowWorkFlow`:
    - 移除响应参数 `name`、`description`、`triggers`、`start`、`functions`、`states`、`constants`、`retries`、`mode`、`express_config`、`enterprise_project_id`
    - 响应参数`workflow_urn`类型调整 `string` -> `object`
    - 响应参数`id`、`workflow_urn`、`created_time`、`updated_time`、`created_by`改为必填
  - 接口`UpdateWorkFlow`:
    - 新增请求参数 `duration`
    - 请求参数`trigger_type`新增枚举值`SMN`、`APIG`、`APIG_DE`
    - 响应参数`workflow_urn`类型调整 `string` -> `object`
    - 响应参数`id`、`workflow_urn`、`name`、`description`、`created_time`、`updated_time`、`created_by`改为必填

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeIdCard`:
    - 新增请求参数 `detect_reproduce`
    - 新增响应参数 `detect_reproduce_result`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateIssueV4`:
    - 新增请求参数 `field_name`
    - 新增响应参数 `field_name`
  - 接口`ListIssuesV4`新增响应参数 `field_name`
  - 接口`UpdateIssueV4`:
    - 新增请求参数 `field_name`
    - 新增响应参数 `field_name`
  - 接口`ListChildIssuesV4`新增响应参数 `field_name`
  - 接口`CreateSystemIssueV4`:
    - 新增请求参数 `field_name`
    - 新增响应参数 `field_name`

### HuaweiCloud SDK VOD

- _新增特性_
  - 支持以下接口：
    - `ListTranscodeTemplate`
    - `UpdateTranscodeTemplate`
    - `CreateTranscodeTemplate`
    - `DeleteTranscodeTemplate`
    - `ListTemplateGroupCollection`
    - `UpdateTemplateGroupCollection`
    - `CreateTemplateGroupCollection`
    - `DeleteTemplateGroupCollection`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.100 2022-08-11

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowUrlTaskInfo`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowDomainFullConfig`新增响应参数 `ipv6_accelerate`
  - 接口`UpdateDomainFullConfig`新增请求参数 `ipv6_accelerate`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidInstance`:
    - 新增请求参数 `broker_num`
    - 请求参数`specification`新增枚举值`c6.2u4g.cluster`、`c6.4u8g.cluster`、`c6.8u16g.cluster`、`c6.12u24g.cluster`、`c6.16u32g.cluster`
    - 请求参数`partition_num`新增枚举值`250`、`500`、`1000`、`1500`、`2000`
    - 请求参数`storage_spec_code`新增枚举值`dms.physical.storage.high.v2`、`dms.physical.storage.ultra.v2`
    - 请求参数`specification`改为非必填
  - 接口`ListInstances`新增响应参数 `description`、`access_user`、`ssl_two_way_enable`、`cert_replaced`、`public_boundwidth`、`agent_enable`、`public_access_enabled`、`node_num`、`new_spec_billing_enable`、`broker_num`
  - 接口`ShowInstance`新增响应参数 `description`、`access_user`、`ssl_two_way_enable`、`cert_replaced`、`public_boundwidth`、`agent_enable`、`public_access_enabled`、`node_num`、`new_spec_billing_enable`、`broker_num`
  - 接口`ShowInstanceExtendProductInfo`请求参数`engine`改为非必填
  - 接口`ShowPartitionBeginningMessage`:
    - 新增响应参数 `offset`
    - 移除响应参数 `message_offset`
  - 接口`ShowPartitionEndMessage`:
    - 新增响应参数 `offset`
    - 移除响应参数 `message_offset`
  - 接口`ListEngineProducts`新增响应参数 `product_alias`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`RunCreateAudioModerationJob`、`RunQueryAudioModerationJob`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunImageModeration`移除请求参数 `ad_glossaries`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeMacaoIdCard`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK SWR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListNamespaces`新增请求参数 `filter`
  - 接口`ListReposDetails`新增请求参数 `limit`、`offset`、`order_column`、`order_type`
  - 接口`ListRepositoryTags`新增请求参数 `filter`
  - 接口`ListSharedReposDetails`新增请求参数 `namespace`、`name`、`center`、`limit`、`offset`、`order_column`、`order_type`
  - 接口`ListRetentionHistories`:
    - 新增请求参数 `filter`
    - 移除请求参数 `offset`、`limit`

# 3.0.99 2022-08-02

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`UpgradeDbVersion`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `patch_available`

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunImageDescription`移除请求参数 `language`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`CreateProjectDomain`、`ListProjectDomains`、`UpdateProjectDomain`、`CancelProjectDomain`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeShortAudio`请求参数`audio_format`新增枚举值`auto`

# 3.0.98 2022-07-28

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`ShowDedicatedResourceInfo`、`SetGaussMySqlProxyWeight`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowGaussMySqlProxy`新增响应参数 `proxy`、`master_node`、`readonly_nodes`
  - 接口`ShowGaussMySqlProxyList`新增响应参数 `proxy_list`
  - 接口`ShowGaussMySqlProxyFlavors`新增响应参数 `proxy_flavor_groups`
  - 接口`ShowGaussMySqlBackupList`:
    - 响应参数`status`新增枚举值`BUILDING`、`COMPLETED`、`FAILED`、`AVAILABLE`
    - 响应参数`type`新增枚举值`auto`、`manual`
    - 响应参数`backup_level`新增枚举值`0`、`1`、`2`

### HuaweiCloud SDK KMS

- _新增特性_
  - 支持以下接口：
    - `ListKeyStores`
    - `CreateKeyStore`
    - `ShowKeyStore`
    - `DeleteKeyStore`
    - `EnableKeyStore`
    - `DisableKeyStore`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateKey`新增请求参数 `keystore_id`
  - 接口`ListKeys`新增响应参数 `keystore_id`、`key_label`
  - 接口`ListKeyDetail`新增响应参数 `keystore_id`、`key_label`
  - 接口`ListKmsByTags`新增响应参数 `keystore_id`、`key_label`

# 3.0.97 2022-07-21

### HuaweiCloud SDK Core

- _新增特性_
  - 无
- _解决问题_
  - 解决响应数据解码失败的问题
- _特性变更_
  - 无

### HuaweiCloud SDK CES

- _新增特性_
  - 支持以下接口：
    - `ListAlarmRules`
    - `CreateAlarmRules`
    - `BatchDeleteAlarmRules`
    - `BatchEnableAlarmRules`
    - `ListAlarmRuleResources`
    - `DeleteAlarmRuleResources`
    - `AddAlarmRuleResources`
    - `ListAlarmRulePolicies`
    - `UpdateAlarmRulePolicies`
    - `ListAgentDimensionInfo`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListAlarmHistories`:
    - 新增响应参数 `datapoints`
    - 移除响应参数 `data_points`、`type`、`notification_list`、`type`、`notification_list`
    - 响应参数`status`类型调整 `string` -> `enum`
    - 响应参数`level`类型调整 `int32` -> `enum`
    - 响应参数`type`类型调整 `string` -> `enum`
    - 响应参数`period`类型调整 `integer` -> `enum`
    - 响应参数`value`类型调整 `float` -> `double`
    - 响应参数`suppress_duration`类型调整 `integer` -> `enum`

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`RunImageDescription`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`NeutronListSecurityGroupRules`新增响应参数 `security_group_rules_links`

# 3.0.96 2022-07-14

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateDomainFullConfig`新增请求参数 `tls_version`
  - 接口`ShowDomainFullConfig`新增响应参数 `tls_version`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowInstance`新增响应参数 `tags`、`cpu_type`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListPublicips`响应参数`create_time`类型调整 `date-time` -> `string`
  - 接口`ShowPublicip`响应参数`create_time`类型调整 `date-time` -> `string`

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`RunImageMediaTagging`、`RunImageMainObjectDetection`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListPorts`新增响应参数 `port_filter`、`ovs_hybrid_plug`
  - 接口`UpdatePort`新增响应参数 `port_filter`、`ovs_hybrid_plug`
  - 接口`ShowPort`新增响应参数 `port_filter`、`ovs_hybrid_plug`
  - 接口`CreateSecurityGroup`新增响应参数 `remote_address_group_id`
  - 接口`ListSecurityGroups`新增响应参数 `remote_address_group_id`
  - 接口`ShowSecurityGroup`新增响应参数 `remote_address_group_id`
  - 接口`ListSecurityGroupRules`新增响应参数 `remote_address_group_id`
  - 接口`ShowSecurityGroupRule`新增响应参数 `remote_address_group_id`
  - 接口`NeutronListSecurityGroups`新增响应参数 `remote_address_group_id`
  - 接口`NeutronUpdateSecurityGroup`新增响应参数 `remote_address_group_id`
  - 接口`NeutronShowSecurityGroup`新增响应参数 `remote_address_group_id`
  - 接口`NeutronListSecurityGroupRules`新增响应参数 `remote_address_group_id`
  - 接口`NeutronShowSecurityGroupRule`新增响应参数 `remote_address_group_id`

# 3.0.95 2022-07-07

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`UpdateClusterEip`、`ShowClusterEndpoints`、`ShowVersion`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListNodes`:
    - 新增响应参数 `isStatic`、`privateIPv6IP`
    - 响应参数`key`、`effect`改为必填
  - 接口`CreateNode`:
    - 新增请求参数 `isStatic`
    - 请求参数`key`、`effect`改为必填
  - 接口`ShowNode`:
    - 新增响应参数 `isStatic`、`privateIPv6IP`
    - 响应参数`key`、`effect`改为必填
  - 接口`DeleteNode`:
    - 新增响应参数 `isStatic`、`privateIPv6IP`
    - 响应参数`key`、`effect`改为必填
  - 接口`UpdateNode`:
    - 新增响应参数 `isStatic`、`privateIPv6IP`
    - 响应参数`key`、`effect`改为必填
  - 接口`AddNode`请求参数`key`、`effect`改为必填
  - 接口`ResetNode`请求参数`key`、`effect`改为必填
  - 接口`ListNodePools`:
    - 新增响应参数 `isStatic`
    - 响应参数`key`、`effect`改为必填
  - 接口`CreateNodePool`:
    - 新增请求参数 `isStatic`
    - 请求参数`key`、`effect`改为必填
  - 接口`ShowNodePool`:
    - 新增响应参数 `isStatic`
    - 响应参数`key`、`effect`改为必填
  - 接口`DeleteNodePool`:
    - 新增响应参数 `isStatic`
    - 响应参数`key`、`effect`改为必填
  - 接口`UpdateNodePool`:
    - 新增响应参数 `isStatic`
    - 请求参数`key`、`effect`改为必填
    - 响应参数`key`、`effect`改为必填

### HuaweiCloud SDK ELB

- _新增特性_
  - 支持接口`ListMasterSlavePools`、`CreateMasterSlavePool`、`ShowMasterSlavePool`、`DeleteMasterSlavePool`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListSystemSecurityPolicies`:
    - 响应参数`protocols`类型调整 `array` -> `string`
    - 响应参数`ciphers`类型调整 `array` -> `string`
  - 接口`ListQuotaDetails`新增请求参数 `X-Auth-Token`
  - 接口`ListAvailabilityZones`新增请求参数 `public_border_group`
  - 接口`CreateLoadBalancer`:
    - 新增请求参数 `id`、`global_eip_ids`
    - 移除请求参数 `min_l4_flavor_id`
    - 请求参数`X-Auth-Token`改为必填
  - 接口`ListLoadBalancers`:
    - 新增响应参数 `global_eips`、`public_border_group`
    - 移除响应参数 `min_l4_flavor_id`
    - 请求参数`X-Auth-Token`改为必填
  - 接口`UpdateLoadBalancer`:
    - 新增请求参数 `cloud_service_console_url`
    - 新增响应参数 `global_eips`、`public_border_group`
    - 移除请求参数 `min_l4_flavor_id`
    - 移除响应参数 `min_l4_flavor_id`
  - 接口`ShowLoadBalancer`:
    - 新增响应参数 `global_eips`、`public_border_group`
    - 移除响应参数 `min_l4_flavor_id`
  - 接口`ChangeLoadbalancerChargeMode`新增请求参数 `X-Auth-Token`
  - 接口`CreateCertificate`移除请求参数 `enc_certificate`、`enc_private_key`
  - 接口`ListCertificates`移除响应参数 `enc_certificate`、`enc_private_key`
  - 接口`UpdateCertificate`:
    - 移除请求参数 `enc_certificate`、`enc_private_key`
    - 移除响应参数 `enc_certificate`、`enc_private_key`
  - 接口`ShowCertificate`移除响应参数 `enc_certificate`、`enc_private_key`
  - 接口`CreateListener`新增请求参数 `quic_config`
  - 接口`ListListeners`新增响应参数 `quic_config`
  - 接口`UpdateListener`:
    - 新增请求参数 `quic_config`
    - 新增响应参数 `quic_config`
  - 接口`ShowListener`新增响应参数 `quic_config`
  - 接口`CreatePool`新增请求参数 `vpc_id`、`type`
  - 接口`ListPools`:
    - 新增请求参数 `vpc_id`、`type`
    - 新增响应参数 `created_at`、`updated_at`、`vpc_id`、`type`
  - 接口`UpdatePool`:
    - 新增请求参数 `X-Auth-Token`、`vpc_id`、`type`
    - 新增响应参数 `created_at`、`updated_at`、`vpc_id`、`type`
  - 接口`ShowPool`新增响应参数 `created_at`、`updated_at`、`vpc_id`、`type`
  - 接口`CreateMember`请求参数`project_id`类型调整 `enum` -> `string`
  - 接口`ListMembers`:
    - 新增响应参数 `status`、`loadbalancers`、`created_at`、`updated_at`
    - 移除请求参数 `instance_id`
  - 接口`UpdateMember`新增响应参数 `status`、`loadbalancers`、`created_at`、`updated_at`
  - 接口`ShowMember`新增响应参数 `status`、`loadbalancers`、`created_at`、`updated_at`
  - 接口`ListAllMembers`新增响应参数 `status`、`loadbalancers`、`created_at`、`updated_at`
  - 接口`ListHealthMonitors`新增响应参数 `created_at`、`updated_at`
  - 接口`UpdateHealthMonitor`新增响应参数 `created_at`、`updated_at`
  - 接口`ShowHealthMonitor`新增响应参数 `created_at`、`updated_at`
  - 接口`CreateL7Policy`新增请求参数 `redirect_pools_config`
  - 接口`ListL7Policies`新增响应参数 `redirect_pools_config`、`created_at`、`updated_at`
  - 接口`UpdateL7Policy`:
    - 新增请求参数 `redirect_pools_config`
    - 新增响应参数 `redirect_pools_config`、`created_at`、`updated_at`
  - 接口`ShowL7Policy`新增响应参数 `redirect_pools_config`、`created_at`、`updated_at`
  - 接口`BatchUpdatePoliciesPriority`新增请求参数 `X-Auth-Token`
  - 接口`ListL7Rules`新增响应参数 `created_at`、`updated_at`
  - 接口`UpdateL7Rule`新增响应参数 `created_at`、`updated_at`
  - 接口`ShowL7Rule`新增响应参数 `created_at`、`updated_at`
  - 接口`UpdateIpList`:
    - 移除请求参数 `name`、`ip_list`、`description`
    - 请求参数`X-Auth-Token`改为必填
  - 接口`BatchDeleteIpList`:
    - 新增请求参数 `BatchDeleteIpListRequestBody`
    - 移除请求参数 `BatchDeleteIpGroupIpListRequestBody`
    - 请求参数`X-Auth-Token`改为必填
  - 接口`BatchCreateMembers`:
    - 新增请求参数 `BatchCreateMembersRequestBody`
    - 新增响应参数 `status`
    - 移除请求参数 `BatchCreateMemberRequestBody`
  - 接口`BatchDeleteMembers`:
    - 新增请求参数 `BatchDeleteMembersRequestBody`
    - 移除请求参数 `BatchDeleteMemberRequestBody`
  - 接口`UpdateLogtank`:
    - 新增请求参数 `UpdateLogtankRequestBody`
    - 移除请求参数 `logtank`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeVatInvoice`新增响应参数 `title`

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeShortAudio`请求参数`property`新增枚举值`chinese_16k_travel`
  - 接口`PushTranscriberJobs`请求参数`property`新增枚举值`chinese_16k_media`
  - 接口`CollectTranscriberJob`新增响应参数 `audio_duration`
  - 接口`RunTts`请求参数`property`新增枚举值`chinese_huaxiaomei_common`、`chinese_huaxiaofei_common`

# 3.0.94 2022-06-30

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowDomainFullConfig`新增响应参数 `cache_url_parameter_filter`
  - 接口`UpdateDomainFullConfig`新增请求参数 `cache_url_parameter_filter`

### HuaweiCloud SDK DNS

- _新增特性_
  - 支持接口`CreateRecordSetWithBatchLines`、`BatchUpdateRecordSetWithLine`、`BatchDeleteRecordSetWithLine`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateRecordSetWithLine`请求参数`records`改为非必填

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`UpdateFunctionMaxInstanceConfig`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `lb_port`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeHkIdCard`、`RecognizeCambodianIdCard`、`RecognizeExitEntryPermit`、`RecognizeMainlandTravelPermit`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeGeneralText`响应参数`direction`类型调整 `int32` -> `float`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`CreateProjectModule`、`ListProjectModules`、`UpdateProjectModule`、`DeleteProjectModule`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.93 2022-06-25

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持以下接口：
    - `ShowEntityConfiguration`
    - `UpdateEntityConfiguration`
    - `ShowConfigurationParameter`
    - `UpdateConfigurationParameter`
    - `DeleteConfiguration`
    - `ListConfigurations`
    - `CreateConfiguration`
    - `SwitchConfiguration`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateInstance`新增请求参数 `configurations`、`charge_info`
  - 接口`ResizeInstanceVolume`:
    - 新增请求参数 `is_auto_pay`
    - 新增响应参数 `order_id`
  - 接口`AddShardingNode`:
    - 新增请求参数 `is_auto_pay`
    - 新增响应参数 `order_id`
  - 接口`ResizeInstance`:
    - 新增请求参数 `is_auto_pay`
    - 新增响应参数 `order_id`
  - 接口`RestoreNewInstance`新增请求参数 `configurations`、`charge_info`

# 3.0.92 2022-06-23

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListQuotaDetails`:
    - 新增请求参数 `quota_key`
    - 移除请求参数 `type`
  - 接口`ListListeners`:
    - 新增请求参数 `loadbalancer_id`、`connection_limit`、`admin_state_up`、`http2_enable`、`enterprise_project_id`
    - 移除请求参数 `member_timeout`、`client_timeout`、`keepalive_timeout`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `subnet_id`
  - 接口`ExpandInstanceNode`新增请求参数 `subnet_id`

# 3.0.91 2022-06-19

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeIdDocument`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.90 2022-06-09

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateFunctionCode`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`ShowFunctionCode`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`UpdateFunctionConfig`:
    - 新增请求参数 `domain_names`
    - 新增响应参数 `domain_names`
    - 响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`ShowFunctionConfig`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`CreateFunctionVersion`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`ListStatistics`新增请求参数 `option`
  - 接口`CreateDependency`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`ListDependencies`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`UpdateDependency`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`ShowDependency`响应参数`runtime`类型调整 `string` -> `enum`
  - 接口`UpdateEvent`请求参数`content`改为必填
  - 接口`ListFunctionAsyncInvocations`新增请求参数 `marker`
  - 接口`BatchDeleteWorkflows`请求参数`workflow_urns`改为必填
  - 接口`CreateWorkflow`请求参数`name`、`trigger_name`、`trigger_type`、`bucket`、`events`、`prefix`、`suffix`、`start`、`name`、`operation`、`id`、`name`、`type`、`end`、`transition`、`ref_name`、`arguments`、`constants`、`name`改为必填
  - 接口`StartWorkflowExecution`请求参数`input`改为必填
  - 接口`ShowWorkflowExecution`新增响应参数 `node_name`、`execution_id`、`request_id`
  - 接口`UpdateWorkFlow`请求参数`name`、`trigger_name`、`trigger_type`、`bucket`、`events`、`prefix`、`suffix`、`start`、`name`、`operation`、`id`、`name`、`type`、`end`、`transition`、`ref_name`、`arguments`、`constants`、`name`改为必填
  - 接口`ShowWorkFlow`:
    - 新增响应参数 `lts_group_id`、`lts_stream_id`
    - 响应参数`name`、`trigger_name`、`trigger_type`、`bucket`、`events`、`prefix`、`suffix`、`start`、`name`、`operation`、`id`、`name`、`type`、`end`、`transition`、`ref_name`、`arguments`、`constants`、`name`改为必填
  - 接口`StartSyncWorkflowExecution`请求参数`input`改为必填

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`RunTextModeration`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.89 2022-06-02

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFlavors`新增请求参数 `instance_id`

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListNatGateways`:
    - 请求参数`created_at`类型调整 `date-time` -> `string`
    - 响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`UpdateNatGateway`响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`ShowNatGateway`响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`ListNatGatewayDnatRules`:
    - 请求参数`created_at`类型调整 `date-time` -> `string`
    - 响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`UpdateNatGatewayDnatRule`响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`ShowNatGatewayDnatRule`响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`ListNatGatewaySnatRules`:
    - 请求参数`created_at`类型调整 `date-time` -> `string`
    - 响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`UpdateNatGatewaySnatRule`响应参数`created_at`类型调整 `date-time` -> `string`
  - 接口`ShowNatGatewaySnatRule`响应参数`created_at`类型调整 `date-time` -> `string`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeHealthCode`新增响应参数 `words_block_count`、`words_block_list`
  - 接口`RecognizePcrTestRecord`响应参数`confidence`类型调整 `float` -> `object`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持以下接口：
    - `ListIssueCustomFields`
    - `ListIssuesSfV4`
    - `ListProjectIssuesRecordsV4`
    - `ListWorkitemStatusRecordsV4`
    - `ListWorkitems`
    - `ShowIssuesWrokFlowConfig`
    - `ShowWorkItemWrokflowConfig`
    - `ListAssociatedIssues`
    - `ListAssociatedWikis`
    - `ListIssueAssociatedCommits`
    - `ListAssociatedTestCases`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateIssueV4`:
    - 新增请求参数 `new_custom_fields`
    - 新增响应参数 `new_custom_fields`、`new_name`
  - 接口`ListIssuesV4`:
    - 新增请求参数 `custom_fields`
    - 新增响应参数 `new_custom_fields`、`new_name`
  - 接口`ShowIssueV4`新增响应参数 `new_custom_fields`、`new_name`
  - 接口`UpdateIssueV4`:
    - 新增请求参数 `new_custom_fields`
    - 新增响应参数 `new_custom_fields`、`new_name`
  - 接口`ListChildIssuesV4`新增响应参数 `new_custom_fields`、`new_name`
  - 接口`CreateSystemIssueV4`:
    - 新增请求参数 `new_custom_fields`
    - 新增响应参数 `new_custom_fields`、`new_name`

# 3.0.88 2022-05-26

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `features`、`sub_status`
  - 接口`ShowInstance`新增响应参数 `features`、`transparent_client_ip_enable`、`sub_status`
  - 接口`ResizeInstance`新增请求参数 `execute_immediately`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`AttachServerVolume`新增请求参数 `volume_type`、`hw:passthrough`

### HuaweiCloud SDK KMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ValidateSignature`:
    - 新增响应参数 `signature_valid`
    - 移除响应参数 `signature_vaild`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunCheckResult`新增响应参数 `ocr_text`、`error_code`、`error_msg`
  - 接口`RunImageBatchModeration`:
    - 新增请求参数 `moderation_rule`、`ad_categories`、`show_ocr_text`
    - 新增响应参数 `ocr_text`、`error_code`、`error_msg`
  - 接口`RunTaskSumbit`新增请求参数 `moderation_rule`、`ad_categories`、`show_ocr_text`

# 3.0.87 2022-05-19

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ResizeServer`新增请求参数 `dry_run`
  - 接口`ResizePostPaidServer`新增请求参数 `dry_run`
  - 接口`AttachServerVolume`新增请求参数 `dry_run`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UploadMetaDataByUrl`请求参数`video_type`新增枚举值`M3U8`
  - 接口`PublishAssets`新增响应参数 `sign_url`
  - 接口`UnpublishAssets`新增响应参数 `sign_url`
  - 接口`ShowAssetMeta`新增响应参数 `sign_url`
  - 接口`ShowAssetDetail`新增响应参数 `sign_url`
  - 接口`ShowTakeOverTaskDetails`新增响应参数 `sign_url`
  - 接口`ShowTakeOverAssetDetails`新增响应参数 `sign_url`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListPorts`响应参数`device_owner`新增枚举值`neutron:VIP_PORT`, 移除枚举值`network:VIP_PORT`
  - 接口`UpdatePort`响应参数`device_owner`新增枚举值`neutron:VIP_PORT`, 移除枚举值`network:VIP_PORT`
  - 接口`ShowPort`响应参数`device_owner`新增枚举值`neutron:VIP_PORT`, 移除枚举值`network:VIP_PORT`

# 3.0.86 2022-05-12

### HuaweiCloud SDK FRS

- _新增特性_
  - 支持以下接口：
    - `DetectLiveByUrlIntl`
    - `DetectLiveByFileIntl`
    - `DetectLiveByBase64Intl`
    - `DetectFaceByFileIntl`
    - `DetectFaceByUrlIntl`
    - `DetectFaceByBase64Intl`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IAM

- _新增特性_
  - 支持接口`ShowDomainRoleAssignments`
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
  - 接口`RunImageModeration`:
    - 新增请求参数 `show_ocr_text`
    - 新增响应参数 `ocr_text`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeHealthCode`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持分布式消息服务RocketMQ版
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.85 2022-05-05

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunImageModeration`请求参数`image`类型调整 `byte` -> `string`

# 3.0.84 2022-04-28

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`CancelAsyncInvocation`、`StartSyncWorkflowExecution`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFunctionStatistics`:
    - 响应参数`timestamp`类型调整 `int32` -> `int64`
    - 响应参数`value`类型调整 `int32` -> `double`
  - 接口`ListStatistics`:
    - 响应参数`timestamp`类型调整 `int32` -> `int64`
    - 响应参数`value`类型调整 `int32` -> `double`
  - 接口`ListFunctionAsyncInvokeConfig`新增响应参数 `enable_async_status_log`
  - 接口`ShowFunctionAsyncInvokeConfig`新增响应参数 `enable_async_status_log`
  - 接口`UpdateFunctionAsyncInvokeConfig`:
    - 新增请求参数 `enable_async_status_log`
    - 新增响应参数 `enable_async_status_log`
  - 接口`CreateWorkflow`:
    - 新增请求参数 `mode`、`express_config`
    - 请求参数`type`新增枚举值`End`
  - 接口`ShowWorkFlow`:
    - 新增响应参数 `mode`、`express_config`
    - 响应参数`type`新增枚举值`End`
  - 接口`UpdateWorkFlow`:
    - 新增请求参数 `mode`、`express_config`
    - 请求参数`type`新增枚举值`End`
  - 接口`ShowTenantMetric`:
    - 新增请求参数 `start_time`、`end_time`
    - 响应参数`timestamp`类型调整 `int32` -> `int64`
    - 响应参数`value`类型调整 `int32` -> `double`
  - 接口`ShowWorkFlowMetric`:
    - 新增请求参数 `start_time`、`end_time`
    - 响应参数`timestamp`类型调整 `int32` -> `int64`
    - 响应参数`value`类型调整 `int32` -> `double`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 修复接口`RecognizeMyanmarDriverLicense`的响应体类型错误的问题
- _特性变更_
  - 无

# 3.0.83 2022-04-21

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateScalingGroup`新增请求参数 `iam_agency_name`
  - 接口`ListScalingGroups`新增响应参数 `iam_agency_name`
  - 接口`UpdateScalingGroup`新增请求参数 `iam_agency_name`
  - 接口`ShowScalingGroup`新增响应参数 `iam_agency_name`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowInstance`新增响应参数 `domain_name_info`

# 3.0.82 2022-04-14

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateDomainFullConfig`新增请求参数 `sources`、`origin_protocol`、`force_redirect`、`compress`
  - 接口`ShowDomainFullConfig`:
    - 新增响应参数 `sources`、`origin_protocol`、`force_redirect`、`compress`
    - 响应参数`certificate_source`类型调整 `string` -> `int32`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateInstance`新增请求参数 `rename_commands`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListServersDetails`新增请求参数 `ip_eq`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateFunctionConfig`新增请求参数 `encrypted_user_data`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`RunModerationAudio`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.81 2022-04-07

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateNodePool`移除请求参数 `kind`、`apiVersion`、`status`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeWaybillElectronic`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeVatInvoice`新增响应参数 `print_code`
  - 接口`RecognizeVehicleLicense`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`
  - 接口`RecognizeTaxiInvoice`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`
  - 接口`RecognizeDriverLicense`新增响应参数 `type`、`accumulated_scores`、`status`、`generation_date`、`current_time`
  - 接口`RecognizeTrainTicket`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`
  - 接口`RecognizeBankcard`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`

# 3.0.80 2022-03-31

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`BatchShowNodesInformation`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.79 2022-03-25

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持V2版本接口：
    - `ShowDomainLocationStats`
    - `ShowDomainStats`
    - `ShowTopUrl`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListRedislog`新增响应参数 `group_name`、`replication_ip`

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListPublicZones`移除响应参数 `routers`
  - 接口`ShowRecordSetByZone`新增请求参数 `marker`、`limit`、`offset`、`line_id`、`tags`、`status`、`type`、`name`、`id`、`sort_key`、`sort_dir`、`search_mode`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持以下接口：
    - `ListWorkflows`
    - `CreateWorkflow`
    - `BatchDeleteWorkflows`
    - `ListWorkflowExecutions`
    - `StartWorkflowExecution`
    - `ShowWorkflowExecution`
    - `ShowWorkFlow`
    - `UpdateWorkFlow`
    - `ShowTenantMetric`
    - `ShowWorkFlowMetric`
    - `RetryWorkFlow`
    - `StopWorkFlow`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IMS

- _新增特性_
  - 支持接口`ListVersions`、`ShowVersion`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateDataImage`请求参数`os_type`改为非必填

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口 `ResetFingerprint`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeVatInvoice`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`
  - 接口`RecognizeIdCard`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`
  - 接口`RecognizeDriverLicense`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`

# 3.0.78 2022-03-10

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DeleteAddonInstance`请求参数`cluster_id`改为非必填

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowTopUrl`移除请求参数 `X-Auth-Token`
  - 接口`ShowDomainLocationStats`移除请求参数 `X-Auth-Token`
  - 接口`ShowDomainItemDetails`移除请求参数 `X-Auth-Token`
  - 接口`ShowDomainStats`移除请求参数 `X-Auth-Token`
  - 接口`ShowDomainItemLocationDetails`移除请求参数 `X-Auth-Token`

### HuaweiCloud SDK ELB

- _新增特性_
  - 支持以下接口：
    - `ListLogtanks`
    - `CreateLogtank`
    - `ShowLogtank`
    - `UpdateLogtank`
    - `DeleteLogtank`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFlavors`新增响应参数 `https_cps`
  - 接口`ShowFlavor`新增响应参数 `https_cps`
  - 接口`ListLoadBalancers`请求参数`X-Auth-Token`改为非必填
  - 接口`CreateLoadBalancer`请求参数`X-Auth-Token`改为非必填
  - 接口`UpdateIpList`请求参数`X-Auth-Token`改为非必填
  - 接口`BatchDeleteIpList`请求参数`X-Auth-Token`改为非必填

# 3.0.77 2022-03-07

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`UpdateClusterEip`、`ShowClusterEndpoints`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CES

- _新增特性_
  - 支持以下接口 (V2)：
    - `ListAlarms`
    - `CreateAlarm`
    - `DeleteAlarm`
    - `UpdateAlarmAction`
    - `ListAlarmResources`
    - `DeleteAlarmResources`
    - `AddAlarmResources`
    - `AddResourceGroupsResourcesBatch`
    - `DeleteResourceGroupsResourcesBatch`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePrePaidPublicip`的请求参数`ip_version`类型变更： `integer` -> `enum`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShrinkInstanceNode`新增响应参数 `order_id`

# 3.0.76 2022-02-25

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListAllScalingV2Policies`新增请求参数 `alarm_id`
  - 接口`CreateScalingConfig`请求参数`volume_type`新增枚举值`GPSSD`
  - 接口`ShowResourceQuota`新增响应参数 `min`
  - 接口`ShowPolicyAndInstanceQuota`新增响应参数 `min`

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateBaremetalServerMetadata`:
    - 请求体类型修改 `MetaData` -> `UpdateBaremetalServerMetadataReq`
    - 移除响应参数 `key`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowDomainLocationStats`、`ShowDomainFullConfig`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowDomainStats`:
    - 新增请求参数 `service_area`
    - 移除请求参数 `X-Auth-Token`、`country`、`district`、`isp`
    - 移除响应参数 `start_time`、`end_time`、`interval`、`action`、`stat_type`、`group_by`
  - 接口`UpdateDomainFullConfig`新增请求参数 `https`

### HuaweiCloud SDK ELB

- _新增特性_
  - 支持接口`BatchCreateMembers`、`BatchDeleteMembers`
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
  - 接口`ListFunctions`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`CreateFunction`:
    - 请求参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
    - 响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`ShowFunctionCode`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`UpdateFunctionCode`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`ShowFunctionConfig`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`UpdateFunctionConfig`:
    - 请求参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
    - 响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`ListFunctionVersions`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`CreateFunctionVersion`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`
  - 接口`CreateDependency`请求参数`runtime`新增枚举值`Java11`、`Node.js14.18`、`Python3.9`
  - 接口`UpdateDependency`请求参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`PHP 7.3`
  - 接口`ImportFunction`响应参数`runtime`新增枚举值`Java8`、`Java11`、`Node.js6.10`、`Node.js8.10`、`Node.js10.16`、`Node.js12.13`、`Node.js14.18`、`Python2.7`、`Python3.6`、`Python3.9`、`Go1.8`、`Go1.x`、`PHP7.3`, 移除枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`BatchUpdateChildNickNames`、`ListIterationHistories`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListProjectIterationsV4`新增请求参数 `updated_time_interval`、`include_deleted`
  - 接口`ListIssuesV4`新增请求参数 `include_deleted`、`updated_time_interval`
  - 接口`ShowIssueV4`新增响应参数 `description`、`order`、`accessories`

### HuaweiCloud SDK VOD

- _新增特性_
  - 支持接口`ListDomainLogs`
- _解决问题_
  - 无
- _特性变更_
  - 接口`DeleteAssets`新增请求参数 `delete_type`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`NeutronListSubnets`新增响应参数`subnetpool_id`

# 3.0.75 2022-02-10

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListProtectable`:
    - 响应参数`result`类型调整 `string` -> `boolean`
    - 响应参数`size`类型调整 `string` -> `int32`
  - 接口`ShowProtectable`:
    - 响应参数`result`类型调整 `string` -> `boolean`
    - 响应参数`size`类型调整 `string` -> `int32`

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`ShowVersion`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateAddonInstance`移除响应参数 `kind`、`apiVersion`、`metadata`、`spec`、`status`
  - 接口`ListNodes`新增响应参数 `isStatic`、`privateIPv6IP`
  - 接口`CreateNode`新增请求参数 `isStatic`
  - 接口`DeleteNode`新增响应参数 `isStatic`、`privateIPv6IP`
  - 接口`ShowNode`新增响应参数 `isStatic`、`privateIPv6IP`
  - 接口`UpdateNode`新增响应参数 `isStatic`、`privateIPv6IP`
  - 接口`RemoveNode`:
    - 请求参数`uid`改为必填
    - 响应参数`uid`改为必填
  - 接口`MigrateNode`:
    - 请求参数`uid`改为必填
    - 响应参数`uid`改为必填
  - 接口`ListNodePools`新增响应参数 `isStatic`
  - 接口`CreateNodePool`新增请求参数 `isStatic`
  - 接口`DeleteNodePool`新增响应参数 `isStatic`
  - 接口`ShowNodePool`新增响应参数 `isStatic`
  - 接口`UpdateNodePool`:
    - 新增请求参数 `isStatic`
    - 新增响应参数 `isStatic`

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`CreateOnlineMigrationTask`、`SetOnlineMigrationTask`、`BatchStopMigrationTasks`、`StopMigrationTaskSync`
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
  - 接口`CreateFunction`:
    - 请求参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
    - 响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`ListFunctions`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`UpdateFunctionCode`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`ShowFunctionCode`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`UpdateFunctionConfig`:
    - 请求参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
    - 响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`ShowFunctionConfig`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`CreateFunctionVersion`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`ListFunctionVersions`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`
  - 接口`CreateDependency`请求参数`runtime`新增枚举值`Go1.x`
  - 接口`UpdateDependency`请求参数`runtime`新增枚举值`Go1.x`
  - 接口`ImportFunction`响应参数`runtime`新增枚举值`Java 8`、`Node.js 6.10`、`Node.js 8.10`、`Node.js 10.16`、`Node.js 12.13`、`Python 2.7`、`Python 3.6`、`Go 1.8`、`Go 1.x`、`PHP 7.3`, 移除枚举值`Python2.7`、`Python3.6`、`Go1.8`、`Java8`、`Node.js6.10`、`Node.js8.10`、`Custom`、`PHP7.3`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`响应参数`port`类型调整 `int32` -> `string`

# 3.0.74 2022-01-25

### HuaweiCloud SDK CES

- _新增特性_
  - 支持接口`ListAlarmHistories`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IAM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateLoginToken`新增响应参数`session_user_id`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`ListEngineProducts`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `dr_enable`
  - 接口`ShowInstance`新增响应参数 `dr_enable`
  - 接口`ListProducts`:
    - 新增响应参数 `Hourly`、`Monthly`
    - 移除响应参数 `hourly`、`honthly`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 支持接口`ListEngineProducts`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.73 2022-01-17

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 修复接口`CreateNodePool`的请求体结构错误的问题
- _特性变更_
  - 无

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`ListFunctionAsyncInvocations`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.72 2022-01-10

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`ShowQuotas`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateCluster`新增请求参数 `customSan`、`offloadCluster`、`cidrs`、`flavor`、`faultDomain`
  - 接口`ListClusters`新增响应参数 `customSan`、`offloadCluster`、`cidrs`、`flavor`、`faultDomain`
  - 接口`UpdateCluster`:
    - 新增请求参数 `customSan`、`containerNetwork`
    - 新增响应参数 `customSan`、`offloadCluster`、`cidrs`、`flavor`、`faultDomain`
  - 接口`ShowCluster`新增响应参数 `customSan`、`offloadCluster`、`cidrs`、`flavor`、`faultDomain`
  - 接口`DeleteCluster`新增响应参数 `customSan`、`offloadCluster`、`cidrs`、`flavor`、`faultDomain`
  - 接口`CreateNode`新增请求参数 `faultDomain`、`offloadNode`、`offloadNode`
  - 接口`ListNodes`新增响应参数 `faultDomain`、`offloadNode`、`offloadNode`
  - 接口`UpdateNode`新增响应参数 `faultDomain`、`offloadNode`、`offloadNode`
  - 接口`ShowNode`新增响应参数 `faultDomain`、`offloadNode`、`offloadNode`
  - 接口`DeleteNode`新增响应参数 `faultDomain`、`offloadNode`、`offloadNode`
  - 接口`CreateNodePool`新增请求参数 `podSecurityGroups`、`faultDomain`、`offloadNode`、`offloadNode`
  - 接口`ListNodePools`新增响应参数 `podSecurityGroups`、`faultDomain`、`offloadNode`、`offloadNode`
  - 接口`UpdateNodePool`:
    - 新增请求参数 `podSecurityGroups`、`faultDomain`、`offloadNode`、`offloadNode`
    - 新增响应参数 `podSecurityGroups`、`faultDomain`、`offloadNode`、`offloadNode`
  - 接口`ShowNodePool`新增响应参数 `podSecurityGroups`、`faultDomain`、`offloadNode`、`offloadNode`
  - 接口`DeleteNodePool`新增响应参数 `podSecurityGroups`、`faultDomain`、`offloadNode`、`offloadNode`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持内容分发网络服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListMigrationTask`新增响应参数 `ecs_tenant_private_ip`
  - 接口`ShowMigrationTask`新增响应参数 `ecs_tenant_private_ip`
  - 接口`StopMigrationTask`新增响应参数 `ecs_tenant_private_ip`

### HuaweiCloud SDK DDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`移除响应参数`lb_ip_address`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateServers`新增请求参数 `delete_on_termination`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateFunctionConfig`:
    - 新增请求参数 `is_stateful_function`
    - 新增响应参数 `is_stateful_function`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `lb_ip_address`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`GlanceListImages`响应参数`active_at`改为非必填
  - 接口`GlanceShowImage`响应参数`active_at`改为非必填
  - 接口`GlanceUpdateImage`响应参数`active_at`改为非必填

### HuaweiCloud SDK KPS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListKeypairs`:
    - 新增请求参数 `limit`、`marker`
    - 新增响应参数 `page_info`
  - 接口`ListFailedTask`新增请求参数 `limit`、`offset`
  - 接口`ListRunningTask`新增请求参数 `limit`、`offset`

# 3.0.71 2021-12-25

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CopyInstance`新增请求参数 `backup_format`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`NovaListServerActions`移除响应参数`updated_at`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidInstance`请求参数`partition_num`改为非必填
  - 接口`RestartManager`新增响应参数 `result`、`instance_id`
  - 接口`ListProducts`:
    - 新增响应参数 `hourly`、`honthly`
    - 移除响应参数 `Hourly`、`Monthly`

### HuaweiCloud SDK KPS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFailedTask`响应参数`task_time`类型调整 `int64` -> `string`
  - 接口`ListRunningTask`响应参数`task_time`类型调整 `int64` -> `string`

# 3.0.70 2021-12-17

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`ShowVersion`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListEvents`:
    - 响应参数`event_count`类型调整 `string` -> `int32`
    - 响应参数`latest_occur_time`类型调整 `string` -> `int64`
  - 接口`BatchListMetricData`响应参数`variance`类型调整 `string` -> `double`
  - 接口`ListResourceGroup`响应参数`type_statistics`类型调整 `string` -> `int32`
  - 接口`ListEventDetail`:
    - 响应参数`event_users`类型调整 `string` -> `array`
    - 响应参数`event_sources`类型调整 `string` -> `array`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持以下接口：
    - `RecognizeThailandIdcard`
    - `RecognizeMyanmarIdcard`
    - `RecognizeMyanmarDriverLicense`
    - `RecognizeChileIdCard`
    - `RecognizeThailandLicensePlate`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK SIS

- _新增特性_
  - 支持语音交互服务
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.0.69 2021-12-10

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateScalingGroup`新增请求参数 `allowed_address_pairs`
  - 接口`ListScalingGroups`新增响应参数 `allowed_address_pairs`
  - 接口`ShowScalingGroup`新增响应参数 `allowed_address_pairs`
  - 接口`UpdateScalingGroup`新增请求参数 `allowed_address_pairs`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `readonly_domain_name`
  - 接口`ShowInstance`新增响应参数 `readonly_domain_name`

### HuaweiCloud SDK FRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DetectFaceByFile`移除响应参数 `landmark`、`gender`、`yaw_angle`、`roll_angle`、`pitch_angle`、`headpose`、`smile`、`skin`、`ethnic`
  - 接口`DetectFaceByUrl`移除响应参数 `landmark`、`gender`、`yaw_angle`、`roll_angle`、`pitch_angle`、`headpose`、`smile`、`skin`、`ethnic`
  - 接口`DetectFaceByBase64`移除响应参数 `landmark`、`gender`、`yaw_angle`、`roll_angle`、`pitch_angle`、`headpose`、`smile`、`skin`、`ethnic`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFlavors`请求参数`region`改为必填

### HuaweiCloud SDK KMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ImportKeyMaterial`新增请求参数 `encrypted_privatekey`

### HuaweiCloud SDK SWR

- _新增特性_
  - 支持接口`ListQuotas`
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateNamespaceAuth`修改请求体名称`UpdateNamespaceAuthReq` -> `UpdateNamespaceAuthRequestBody`

# 3.0.68 2021-11-29

### HuaweiCloud SDK CBR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListBackups`新增响应参数`provider_id`

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowCluster`新增响应参数`cidrs`

### HuaweiCloud SDK DCS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`UpdateInstance`新增请求参数`port`

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 移除接口`CinderExportToImage`

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`NovaShowServer`和`NovaListServersDetails`新增响应参数`os:scheduler_hints`

### HuaweiCloud SDK ELB

- _新增特性_
    - 支持以下接口：
        - `ListApiVersions`
        - `ListSecurityPolicies`
        - `CreateSecurityPolicy`
        - `ShowSecurityPolicy`
        - `UpdateSecurityPolicy`
        - `DeleteSecurityPolicy`
        - `ListSystemSecurityPolicies`
        - `ListQuotaDetails`
        - `ChangeLoadbalancerChargeMode`
        - `BatchUpdatePoliciesPriority`
        - `UpdateIpList`
        - `BatchDeleteIpList`
- _解决问题_
    - 无
- _特性变更_
    - 移除接口`ShowQuotaDefaults`
    - 接口`ListFlavors`和`ShowFlavor`新增响应参数`flavor_sold_out`和`lcu`, 移除响应参数`availability_zone_ids`
    - 接口`ShowQuota`新增响应参数`members_per_pool`
    - 接口`CreateCertificate`和`UpdateCertificate`新增请求参数`enc_certificate`和`enc_private_key`
    - 接口`ListCertificates`和`ShowCertificate`新增响应参数`enc_certificate`和`enc_private_key`
    - 接口`CreateLoadBalancer`新增请求参数`prepaid_options`、`autoscaling`、`id`
    - 接口`ListLoadBalancers`新增请求参数`elb_virsubnet_type`和`autoscaling`,新增响应参数`autoscaling`和`ip_version`
    - 接口`UpdateLoadBalancer`新增请求参数`prepaid_options`和`autoscaling`,新增响应参数`loadbalancer_id`、`order_id`、`autoscaling`、`ip_version`
    - 接口`ShowLoadBalancer`新增响应参数`autoscaling`和`ip_version`
    - 接口`ShowLoadBalancerStatus`新增响应参数`id`、`type`、`provisioning_status`
    - 接口`CreateListener`新增请求参数`security_policy_id`、`enhance_l7policy_enable`
    - 接口`ListListeners`新增请求参数`enhance_l7policy_enable`和`member_instance_id`，新增响应参数`security_policy_id`、`transparent_client_ip_enable`、`enhance_l7policy_enable`
    - 接口`UpdateListener`新增请求参数`security_policy_id`、`enhance_l7policy_enable`，新增响应参数`security_policy_id`、`transparent_client_ip_enable`、`enhance_l7policy_enable`
    - 接口`ShowListener`新增响应参数`security_policy_id`、`transparent_client_ip_enable`、`enhance_l7policy_enable`
    - 接口`ListPools`新增请求参数`listener_id`和`member_instance_id`
    - 接口`ListMembers`新增请求参数`ip_version`和`member_type`，新增响应参数`member_type`和`instance_id`
    - 接口`UpdateMember`、`ShowMember`、`ListAllMembers`新增响应参数`member_type`和`instance_id`
    - 接口`CreateL7Policy`新增请求参数`priority`、`redirect_url_config`、`fixed_response_config`、`conditions`
    - 接口`ListL7Policies`新增请求参数`priority`,新增响应参数`redirect_url_config`和`fixed_response_config`
    - 接口`UpdateL7Policy`新增请求参数`priority`、`redirect_url_config`、`fixed_response_config`、`rules`,新增响应参数`redirect_url_config`和`fixed_response_config`
    - 接口`ShowL7Policy`新增响应参数`redirect_url_config`和`fixed_response_config`
    - 接口`CreateL7Rule`新增请求参数`conditions`
    - 接口`ListL7Rules`和`ShowL7Rule`新增响应参数`conditions`
    - 接口`UpdateL7Rule`新增请求参数和响应参数`conditions`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListVersionAliases`新增响应参数`ListVersionAliases`
    - 接口`CreateDependency`和`UpdateDependency`的请求参数`name`改为必填
    - 接口`CreateEvent`的请求参数`name`和`content`改为必填

### HuaweiCloud SDK KMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateKey`的请求参数`key_alias`改为必填
    - 接口`EnableKey`、`CancelKeyDeletion`、`ListKeys`、`ListKeyDetail`、`ShowPublicKey`、`ListGrants`、`DeleteImportedKeyMaterial`、`EnableKeyRotation`、`DisableKeyRotation`、`ShowKeyRotationStatus`的请求参数`key_id`改为必填
    - 接口`DeleteKey`的请求参数`key_id`和`pending_days`改为必填
    - 接口`ListKeys`新增请求参数`enterprise_project_id`
    - 接口`CreateRandom`的请求参数`random_data_length`改为必填
    - 接口`CreateDatakey`和`CreateDatakeyWithoutPlaintext`的请求参数`key_id`和`datakey_length`改为必填
    - 接口`EncryptDatakey`的请求参数`key_id`、`plain_text`、`datakey_plain_length`改为必填
    - 接口`DecryptDatakey`的请求参数`key_id`、`cipher_text`、`datakey_cipher_length`改为必填
    - 接口`UpdateKeyAlias`的请求参数`key_id`和`key_alias`改为必填
    - 接口`UpdateKeyDescription`的请求参数`key_id`和`key_description`改为必填
    - 接口`CreateGrant`的请求参数`key_id`、`grantee_principal`、`operations`改为必填
    - 接口`CancelGrant`和`CancelSelfGrant`的请求参数`key_id`和`grant_id`改为必填
    - 接口`EncryptData`的请求参数`key_id`和`plain_text`改为必填
    - 接口`DecryptData`的请求参数`cipher_text`改为必填
    - 接口`CreateParametersForImport`的请求参数`key_id`和`wrapping_algorithm`改为必填
    - 接口`ImportKeyMaterial`的请求参数`key_id`、`import_token`、`encrypted_key_material`改为必填
    - 接口`UpdateKeyRotationInterval`的请求参数`key_id`和`rotation_interval`改为必填
    - 接口`CreateKmsTag`新增请求参数`sequence`

# 3.0.67 2021-11-25

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowCluster`新增响应参数`platformVersion`
    - 接口`ListClusters`的请求参数`status`新增枚举值`RollingBack`和`RollbackFailed`

### HuaweiCloud SDK DDS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateInstance`、`ListInstances`新增请求参数`tags`

### HuaweiCloud SDK EIP

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreatePrePaidPublicip`、`CreatePublicip`新增请求和响应参数`alias`
    - 接口`ShowPublicip`、`UpdatePublicip`新增响应参数`alias`

### HuaweiCloud SDK KMS

- _新增特性_
    - 支持V2版本的接口
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK OCR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`RecognizeHandwriting`移除响应参数`extracted_data`

### HuaweiCloud SDK TMS

- _新增特性_
    - 支持接口`ShowTagQuota`
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.66 2021-11-12

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`UpdateNode`新增请求参数`customSan`

### HuaweiCloud SDK DDS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListAuditLogs`的响应参数名调整： `total_count` -> `total_record`

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowJob`新增响应参数`results`

### HuaweiCloud SDK OCR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`RecognizeGeneralTable`新增响应参数`confidence`

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 支持接口`CreateSystemIssueV4`
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListIrs`新增响应参数`sequence`
    - 接口`BatchUpdateIrs`新增请求参数`status_id`

### HuaweiCloud SDK VPC

- _新增特性_
    - 支持接口（V3）: `AddVpcExtendCidr`、`RemoveVpcExtendCidr`、`ListVpcs`、`ShowVpc`
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.65 2021-10-25

### HuaweiCloud SDK DNS

- _新增特性_
    - 支持接口`ShowDomainQuota`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK EIP

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateSharedBandwidth`新增请求参数`bandwidth_type`

### HuaweiCloud SDK FRS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`AddFacesByFile`、`AddFacesByBase64`、`AddFacesByUrl`新增请求参数`single`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateInstance`的请求参数和响应参数`num`、`size`类型调整： `integer` -> `string`

### HuaweiCloud SDK ImageSearch

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`RunSearchPicture`的请求参数名称调整: `isCrop` -> `is_crop`
    - 接口`RunSearchPicture`新增请求参数`box`

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowJob`新增响应参数`current_task`、`image_name`、`process_percent`

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListDevices`新增请求参数`status`
    - 接口`CreateRuleAction`新增请求参数`file_path`

### HuaweiCloud SDK OCR

- _新增特性_
    - 新增接口`RecognizeInsurancePolicy`、`RecognizeFinancialStatement`、`RecognizeQualificationCertificate`
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.64 2021-10-19

### HuaweiCloud SDK EIP

- _新增特性_
    - 支持以下接口：
        - `ListCommonPools`
        - `ListPublicBorderGroups`
        - `ListPublicipPool`
        - `ShowPublicipPool`
        - `ListShareBandwidthTypes`
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListPublicips`新增请求参数`allow_share_bandwidth_type_any`
    - 接口`NeutronListFloatingIps`的请求参数`limit`的类型调整： `string` -> `integer`
    - 接口`NeutronUpdateFloatingIp`请求体的名称调整： `floatingip` -> `NeutronUpdateFloatingIpRequestBody`
    - 接口`ShowPublicip`新增响应参数`allow_share_bandwidth_types`

# 3.0.63 2021-10-11

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`DisassociateServerVirtualIp`的请求参数`reverse_binding`改为非必填

### HuaweiCloud SDK FRS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`DetectFaceByFile`、`DetectFaceByBase64`、`DetectFaceByUrl`的请求参数`attributes`可选值调整为`2,4,6,7,8,11,12,13,21`

# 3.0.62 2021-09-29

### HuaweiCloud SDK DNS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListTag`的响应参数`resource_detail`类型调整： `string` -> `object`
    - 接口`CreatePrivateZone`、`UpdatePublicZone`、`DeletePublicZone`的响应参数`masters`类型调整： `string` -> `array`
    - 接口`CreatePrivateZone`和`UpdatePublicZone`的请求参数`ttl`类型调整： `string` -> `integer`
    - 接口`ListRecordSets`、`ListRecordSetsWithLine`、`ListRecordSetsByZone`的请求参数`limit`和`offset`类型调整: `string` -> `integer`
    - 接口`CreatePrivateZone`、`ListRecordSetsByZone`、`ShowRecordSetWithLine`、`ListPtrRecords`、`ListPublicZones`新增响应参数`tags`

### HuaweiCloud SDK ECS

- _新增特性_
    - 支持以下接口:
        - `ListServerTags`
        - `BatchAttachSharableVolumes`
        - `ShowServerAutoRecovery`
        - `BatchResetServersPassword`
        - `ReinstallServerWithoutCloudInit`
        - `ChangeServerOsWithoutCloudInit`
        - `BatchUpdateServersName`
        - `ShowServerPassword`
        - `AssociateServerVirtualIp`
        - `MigrateServer`
        - `ShowServerBlockDevice`
        - `DisassociateServerVirtualIp`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListIssueRecordsV4`新增响应参数`id`和`name`
    - 接口`ListProjectIterationsV4`新增响应参数`status`

# 3.0.61 2021-09-24

### HuaweiCloud SDK CCE

- _新增特性_
    - 支持接口`ShowQuotas`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK Classroom

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ApplyJudgement`新增非必填的请求参数`testcases`

### HuaweiCloud SDK IVS

- _新增特性_
    - 支持人证核身服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK SWR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListRepositoryTags`新增响应参数`domain_id`、`scanned`、`tag_type`

# 3.0.60 2021-09-16

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowCluster`新增响应参数`platformVersion`

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateDataImage`新增非必填的请求参数`__support_amd`
    - 接口`ListImages`新增响应参数`__support_amd`

### HuaweiCloud SDK KMS

- _新增特性_
    - 支持接口`ShowPublicKey`、`Sign`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK OCR

- _新增特性_
    - 支持接口`RecognizeInvoiceVerification`
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.59 2021-09-10

### HuaweiCloud SDK CCE

- _新增特性_
    - 支持接口`AddNode`和`ResetNode`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK DDS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowJobDetail`新增响应参数`status`和`fail_reason`

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateVolume`的请求参数`size`改为必填

### HuaweiCloud SDK OCR

- _新增特性_
    - 支持接口`RecognizeInvoiceVerification`
- _解决问题_
    - 无
- _特性变更_
    - 接口`RecognizeIdCard`新增可选请求参数`return_verification`

# 3.0.58 2021-08-31

### HuaweiCloud SDK FRS

- _新增特性_
    - 支持以下接口:
        - `DetectLiveByUrl`
        - `DetectLiveFaceByUrl`
        - `DetectLiveByFile`
        - `DetectLiveFaceByFile`
        - `DetectLiveByBase64`
        - `DetectLiveFaceByBase64`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK SMN

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListTopics`新增请求参数`enterprise_project_id`、`name`、`fuzzy_name`
    - 接口`ListSubscriptions`新增请求参数`protocol`、`status`、`endpoint`

# 3.0.57 2021-08-25

### HuaweiCloud SDK DDS

- _新增特性_
    - 支持以下接口：
        - `ShowJobDetail`
        - `SwitchSlowlogDesensitization`
        - `ListFlavorInfos`
        - `UpdateInstanceRemark`
- _解决问题_
    - 无
- _特性变更_
    - 接口`RestoreInstance`、`CreateManualBackup`、`RestoreInstanceFromCollection`新增响应参数`job_id`
    - 接口`ListInstances`新增响应参数`remark`

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListServerInterfaces`新增以下响应参数:
        - `delete_on_termination`
        - `driver_mode`
        - `min_rate`
        - `multiqueue_num`
        - `pci_address`
    - 接口`ListServersDetails`新增响应参数`cpu_options`和`hypervisor`

### HuaweiCloud SDK EIP

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`BatchCreateSharedBandwidths`新增请求参数和响应参数`public_border_group`
    - 接口`AddPublicipsIntoSharedBandwidth`新增响应参数`public_border_group`

### HuaweiCloud SDK FRS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口名调整： `AuthorizeFaceRecognitionService` -> `ShowSubscribes`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ExportFunction`的新增请求参数`function_urn`和`type`
    - 接口`ListStatistics`的请求参数`filter`可选值修改为`monitor_data`、`monthly_report`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
    - 支持以下接口
        - `ListDedicatedResources`
        - `ListFlavorInfos`
        - `ListConfigurationTemplates`
        - `ListInstancesByResourceTags`
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateInstance`新增请求参数`dedicated_resource_id`
    - 接口`ListInstances`新增响应参数`dedicated_resource_id`

### HuaweiCloud SDK ImageSearch

- _新增特性_
    - 支持图像搜索服务
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.56 2021-08-17

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListNodePools`新增以下响应参数：
        - `annotations`
        - `updateTimestamp`
        - `creationTimestamp`
        - `creatingNode`
        - `deletingNode`
        - `conditions`
        - `enterprise_project_id`
    - 接口`ListClusters`新增响应参数`orderID`和`upgradefrom`

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListServerResizeFlavors`新增响应参数`ecs:instance_architecture`
    - 接口`NovaCreateServers`新增请求参数`tenancy`和`dedicated_host_id`

### HuaweiCloud SDK ELB

- _新增特性_
    - 无
- _解决问题_
    - 修复创建LB异常的问题
- _特性变更_
    - 无

# 3.0.55 2021-08-10

### HuaweiCloud SDK AS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 修改接口`ListResourceInstances`的请求参数`key`、`value`为必填参数

### HuaweiCloud SDK EIP

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListBandwidths`、`ShowPublicip`的响应参数名称调整：`publicip_border_group` -> `public_border_group`

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListVolumes`新增请求参数`server_id`

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateDeployment`移除响应参数`order_id`

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 修改接口`UpdateImage`的请求参数`value`为必填参数

### HuaweiCloud SDK Kafka

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`UpdateInstanceTopic`新增请求参数`new_partition_numbers`

### HuaweiCloud SDK SWR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowAccessDomain`新增以下响应参数：
        - `namespace`
        - `repository`
        - `access_domain`
        - `permit`
        - `deadline`
        - `description`
        - `creator_id`
        - `creator_name`
        - `created`
        - `updated`
        - `status`

### HuaweiCloud SDK VOD

- _新增特性_
    - 支持视频点播服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK VPC

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`NeutronListSubnets`新增请求参数`enable_dhcp`
    - 接口`NeutronListSecurityGroups`新增响应参数`security_groups_links`

# 3.0.54 2021-07-27

### HuaweiCloud SDK Classroom

- _新增特性_
    - 支持接口`ApplyJudgement`、`ShowJudgementDetail`、`ShowJudgementFile`
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.53 2021-07-26

### HuaweiCloud SDK DCS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`UpdateConfigurations`新增请求参数`dcs_cluster_proxy2_node`

### HuaweiCloud SDK DDS

- _新增特性_
    - 支持接口`UpdateClientNetwork`
- _解决问题_
    - 无
- _特性变更_
    - 接口`SetBalancerWindow`的请求参数`start_time`、`stop_time`改为非必填
    - 接口`CreateInstance`新增请求参数`port`，新增响应参数`port`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
    - 支持接口`EnableLtsLogs`
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowFunctionCode`新增响应参数`concurrent_num`、`id`、`encrypted_user_data`
    - 接口`ListFunctions`新增响应参数`func_vpc_id`、`encrypted_user_data`、`long_time`、`log_group_id`、`log_stream_id`、`type`，移除响应参数`version_description`、`last_modified_utc`、`dependencies`
    - 接口`UpdateVersionAlias`移除请求参数`name`、`last_modified`、`alias_urn`
    - 接口`ShowFunctionConfig`新增响应参数`encrypted_user_data`、`long_time`、`log_group_id`、`log_stream_id`、`type`，移除响应参数`version_description`、`concurrency`
    - 接口`UpdateFunctionConfig`移除请求参数`version_description`、`concurrency`、`depend_list`，新增请求参数`encrypted_user_data`、`long_time`、`log_group_id`、`log_stream_id`、`type`
    - 接口`ListFunctionVersions`移除响应参数`last_modified_utc`、`concurrency`，新增响应参数`encrypted_user_data`、`long_time`、`log_group_id`、`log_stream_id`、`type`
    - 接口`UpdateTrigger`的请求参数`size`类型调整： `string`->`integer`
    - 接口`ShowDependency`的响应参数`size`类型调整： `string`->`integer`
    - 接口`UpdateDependency`的响应参数`size`类型调整： `string`->`integer`

# 3.0.52 2021-07-16

### HuaweiCloud SDK AS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateScalingV2Policy`新增请求参数`description`
    - 接口`ShowScalingV2Policy`、`ShowScalingGroup`新增响应参数`description`

### HuaweiCloud SDK DCS

- _新增特性_
    - 支持更多接口：
        - `CreateDiagnosisTask`
        - `CreateRedislog`
        - `CreateRedislogDownloadLink`
        - `ListDiagnosisTasks`
        - `ListRedislog`
        - `ListSlowlog`
        - `ShowDiagnosisTaskDetails`
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListInstances`新增请求参数`include_delete`

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - [Issue 40](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/40): 修复响应参数`__lazyloading`类型定义错误的问题
- _特性变更_
    - 无

# 3.0.51 2021-07-09

### HuaweiCloud SDK BMS

- _新增特性_
    - 无
- _解决问题_
    - 修复接口`ListBareMetalServers`的响应参数`addresses`数据结构定义错误的问题
- _特性变更_
    - 无

### HuaweiCloud SDK CBR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListProtectable`新增响应参数`smn_notify`、`threshold`
    - 接口`AssociateVaultPolicy`新增请求参数`add_policy_ids`和响应参数`without_any_tag`、`smn_notify`、`threshold`

### HuaweiCloud SDK CCE

- _新增特性_
    - 支持接口`RemoveNode`、`MigrateNode`
- _解决问题_
    - 无
- _特性变更_
    - 接口`DeleteCluster`新增请求参数`tobedeleted`

### HuaweiCloud SDK DNS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreatePublicZone`的响应参数`masters`、`zones`类型调整：`string`->`array`

### HuaweiCloud SDK EIP

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateSharedBandwidth`、`ListBandwidths`新增响应参数`publicip_border_group`

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`GlanceCreateImageMetadata`新增响应参数`__root_origin`、`checksum`、`size`
    - 接口`GlanceAddImageMember`移除请求参数`deleted`、`deleted_at`,新增以下请求参数：
        - `__lazyloading`
        - `__os_feature_list`
        - `__root_origin`
        - `__sequence_num`
        - `__support_agent_list`
        - `__system__cmkid`
        - `active_at`
        - `hw_vif_multiqueue_enabled`
        - `max_ram`
        - `__image_location`
        - `__is_config_init`
        - `__account_code`

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListRules`新增响应参数`edge_node_ids`、`last_update_time`

### HuaweiCloud SDK SWR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowRepository`新增响应参数`domain_id`、`priority`
    - 接口`CreateRetention`新增响应参数`template`

# 3.0.50 2021-06-29

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`CreateNodePool`、`ShowNodePool`、`UpdateNodePool`、`DeleteNodePool`新增请求参数`storage`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListInstances`的响应参数`port`类型调整： `string`->`integer`
    - 接口`ListInstances`的响应参数名称调整： `storage_engine`->`mode`
    - 接口`ListSlowLogs`移除响应参数`node_name`，新增响应参数`time`

### HuaweiCloud SDK NAT

- _新增特性_
    - 无
- _解决问题_
    - 修复接口`ListNatGateways`的请求参数`project_id`重复的问题
- _特性变更_
    - 无

# 3.0.49 2021-06-25

### HuaweiCloud SDK BMS

- _新增特性_
    - 支持接口`ChangeBaremetalServerOs`
- _解决问题_
    - 无
- _特性变更_
    - 接口`ChangeBaremetalServerName`的响应参数名称调整：`server_tags`->`sys_tags`

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`KeystoneListPermissions`新增请求参数`permission_type`、`display_name`、`catalog`、`type`

# 3.0.48 2021-06-21

### HuaweiCloud SDK BMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ChangeBaremetalServerName`新增响应参数`server_tags`、`enterprise_project_id`、`group`

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - [Issue 22](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/22): 修正接口`ListAddonInstances`的响应参数`status`可选值
- _特性变更_
    - 无

### HuaweiCloud SDK Kafka

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowGroups`的响应参数`partitions`类型调整： `array[string]` -> `array[integer]`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
    - 无
- _解决问题_
    - 修复编译失败的问题
- _特性变更_
    - 无

# 3.0.47 2021-06-10

### HuaweiCloud SDK FunctionGraph

- _新增特性_
    - 新增支持接口
        - `ImportFunction`
        - `ExportFunction`
        - `AsyncInvokeReservedFunction`
        - `DeleteReservedInstanceById`
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.46 2021-06-04

### HuaweiCloud SDK CCE

- _新增特性_
    - 无
- _解决问题_
    - [Issue 20](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/20): 修复`extendParam`类型定义错误的问题
- _特性变更_
    - 接口`DeleteCluster`新增请求参数`tobedeleted`

### HuaweiCloud SDK DDS

- _新增特性_
    - 新增支持接口`ShowQuotas`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 新增支持接口`ListComplexQueryDevice`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
    - 支持`GaussDBforNoSQL`服务
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.45 2021-05-25

### HuaweiCloud SDK AS

- _新增特性_
    - 新增支持接口：
        - `ListApiVersions`
        - `ShowApiVersion`
        - `BatchProtectScalingInstances`
        - `BatchRemoveScalingInstances`
        - `CreateScalingTagInfo`
        - `BatchResumeScalingPolicies`
        - `BatchPauseScalingPolicies`
        - `PauseScalingGroup`
        - `BatchSetScalingInstancesStandby`
        - `BatchUnsetScalingInstancesStandby`
        - `ResumeScalingPolicy`
        - `PauseScalingPolicy`
- _解决问题_
    - 无
- _特性变更_
    - 接口名称调整：
        - `ExecuteScalingPolicies` -> `BatchDeleteScalingPolicies`
        - `EnableOrDisableScalingGroup` -> `ResumeScalingGroup`
        - `UpdateScalingGroupInstance` -> `BatchAddScalingInstances`
        - `CompleteLifecycleAction` -> `AttachCallbackInstanceLifeCycleHook`
    - 移除接口：
        - `DeleteScalingTags`
    - `ListScalingGroups` 接口新增参数 `enterprise_project_id`
    - `ListScalingActivityV2Logs` 接口新增参数 `log_id`

### HuaweiCloud SDK DMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口名称调整：（查询项目标签）ShowProjectTags -> ShowQueueProjectTags

### HuaweiCloud SDK EPS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListEnterpriseProject`的请求参数`offset`从必填改为非必填

### HuaweiCloud SDK FunctionGraph

- _新增特性_
    - 新增支持接口：
        - `ListFunctionAsyncInvokeConfig`
        - `ShowFunctionAsyncInvokeConfig`
        - `DeleteFunctionAsyncInvokeConfig`
        - `UpdateFunctionAsyncInvokeConfig`
- _解决问题_
    - 无
- _特性变更_
    - 接口`DeleteVersionAlias`、`UpdateVersionAlias`、`ShowVersionAlias`的请求参数名称调整：`name` -> `alias_name`
    - 接口`DeleteFunctionTrigger`、`UpdateTrigger`、`ShowFunctionTrigger`的请求参数名称调整：`triggerId` -> `trigger_id`

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口 `CreateUsers` 新增请求体参数和响应体参数 _access_mode_
    - 接口 `DeleteBindingDevice` 将请求体参数 _authentication_code_ 设置为必填参数

### HuaweiCloud SDK Kafka

- _新增特性_
    - 新增支持接口：
        - `CreateInstanceUser`
        - `BatchDeleteInstanceUsers`
        - `ShowInstanceUsers`
        - `ShowTopicAccessPolicy`
        - `UpdateTopicAccessPolicy`
        - `ShowKafkaTopicPartitionDiskusage`
        - `ShowInstanceMessages`
        - `ResetUserPassword`
- _解决问题_
    - 无
- _特性变更_
    - 接口名称调整：
        - `ShowInstanceTags` -> `ShowKafkaTags`
        - `ShowProjectTags` -> `ShowKafkaProjectTags`
        - `BatchCreateOrDeleteInstanceTag` -> `BatchCreateOrDeleteKafkaTag`
    - 接口 `BatchCreateOrDeleteInstanceTag` 请求体名称调整：`BatchCreateOrDeleteInstanceTagRequestBody`
      -> `BatchCreateOrDeleteKafkaTagRequestBody`
    - 接口 `UpdateSinkTaskQuota` 请求体 `UpdateSinkTaskQuotaReq` 的请求参数 `sink_max_tasks` 数据类型调整：String → Integer

### HuaweiCloud SDK RabbitMQ

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口名称调整：
        - `BatchCreateOrDeleteInstanceTag` -> `BatchCreateOrDeleteRabbitMqTag`
        - `ShowProjectTags` -> `ShowRabbitMqProjectTags`
        - `ShowInstanceTags` -> `ShowRabbitMqTags`
    - 接口 `BatchCreateOrDeleteInstanceTag` 请求体名称调整：BatchCreateOrDeleteInstanceTagRequestBody ->
      BatchCreateOrDeleteRabbitMqTagRequestBody

# 3.0.43-rc 2021-05-14

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 解决了使用接口`NovaShowKeypair`获取秘钥，结果解析异常的问题
- _特性变更_
    - 无

# 3.0.42-rc 2021-05-10

### HuaweiCloud SDK BMS

- _新增特性_
    - 新增支持接口`BatchCreateBaremetalServerTags`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK DDS

- _新增特性_
    - 新增支持接口`MigrateAz`、`ListAz2Migrate`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK EPS

- _新增特性_
    - 无
- _解决问题_
    - [Issue 17](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/17): 修复`EpDetailType`枚举定义错误的问题
- _特性变更_
    - 无

### HuaweiCloud SDK KPS

- _新增特性_
    - 无
- _解决问题_
    - [Issue 19](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/19): 修复`ListKeypairs`响应体类型的问题
- _特性变更_
    - 无

# 3.0.41-rc 2021-04-30

### HuaweiCloud SDK DDS

- _新增特性_
    - 新增支持的接口
        - 查询集群均衡设置 `ShowShardingBalancer`
        - 设置集群均衡开关 `SetBalancerSwitch`
        - 设置集群均衡活动时间窗 `SetBalancerWindow`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 查询账号配额接口`ShowDomainQuota`的请求参数`type`增加可选值：
        - `assigment_group_mp`
        - `assigment_agency_mp`
        - `assigment_group_ep`
        - `assigment_user_ep`

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 下线订阅管理相关接口：
        - `ListSubscriptions`
        - `CreateSubscription`
        - `UpdateSubscription`
        - `ShowSubscription`
        - `DeleteSubscription`

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 获取项目详情接口`ShowProjectInfoV4`的响应体新增字段`project_code`

# 3.0.40-rc 2021-04-15

### HuaweiCloud SDK DDS

- _新增特性_
    - 新增支持接口`DeleteDatabaseUser`、`DeleteDatabaseRole`、`ShowConnectionStatistics`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ListIssuesV4`, `ListChildIssuesV4`响应体新增字段`closed_time` 、`id` 、`created_time`

### HuaweiCloud SDK VPC

- _新增特性_
    - 无
- _解决问题_
    - 修复问题，开放vpc和子网的标签
- _特性变更_
    - 无

# 3.0.39-rc 2021-03-30

### HuaweiCloud SDK Kafka

- _新增特性_
    - 无
- _解决问题_
    - 修复查询消息接口没有时间戳字段的问题
- _特性变更_
    - 无

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口`ShowIssueV4`、`UpdateIssueV4`的响应体 `IssueResponseV4`增加`name`属性
    - 将接口`ShowProjectWorkHours`、`ListProjectWorkHours`的响应体`ShowProjectWorkHoursResponseBody`下的属性`work_time`
      修改为`work_date`

### HuaweiCloud SDK SMN

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 将接口`PublishMessage`的请求参数`protocol`从必填改为非必填
    - 将接口 `PublishMessage` 请求体的 `PublishMessageRequestBody` 类属性 `subject` 由必填改为非必填

# 3.0.38-rc 2021-03-26

### HuaweiCloud SDK SMN

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 将接口 `ListSlowlogStatistics` 下的 `property` 属性从必填调整为非必填

# 3.0.37-rc 2021-03-19

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 解决 ListFlavors 接口响应体反序列化出错的问题
- _特性变更_
    - 无

# 3.0.36-rc 2021-03-16

### HuaweiCloud SDK EIP

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 申请包周期弹性公网IP接口增加 `enterprise_project_id` 字段

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 无
- _解决问题_
    - 修复接口无法调用的问题
- _特性变更_
    - 无

# 3.0.35-rc 2021-03-15

### HuaweiCloud SDK Core

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 当用户传入的 `endpoint` 未带协议前缀时，支持自动加上 `https` 前缀

### HuaweiCloud SDK CES

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 使用资源分组创建告警规则时，维度字段调整为非必填，即 `CreateAlarmRequestBody` 类中的属性 `metric` 对应类调整：
      `MetricInfoForAlarm` → `MetricForAlarm`

### HuaweiCloud SDK DDS

- _新增特性_
    - 新增支持接口：
        - 根据备份恢复新实例 `RestoreNewInstance`
        - 查询实例节点会话 `ListSessions`
        - 终结实例节点会话 `DeleteSession`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ECS

- _新增特性_
    - 新增支持接口：查询云服务器组详情 `ShowServerGroup`
- _解决问题_
    - 无
- _特性变更_
    - 云服务器获取密码接口名调整：`ShowWindowsServerPassword` → `ShowServerPassword`
    - 云服务器清除密码接口名调整：`DeleteWindowsServerPassword` → `DeleteServerPassword`

### HuaweiCloud SDK ELB

- _新增特性_
    - 新增支持接口：查询当前租户下的后端服务器列表 `ListAllMembers`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK IAM

- _新增特性_
    - 新增支持接口：
        - 查询身份提供商详情 `KeystoneShowIdentityProvider`
        - 注册身份提供商 `KeystoneCreateIdentityProvider`
        - 更新身份提供商 `KeystoneUpdateIdentityProvider`
        - 删除身份提供商 `KeystoneDeleteIdentityProvider`
        - 获取联邦认证token(OpenId Connect Id token方式) `CreateTokenWithIdToken`
- _解决问题_
    - 无
- _特性变更_
    - 下线接口：获取联邦认证unscoped token `CreateUnscopeTokenByIdpInitiated`

### HuaweiCloud SDK IMS

- _新增特性_
    - 新增支持接口：
        - 按标签查询镜像 `ListImageByTags`
        - 查询租户所有镜像标签 `ListImagesTags`
        - 查询镜像标签 `ListImageTags`
        - 添加镜像标签 `AddImageTag`
        - 删除镜像标签 `DeleteImageTag`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 新增支持接口：
        - 创建工作项类型自定义字段 `CreateCustomfields`
        - 查询人均bug `ShowBugsPerDeveloper`
        - 查询需求按时完成率 `ShowCompletionRate`
        - 查询缺陷密度 `ShowBugDensityV2`
        - 获取项目详情 `ShowProjectInfoV4`
- _解决问题_
    - 修改接口命名错误：`ShowtIssueCompletionRate` → `ShowIssueCompletionRate`
- _特性变更_
    - `ListProjectV4` 接口响应体中的 `created_time` 和 `updated_time` 属性类型调整：string → long?

# 3.0.34-rc 2021-02-27

### HuaweiCloud SDK Core

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 优化 README 文档描述及 CHANGELOG 日志格式

### HuaweiCloud SDK BMS

- _新增特性_
    - 无
- _解决问题_
    - 修复接口方法命名不合理的问题：`WindowsBaremetalServerCleanPwd` → `DeleteWindowsBareMetalServerPassword`
- _特性变更_
    - 无

### HuaweiCloud SDK BSS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 所有类型为 `decimal?` 的属性统一调整为 `double?`

### HuaweiCloud SDK CES

- _新增特性_
    - 无
- _解决问题_
    - 修复类 `CreateAlarmResponse` 出现循环依赖的问题
- _特性变更_
    - 无

### HuaweiCloud SDK DDS

- _新增特性_
    - 新增支持接口：获取慢日志下载链接 `DownloadSlowlog`、获取错误日志下载链接 `DownloadErrorlog`
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ELB

- _新增特性_
    - 无
- _解决问题_
    - 修复接口方法命名不合理的问题：`ListMenbers` → `ListMembers`
    - 修复接口 `ShowMember` 需要传 query 参数 `X-Auth-Token` 的问题
- _特性变更_
    - 无

### HuaweiCloud SDK EPS

- _新增特性_
    - 无
- _解决问题_
    - 修复接口方法命名不合理的问题：`ModifyEnterpriseProject` → `UpdateEnterpriseProject`
- _特性变更_
    - 无

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 修复 `KeystoneUserResult` 类中属性名的错误定义问题：`pwd_stength` → `pwd_strength`
- _特性变更_
    - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 下线以下接口：
        - CreateAppCertificate
        - ListAppCertificates
        - ShowAppCertificate
        - UpdateAppCertificate
        - DeleteAppCertificate
- _解决问题_
    - 无
- _特性变更_
    - 隐藏接口内部字段 `Sp-Auth-Token`、`Stage-Auth-Token`，不影响用户使用

### HuaweiCloud SDK SWR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 镜像大小 `size` 属性类型调整： int? → long?

# 3.0.33-rc 2021-02-07

### HuaweiCloud SDK IMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 查询镜像支持的OS列表(ListOsVersions)接口返回体属性 `os_bit` 数据类型调整：string → int32

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 新增支持接口：查询设备下队列中的命令(ListAsyncCommands)、查询设备下的历史命令(ListAsyncHistoryCommands)、上传应用侧CA证书(CreateAppCertificate)
      、查询应用侧CA证书列表(ListAppCertificates)、查询应用侧CA证书(ShowAppCertificate)、更新应用侧CA证书(UpdateAppCertificate)、删除应用侧CA证书(
      DeleteAppCertificate)
- _解决问题_
    - 无
- _特性变更_
    - 下线支持接口（接口不在支持通过SDK调用，仍可通过API直接调用）：重置设备指纹(DeviceManagement)

# 3.0.32-rc 2021-01-30

### HuaweiCloud SDK DNS

- _新增特性_
    - 支持云解析服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口名称调整: UpdateAutoTerminateTimeServer → UpdateServerAutoTerminateTime

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 创建云硬盘接口支持指定专属存储池ID
    - 查询配额相关接口属性 `allocated` 类型调整: string → int

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 查询IAM用户详情接口响应体增加属性`access_mode`

# 3.0.31-rc 2021-01-25

### HuaweiCloud SDK Core

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 设置默认Timeout为120秒

### HuaweiCloud SDK BSS

- _新增特性_
    - 新增支持接口：查询订单可用折扣
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ECS

- _新增特性_
    - 新增支持接口：修改云服务器云主机销毁时间
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.30-rc 2021-01-15

### HuaweiCloud SDK Core

- _新增特性_
    - Region管理支持使用`ValueOf`方法获取`region`信息
- _解决问题_
    - 调用临时AK/SK返回异常问题修复
- _特性变更_
    - 无

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 创建/查询用户接口响应字段 `is_domain_owner` 类型调整：string → boolean

### HuaweiCloud SDK SWR

- _新增特性_
    - 支持容器镜像服务
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.29-beta 2020-12-31

### HuaweiCloud SDK DCS

- _新增特性_
    - 无
- _解决问题_
    - 修正接口返回数据类型避免反序列化失败：
        - 查询所有实例列表接口：响应参数`Tags`类型调整 Tag → ResourceTag
        - 查询慢日志接口：响应参数`duration`类型调整 int32 → string
        - 查询大key分析详情接口：响应参数`db`类型调整 int32 → string
        - 查询热key分析详情接口：响应参数`db`类型调整 int32 → string
- _特性变更_
    - 无

### HuaweiCloud SDK SMN

- _新增特性_
    - 无
- _解决问题_
    - 修正消息发布接口请求参数：Object → Map<String, String>
- _特性变更_
    - 无

# 3.0.28-beta 2020-12-28

### HuaweiCloud SDK DCS

- _新增特性_
    - 无
- _解决问题_
    - 修改缓存接口port类型为integer
- _特性变更_
    - 无

# 3.0.27-beta 2020-12-25

### HuaweiCloud SDK DCS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口ListInstances请求Query参数名称调整：id → instance_id

# 3.0.26-beta 2020-12-23

### HuaweiCloud SDK Core

- _新增特性_
    - 支持Region管理，用户新建客户端时可以通过{Service}Region传入，无需自己配置endpoint。配置Region后，支持自动回填ProjectId/DomainId
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK BSS

- _新增特性_
    - 新增支持接口：查询用量单位列表
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK CES

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - ShowMetricData接口字段更新

### HuaweiCloud SDK SMN

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 消息模板名称中字段类型调整

# 3.0.25-beta 2020-12-15

### HuaweiCloud SDK CCE

- _新增特性_
    - 支持云容器引擎服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ELB

- _新增特性_
    - 无
- _解决问题_
    - 创建监听器接口返回为空问题修复
    - 证书列表查询接口返回非列表问题修复
- _特性变更_
    - 无

### HuaweiCloud SDK NAT

- _新增特性_
    - 无
- _解决问题_
    - 修复批量创建DNAT规则失败的问题
- _特性变更_
    - 无

# 3.0.24-beta 2020-12-04

### HuaweiCloud SDK SMN

- _新增特性_
    - 支持消息通知服务
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.23-beta 2020-11-30

### HuaweiCloud SDK BMS

- _新增特性_
    - 支持裸金属服务器
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK BSS

- _新增特性_
    - 新增支持接口：查询使用量列表，设置/取消包周期资源到期转按需
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK CBR

- _新增特性_
    - 新增支持接口：迁移资源接口
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK CES

- _新增特性_
    - 新增支持接口：
        - 查询事件监控列表
        - 查询某一个事件监控详情
        - 创建资源分组
        - 更新资源分组
        - 删除资源分组
        - 查询所有资源分组
        - 修改告警规则
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - [Issue 21](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/21) 开放查询SSH密钥详情接口

### HuaweiCloud SDK IAM

- _新增特性_
    - 新增支持接口
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.22-beta 2020-11-17

### HuaweiCloud SDK DMS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 属性类型调整：属性 `创建队列的时间` 由 `string` 类型调整为 `integer64` 类型

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 创建虚拟机接口（按需和包周期）增加 `dry_run` 属性，表示是否预检此次请求

### HuaweiCloud SDK NAT

- _新增特性_
    - 支持NAT网关服务
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
    - 接口名调整：UpdateInstanceCrossVPCIP → UpdateInstanceCrossVpcIp

### HuaweiCloud SDK VPC

- _新增特性_
    - 支持网络ACL相关接口
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.21-beta 2020-11-11

### HuaweiCloud SDK CBR

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 创建存储库接口(CreateVault)新增存储库turbo类型
    - 修改策略接口(UpdatePolicy)删除多余字段

### HuaweiCloud SDK CES

- _新增特性_
    - 新增接口响应示例，调整字段描述
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.20-beta 2020-11-02

### HuaweiCloud SDK CES

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 创建告警规则接口增加资源分组字段
    - 查询告警历史接口响应体metadata修改，只返回total字段

### HuaweiCloud SDK ELB

- _新增特性_
    - 无
- _解决问题_
    - 创建转发规则接口参数名错误问题修复
- _特性变更_
    - 无

# 3.0.19-beta 2020-10-31

### HuaweiCloud SDK CBR

- _新增特性_
    - 新增支持接口：TAG标签相关接口
- _解决问题_
    - [Issue 17](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/17) 修复ListBackups接口响应体问题
- _特性变更_
    - 无

### HuaweiCloud SDK CTS

- _新增特性_
    - 新增支持接口：ListQuotas（查询租户追踪器配额信息）
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK Iam

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口名称调整，涉及接口：
        1. KeystoneCreateUserTokenByPasswordAndMFA → KeystoneCreateUserTokenByPasswordAndMfa
        2. CreateUnscopeTokenByIDPInitiated → CreateUnscopeTokenByIdpInitiated

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 新增支持接口：迭代信息、用户信息、项目成员、项目信息、项目指标、项目统计等相关方法的接口
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.18-beta 2020-10-20

### HuaweiCloud SDK DCS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 接口名中去掉冗余的Dcs服务名

### HuaweiCloud SDK ELB

- _新增特性_
    - 支持弹性负载均衡服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 增加规则相关接口
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.17-beta 2020-10-14

### HuaweiCloud SDK BSS

- _新增特性_
    - 伙伴中心支持导出产品目录价
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK DCS

- _新增特性_
    - 增加支持接口
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.16-beta 2020-10-12

### HuaweiCloud SDK CTS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 删除v1版本废弃接口

# 3.0.15-beta 2020-09-30

### HuaweiCloud SDK Core

- _新增特性_
    - 无
- _解决问题_
    - 修复整型枚举类型在发起请求时传值类型错误的问题
- _特性变更_
    - 无

### HuaweiCloud SDK CBR

- _新增特性_
    - 支持云备份服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK EIP

- _新增特性_
    - 支持弹性公网IP服务
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.14-beta 2020-09-24

### HuaweiCloud SDK BSS

- _新增特性_
    - 无
- _解决问题_
    - 修复BssClient类无法加载的问题
- _特性变更_
    - 无

# 3.0.13-beta 2020-09-16

### HuaweiCloud SDK ECS

- _新增特性_
    - 无
- _解决问题_
    - 修正接口参数类型
- _特性变更_
    - 无

### HuaweiCloud SDK BSS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 运营能力开放接口更新

# 3.0.12-beta 2020-09-11

# 3.0.11-beta 2020-09-09

### HuaweiCloud SDK Core

- _新增特性_
    - 无
- _解决问题_
    - 删除代码仓中的冗余Sidecar代码
- _特性变更_
    - 无

### HuaweiCloud SDK DMS

- _新增特性_
    - 支持分布式消息服务，提供Kafka专享版和RabbitMQ专享版
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK VPC

- _新增特性_
    - 无
- _解决问题_
    - 修复安全组相关接口类型错误的问题
- _特性变更_
    - 无

# 3.0.10-beta 2020-09-04

### HuaweiCloud SDK Core

- _新增特性_
    - 无
- _解决问题_
    - 修复yaml中没有定义format的整型枚举参数无法生成枚举代码的问题
- _特性变更_
    - 调整Http请求头的User-Agent信息

# 3.0.9-beta 2020-08-28

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - ListVolumesByTags接口，修改total_count类型定义错误的问题
- _特性变更_
    - 无

### HuaweiCloud SDK IAM

- _新增特性_
    - 新增支持接口：console一致性相关接口
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 新增支持接口：批量操作接口和异步接口
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ProjectMan

- _新增特性_
    - 支持项目管理服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK VPC

- _新增特性_
    - 新增支持接口：安全组、安全组规则和可用IP数
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.8-beta 2020-8-14

### HuaweiCloud SDK Core

- _新增特性_
    - 支持临时AK/SK认证模式
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK BSS

- _新增特性_
    - 支持运营能力开放服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK KMS

- _新增特性_
    - 支持密钥管理服务
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.7-beta 2020-07-30

### HuaweiCloud SDK Core

- _新增特性_
    - 支持文件上传下载
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK ECS

- _新增特性_
    - 发布新接口，如变更操作系统/重置密码
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK VPC

- _新增特性_
    - 支持VPC v3版本的接口
- _解决问题_
    - 无
- _特性变更_
    - 无

# 3.0.6-beta 2020-07-15

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - [Issue #3](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/3)：获取单个磁盘详情接口报错问题修复
- _特性变更_
    - 无

### HuaweiCloud SDK IAM

- _新增特性_
    - 无
- _解决问题_
    - 修复keystoneListVersions响应体解析失败问题
- _特性变更_
    - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 支持资源空间相关接口

# 3.0.5-beta 2020-06-30

### HuaweiCloud SDK Core

- _新增特性_
    - 异步客户端
    - 问题定位场景自定义请求日志输出
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK CTS

- _新增特性_
    - 支持云审计服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK EVS

- _新增特性_
    - 无
- _解决问题_
    - 无
- _特性变更_
    - 支持全量服务接口

### HuaweiCloud SDK IoTDA

- _新增特性_
    - 支持设备接入服务
- _解决问题_
    - 无
- _特性变更_
    - 无
    
