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

# 3.1.74 2023-12-27

### HuaweiCloud SDK AAD

- _新增特性_
  - 支持以下接口：
    - `CreateAadDomain`
    - `CreateCertificate`
    - `ModifyDomainWebSwitch`
    - `ListSourceIps`
    - `AddBlackWhiteIpList`
    - `DeleteBlackWhiteIpList`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CSMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListResourceInstances**
    - 响应参数变更
      - `+ resources.sys_tags`

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ShowInstanceSslDetail`、`UpdateSslSwitch`、`DownloadSslCert`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持接口`ShowClientNetwork`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ListJobs`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`CreateShrinkageJob`、`ShowShrinkCheckResult`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`SetInstancesNewDbShrink`、`StopBackup`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.73 2023-12-22

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowGroups**
    - 响应参数变更
      - `* group.group_message_offsets.lag: int32 -> int64`
  - **ShowInstanceTopicDetail**
    - 响应参数变更
      - `* partitions.replicas.lag: int32 -> int64`

# 3.1.72 2023-12-21

### HuaweiCloud SDK Core

- _新增特性_
  - 无
- _解决问题_
  - 解决在不同文化环境下英文字母大小写转换规则不一致的问题
- _特性变更_
  - 无

### HuaweiCloud SDK AS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateScalingConfig**
    - 请求参数变更
      - `+ instance_config.disk.iops`
      - `+ instance_config.disk.throughput`
      - `+ instance_config.disk.volume_type: enum value [GPSSD2,ESSD2]`
  - **ListScalingConfigs**
    - 响应参数变更
      - `+ scaling_configurations.instance_config.disk.iops`
      - `+ scaling_configurations.instance_config.disk.throughput`
      - `+ scaling_configurations.instance_config.disk.volume_type: enum value [GPSSD2,ESSD2]`
  - **ShowScalingConfig**
    - 响应参数变更
      - `+ scaling_configuration.instance_config.disk.iops`
      - `+ scaling_configuration.instance_config.disk.throughput`
      - `+ scaling_configuration.instance_config.disk.volume_type: enum value [GPSSD2,ESSD2]`

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ValidateDeletableReplica`
- _解决问题_
  - 无
- _特性变更_
  - **ShowExpireKeyScanInfo**
    - 请求参数变更
      - `+ offset`
      - `+ limit`
      - `+ status`

### HuaweiCloud SDK DRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateJobs**
    - 请求参数变更
      - `+ jobs.engine_type: enum value [mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
      - `+ jobs.source_endpoint.db_type: enum value [taurus]`
  - **BatchValidateConnections**
    - 请求参数变更
      - `+ jobs.db_type: enum value [taurus]`
  - **ShowJobList**
    - 请求参数变更
      - `+ engine_type: enum value [gaussdbv5,postgresql,mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
  - **BatchUpdateJob**
    - 请求参数变更
      - `+ jobs.engine_type: enum value [gaussdbv5,postgresql,mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
      - `+ jobs.source_endpoint.db_type: enum value [taurus]`
  - **BatchListJobDetails**
    - 响应参数变更
      - `+ results.source_endpoint.db_type: enum value [taurus]`
      - `+ results.inst_info.engine_type: enum value [gaussdbv5,postgresql,mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
  - **ShowJobDetail**
    - 请求参数变更
      - `+ type: enum value [compare]`
      - `+ type: enum value [comapre]`
      - `+ query_type: enum value [diff]`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateServerTags**
    - 请求参数变更
      - `* tags: list<ServerTag> -> list<BatchAddServerTag>`
  - **UpdateServer**
    - 请求参数变更
      - `+ server.user_data`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`UpdateDisassociatePublicip`、`UpdateAssociatePublicip`

### HuaweiCloud SDK IVS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DetectStandardByNameAndId**
    - 请求参数变更
      - `+ data.req_data.detail`
      - `+ data.req_data.crop`
  - **DetectStandardByIdCardImage**
    - 请求参数变更
      - `+ data.req_data.detail`
      - `+ data.req_data.crop`
  - **DetectStandardByVideoAndIdCardImage**
    - 请求参数变更
      - `+ data.req_data.detail`
  - **DetectStandardByVideoAndNameAndId**
    - 请求参数变更
      - `+ data.req_data.detail`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`SendKafkaMessage`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`CreatePartition`
  - **UpdateInstanceTopic**
    - 请求参数变更
      - `+ topics.new_partition_brokers`
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `* groups.lag: int32 -> int64`
  - **ListInstances**
    - 请求参数变更
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

### HuaweiCloud SDK MPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateTranscodingTask**
    - 请求参数变更
      - `+ video_process.hls_storage_type`

### HuaweiCloud SDK VOD

- _新增特性_
  - 支持接口`ListAssetDailySummaryLog`、`UpdateStorageMode`、`ShowVodRetrieval`
- _解决问题_
  - 无
- _特性变更_
  - **ShowTakeOverAssetDetails**
    - 响应参数变更
      - `+ transcode_info.output.group_id`
      - `+ transcode_info.output.group_name`
  - **PublishAssets**
    - 响应参数变更
      - `+ asset_info_array.is_multi_transcode`
      - `+ asset_info_array.play_info_array.group_id`
      - `+ asset_info_array.play_info_array.group_name`
  - **UnpublishAssets**
    - 响应参数变更
      - `+ asset_info_array.is_multi_transcode`
      - `+ asset_info_array.play_info_array.group_id`
      - `+ asset_info_array.play_info_array.group_name`
  - **ShowAssetMeta**
    - 响应参数变更
      - `+ asset_info_array.is_multi_transcode`
      - `+ asset_info_array.play_info_array.group_id`
      - `+ asset_info_array.play_info_array.group_name`
  - **ShowAssetDetail**
    - 响应参数变更
      - `+ transcode_info.output.group_id`
      - `+ transcode_info.output.group_name`
  - **ShowTakeOverTaskDetails**
    - 响应参数变更
      - `+ assets.transcode_info.output.group_id`
      - `+ assets.transcode_info.output.group_name`

# 3.1.71 2023-12-14

### HuaweiCloud SDK BMS

- _新增特性_
  - 支持接口`DeleteBaremetalServer`
- _解决问题_
  - 无
- _特性变更_
  - **CreateBareMetalServers**
    - 请求参数变更
      - `+ server.root_volume.volumetype: enum value [GPSSD]`
      - `+ server.data_volumes.volumetype: enum value [GPSSD]`

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAlarmTemplates**
    - 请求参数变更
      - `+ template_type: enum value [system_event,custom_event,system_custom_event]`
  - **CreateAlarmTemplate**
    - 请求参数变更
      - `+ template_type`
      - `+ policies.period: enum value [0]`
  - **UpdateAlarmTemplate**
    - 请求参数变更
      - `+ policies.period: enum value [0]`

### HuaweiCloud SDK CFW

- _新增特性_
  - 支持接口`CreateFirewall`、`ListJob`、`DeleteFirewall`
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
  - **ShowResInstanceInfo**
    - 响应参数变更
      - `+ resources.resource_detail.detailId`
      - `- resources.resource_detail.resource_id`
      - `- resources.resource_detail.func_urn`
      - `- resources.resource_detail.func_name`
      - `- resources.resource_detail.domain_id`
      - `- resources.resource_detail.namespace`
      - `- resources.resource_detail.project_name`
      - `- resources.resource_detail.package`
      - `- resources.resource_detail.runtime`
      - `- resources.resource_detail.timeout`
      - `- resources.resource_detail.handler`
      - `- resources.resource_detail.memory_size`
      - `- resources.resource_detail.gpu_memory`
      - `- resources.resource_detail.cpu`
      - `- resources.resource_detail.code_type`
      - `- resources.resource_detail.code_url`
      - `- resources.resource_detail.code_filename`
      - `- resources.resource_detail.code_size`
      - `- resources.resource_detail.user_data`
      - `- resources.resource_detail.encrypted_user_data`
      - `- resources.resource_detail.digest`
      - `- resources.resource_detail.version`
      - `- resources.resource_detail.image_name`
      - `- resources.resource_detail.xrole`
      - `- resources.resource_detail.app_xrole`
      - `- resources.resource_detail.description`
      - `- resources.resource_detail.last_modified`
      - `- resources.resource_detail.func_vpc_id`
      - `- resources.resource_detail.strategy_config`
      - `- resources.resource_detail.extend_config`
      - `- resources.resource_detail.initializer_handler`
      - `- resources.resource_detail.initializer_timeout`
      - `- resources.resource_detail.pre_stop_handler`
      - `- resources.resource_detail.pre_stop_timeout`
      - `- resources.resource_detail.enterprise_project_id`
      - `- resources.resource_detail.long_time`
      - `- resources.resource_detail.log_group_id`
      - `- resources.resource_detail.log_stream_id`
      - `- resources.resource_detail.type`
      - `- resources.resource_detail.fail_count`
      - `- resources.resource_detail.is_bridge_function`
      - `- resources.resource_detail.bind_bridge_funcUrns`
      - `* resources.resource_detail: object<ListFunctionResult> -> object<ListEnterpriseResourceDetail>`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateAsyncCommand**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **ShowAsyncDeviceCommand**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **BroadcastMessage**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **CreateCommand**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **ListProperties**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
    - 响应参数变更
      - `+ request_id`
  - **UpdateProperties**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
    - 响应参数变更
      - `+ request_id`
  - **CloseDeviceTunnel**
    - 请求参数变更
      - `+ Sp-Auth-Token`
  - **DeleteDeviceTunnel**
    - 请求参数变更
      - `+ Sp-Auth-Token`
  - **ShowDeviceTunnel**
    - 请求参数变更
      - `+ Sp-Auth-Token`
  - **AddTunnel**
    - 请求参数变更
      - `+ Sp-Auth-Token`
  - **ListDeviceTunnels**
    - 请求参数变更
      - `+ Sp-Auth-Token`
  - **ShowDeviceMessage**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **CreateMessage**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **ListDeviceMessages**
    - 请求参数变更
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`

### HuaweiCloud SDK Live

- _新增特性_
  - 支持以下接口：
    - `ListDelayConfig`
    - `UpdateDelayConfig`
    - `ShowPullSourcesConfig`
    - `UpdatePullSourcesConfig`
    - `ListGeoBlockingConfig`
    - `UpdateGeoBlockingConfig`
    - `CreateUrlAuthchain`
    - `ListIpAuthList`
    - `UpdateIpAuthList`
    - `ListPublishTemplate`
    - `UpdatePublishTemplate`
    - `DeletePublishTemplate`
- _解决问题_
  - 无
- _特性变更_
  - **ListRecordContents**
    - 请求参数变更
      - `+ record_type: enum value [PLAN_RECORD,ON_DEMAND_RECORD]`
    - 响应参数变更
      - `- record_contents.record_type: enum value [PLAN_RECORD,ON_DEMAND_RECORD]`

### HuaweiCloud SDK LTS

- _新增特性_
  - 支持接口`CreateAgencyAccess`
- _解决问题_
  - 无
- _特性变更_
  - **ListSqlAlarmRules**
    - 响应参数变更
      - `+ sql_alarm_rules.is_css_sql`
      - `+ sql_alarm_rules.notification_frequency`
      - `+ sql_alarm_rules.alarm_action_rule_name`
      - `+ sql_alarm_rules.status: enum value [RUNNING 启用,STOPPING 停止]`
      - `- sql_alarm_rules.status: enum value [RUNNING,STOPPING]`
      - `* sql_alarm_rules.frequency: object<Frequency> -> object<FrequencyRespBody>`
  - **UpdateSqlAlarmRule**
    - 请求参数变更
      - `+ is_css_sql`
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
      - `* frequency: object<Frequency> -> object<CreateSqlAlarmRuleFrequency>`
    - 响应参数变更
      - `+ is_css_sql`
      - `+ alarm_action_rule_name`
      - `+ notification_frequency`
      - `+ language: enum value [zh-cn,en-us]`
      - `* frequency: object<Frequency> -> object<FrequencyRespBody>`
  - **CreateSqlAlarmRule**
    - 请求参数变更
      - `+ is_css_sql`
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
      - `* frequency: object<Frequency> -> object<CreateSqlAlarmRuleFrequency>`
  - **ListKeywordsAlarmRules**
    - 响应参数变更
      - `+ keywords_alarm_rules.notification_frequency`
      - `+ keywords_alarm_rules.alarm_action_rule_name`
      - `+ keywords_alarm_rules.status: enum value [RUNNING  启用,STOPPING  停止]`
      - `- keywords_alarm_rules.status: enum value [RUNNING,STOPPING]`
  - **UpdateKeywordsAlarmRule**
    - 请求参数变更
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
    - 响应参数变更
      - `+ alarm_action_rule_name`
      - `+ notification_frequency`
      - `+ language: enum value [zh-cn,en-us]`
      - `- keywords_requests.search_time_range_unit: enum value [minute]`
      - `* keywords_requests: list<KeywordsRequest> -> list<KeywordsResBody>`
      - `* frequency: object<Frequency> -> object<FrequencyRespBody>`
  - **CreateKeywordsAlarmRule**
    - 请求参数变更
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
      - `+ keywords_alarm_level: enum value [Critical]`
      - `- keywords_alarm_level: enum value [CRITICAL]`

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateNatGatewayTag**
    - 请求参数变更
      - `+ tag.key`
      - `+ tag.value`
      - `* tag: object -> object<TagBody>`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ListLogLtsConfigs`、`SetLogLtsConfigs`、`DeleteLogLtsConfigs`
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
  - **CreateRocketMqMigrationTask**
    - 请求参数变更
      - `+ topicConfigTable`
      - `+ subscriptionGroupTable`
      - `+ vhosts`
      - `+ queues`
      - `+ exchanges`
      - `+ bindings`
      - `* body: map<string, object> -> object<CreateRocketMqMigrationTaskReq>`

# 3.1.70 2023-12-07

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`DeleteStackInstance`
- _解决问题_
  - 无
- _特性变更_
  - **ListStackSetOperations**
    - 响应参数变更
      - `+ stack_set_operations.action: enum value [UPDATE_STACK_INSTANCES]`
  - **ShowStackSetOperationMetadata**
    - 响应参数变更
      - `+ action: enum value [UPDATE_STACK_INSTANCES]`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `ShowDependcy`
    - `UpdateDependcy`
    - `DeleteDependency`
    - `AsyncInvokeReservedFunction`
    - `CreateDependency`
  - **ShowFuncReservedInstanceMetrics**
    - 请求参数变更
      - `+ marker`
      - `+ limit`
  - **ListFunctionApplications**
    - 请求参数变更
      - `+ limit`
      - `+ marker`
  - **ListStatistics**
    - 请求参数变更
      - `+ limit`
      - `+ marker`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`ListGaussMySqlInstancesUnifyStatus`、`ShowGaussMySqlInstanceInfoUnifyStatus`、`ListGaussMySqlInstanceDetailInfoUnifyStatus`、`SwitchGaussMySqlProxySsl`
- _解决问题_
  - 无
- _特性变更_
  - **ShowGaussMySqlProxyList**
    - 响应参数变更
      - `+ proxy_list.proxy.ssl_option`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`OfflineNodes`
- _解决问题_
  - 无
- _特性变更_
  - **ListLtsConfigs**
    - 响应参数变更
      - `* instance_lts_configs.instance.supported_log_types: string -> list<string>`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ResetDeviceSecret**
    - 请求参数变更
      - `+ secret_type`
    - 响应参数变更
      - `+ secret_type`
  - **ResetFingerprint**
    - 请求参数变更
      - `+ fingerprint_type`
    - 响应参数变更
      - `+ fingerprint_type`
  - **ShowDevice**
    - 响应参数变更
      - `+ auth_info.secondary_secret`
      - `+ auth_info.secondary_fingerprint`
      - `* auth_info: object<AuthInfo> -> object<AuthInfoRes>`
  - **UpdateDevice**
    - 响应参数变更
      - `+ auth_info.secondary_secret`
      - `+ auth_info.secondary_fingerprint`
      - `* auth_info: object<AuthInfo> -> object<AuthInfoRes>`
  - **AddDevice**
    - 响应参数变更
      - `+ auth_info.secondary_secret`
      - `+ auth_info.secondary_fingerprint`
      - `* auth_info: object<AuthInfo> -> object<AuthInfoRes>`

### HuaweiCloud SDK NAT

- _新增特性_
  - 支持以下接口：
    - `ListNatGatewayByTag`
    - `BatchCreateDeleteNatGatewayTag`
    - `ShowNatGatewayTag`
    - `CreateNatGatewayTag`
    - `DeleteNatGatewayTag`
    - `ListNatGatewayTag`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持接口`ShowRocketMqConfigs`、`UpdateRocketMqConfigs`
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 请求参数变更
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

# 3.1.69 2023-11-30

### HuaweiCloud SDK AOM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPermissions**
    - 响应参数变更
      - `* : map<string, AuthModel> -> string`
  - **ListAccessCode**
    - 响应参数变更
      - `- access_codes.status: enum value [enable,unenable]`

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持以下接口：
    - `ShowClusterConfig`
    - `UpdateClusterLogConfig`
    - `ListPartitions`
    - `CreatePartition`
    - `ShowPartition`
    - `UpdatePartition`
    - `ShowNodePoolConfigurations`
    - `UpdateNodePoolConfiguration`
    - `ShowClusterConfigurationDetails`
    - `ListCharts`
    - `UploadChart`
    - `ShowChart`
    - `UpdateChart`
    - `DeleteChart`
    - `DownloadChart`
    - `ShowChartValues`
    - `ShowUserChartsQuotas`
    - `ListReleases`
    - `CreateRelease`
    - `ShowRelease`
    - `UpdateRelease`
    - `DeleteRelease`
    - `ShowReleaseHistory`
- _解决问题_
  - 无
- _特性变更_
  - **ResizeCluster**
    - 请求参数变更
      - `* extendParam: object<ResizeClusterRequestExtendParam> -> object`
  - **UpdateClusterEip**
    - 请求参数变更
      - `* spec: object -> object<MasterEIPRequestSpec>`
    - 响应参数变更
      - `* spec: object -> object<MasterEIPResponseSpec>`
  - **ShowClusterEndpoints**
    - 响应参数变更
      - `* spec: object -> object<OpenAPISpec>`
  - **ShowAddonInstance**
    - 响应参数变更
      - `- status.status: enum value [unknown]`
  - **UpdateAddonInstance**
    - 响应参数变更
      - `- status.status: enum value [unknown]`
  - **RollbackAddonInstance**
    - 响应参数变更
      - `- status.status: enum value [unknown]`
  - **ShowCluster**
    - 响应参数变更
      - `+ spec.enableMasterVolumeEncryption`
  - **UpdateCluster**
    - 响应参数变更
      - `+ spec.enableMasterVolumeEncryption`
  - **DeleteCluster**
    - 请求参数变更
      - `+ ondemand_node_policy`
      - `+ periodic_node_policy`
    - 响应参数变更
      - `+ spec.enableMasterVolumeEncryption`
  - **CreateAddonInstance**
    - 响应参数变更
      - `- status.status: enum value [unknown]`
  - **ListAddonInstances**
    - 响应参数变更
      - `- items.status.status: enum value [unknown]`
  - **CreateCluster**
    - 请求参数变更
      - `+ spec.enableMasterVolumeEncryption`
    - 响应参数变更
      - `+ spec.enableMasterVolumeEncryption`
  - **ListClusters**
    - 请求参数变更
      - `+ status: enum value [Hibernating,Hibernation,Awaking]`
    - 响应参数变更
      - `+ items.spec.enableMasterVolumeEncryption`
  - **ShowNode**
    - 响应参数变更
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
    - 响应参数变更
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.hostnameConfig`
      - `+ items.spec.extendParam.kubeReservedMem`
      - `+ items.spec.extendParam.systemReservedMem`
      - `+ items.spec.extendParam.init-node-password`
      - `- items.spec.extendParam.kube-reserved-mem`
      - `- items.spec.extendParam.system-reserved-mem`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **UpdateNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **AddNode**
    - 请求参数变更
      - `+ nodeList.spec.hostnameConfig`
  - **ResetNode**
    - 请求参数变更
      - `+ nodeList.spec.hostnameConfig`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
    - 响应参数变更
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.nodeTemplate.hostnameConfig`
      - `+ items.spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ items.spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ items.spec.nodeTemplate.extendParam.init-node-password`
      - `- items.spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- items.spec.nodeTemplate.extendParam.system-reserved-mem`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSlowlog**
    - 响应参数变更
      - `+ total_num`

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持接口`BatchModifyBandwidth`、`ListEipBandwidths`、`ListBandwidthsLimit`、`UpdatePublicip`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ListInfluxdbSlowLogs`
- _解决问题_
  - 无
- _特性变更_
  - **ListLtsConfigs**
    - 响应参数变更
      - `+ instance_lts_configs.instance.supported_log_types`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunQueryDocumentModerationJob**
    - 响应参数变更
      - `+ result.details.start_position`
      - `+ result.details.end_position`
      - `+ result.details.image_url`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`SetInstancesDbShrink`
- _解决问题_
  - 无
- _特性变更_
  - **UpgradeDbMajorVersion**
    - 响应参数变更
      - `+ job_id`
  - **ShowUpgradeDbMajorVersionStatus**
    - 响应参数变更
      - `+ check_expiration_time`
      - `- report_expiration_time`
  - **StartResizeFlavorAction**
    - 响应参数变更
      - `+ order_id`
  - **StartInstanceEnlargeVolumeAction**
    - 响应参数变更
      - `+ order_id`
  - **StartInstanceSingleToHaAction**
    - 响应参数变更
      - `+ order_id`
  - **ListHistoryDatabase**
    - 请求参数变更
      - `+ engine`
      - `- database_name`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持接口`ShowEngineInstanceExtendProductInfo`、`ResizeInstance`
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
  - **RecognizeFlashAsr**
    - 请求参数变更
      - `* obs_bucket_name: optional -> required`
      - `* obs_object_key: optional -> required`

# 3.1.68 2023-11-23

### HuaweiCloud SDK CFW

- _新增特性_
  - 支持接口`ListLogConfig`、`UpdateLogConfig`、`AddLogConfig`、`CreateEastWestFirewall`
- _解决问题_
  - 无
- _特性变更_
  - **ListFlowLogs**
    - 响应参数变更
      - `* data.records.start_time: int32 -> int64`
      - `* data.records.end_time: int32 -> int64`
      - `* data.records.src_port: string -> int32`
      - `* data.records.dst_port: string -> int32`
  - **ListAccessControlLogs**
    - 响应参数变更
      - `* data.records.hit_time: int32 -> int64`
      - `* data.records.src_port: string -> int32`
      - `* data.records.dst_port: string -> int32`
  - **ChangeIpsSwitchStatus**
    - 请求参数变更
      - `+ X-Language`
  - **ListAttackLogs**
    - 响应参数变更
      - `* data.records.event_time: string -> int64`
      - `* data.records.attack_rule_id: int32 -> string`
      - `* data.records.packet: object<Packet> -> string`

# 3.1.67 2023-11-23

### HuaweiCloud SDK AOM

- _新增特性_
  - 支持以下接口：
    - `ListPromInstance`
    - `CreatePromInstance`
    - `DeletePromInstance`
    - `CreateRecordingRule`
    - `ListPermissions`
    - `ListAccessCode`
    - `ListAgents`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`LogoffWebCli`
- _解决问题_
  - 无
- _特性变更_
  - **ListSlowlog**
    - 响应参数变更
      - `+ slowlogs.database_id`
      - `+ slowlogs.username`

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持以下接口：
    - `ListLtsConfigs`
    - `UpdateLtsConfig`
    - `DeleteLtsConfig`
    - `ListLtsErrorLogs`
    - `ShowKillOpRuleRuleList`
    - `UpdateKillOpRule`
    - `CreateKillOpRule`
    - `DeleteKillOpRuleList`
    - `SwitchInstancePrimary`
    - `DeleteReadonlyNode`
    - `StopBackup`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchDeleteJobs**
    - 请求参数变更
      - `+ jobs.is_show_breakpoint_position`
  - **BatchSetPolicy**
    - 请求参数变更
      - `+ jobs.file_and_position`
      - `+ jobs.gtid_set`
  - **BatchListProgresses**
    - 响应参数变更
      - `+ results.incre_trans_delay_millis`
  - **ShowJobList**
    - 请求参数变更
      - `+ instance_ids`
      - `+ instance_ip`

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持接口`UploadJdbcDriver`、`ListJdbcDrivers`、`DeleteJdbcDriver`、`SyncJdbcDriver`
- _解决问题_
  - 无
- _特性变更_
  - **BatchCreateJobsAsync**
    - 请求参数变更
      - `+ jobs.policy_config.dml_types`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.connection_management`
      - `+ jobs.policy_config.dml_types`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.params.policy_config.dml_types`
  - **ShowJobDetail**
    - 响应参数变更
      - `+ job.connection_management`
      - `+ job.policy_config.dml_types`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.params.policy_config.dml_types`

### HuaweiCloud SDK ELB

- _新增特性_
  - 支持以下接口：
    - `BatchAddAvailableZones`
    - `BatchRemoveAvailableZones`
    - `ListMasterSlavePools`
    - `CreateMasterSlavePool`
    - `ShowMasterSlavePool`
    - `DeleteMasterSlavePool`
- _解决问题_
  - 无
- _特性变更_
  - **ShowLoadBalancer**
    - 响应参数变更
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.log_group_id`
      - `+ loadbalancer.log_topic_id`
  - **UpdateLoadBalancer**
    - 请求参数变更
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.ipv6_vip_address`
    - 响应参数变更
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.log_group_id`
      - `+ loadbalancer.log_topic_id`
  - **ListListeners**
    - 响应参数变更
      - `+ listeners.ssl_early_data_enable`
  - **CreateListener**
    - 请求参数变更
      - `+ listener.ssl_early_data_enable`
    - 响应参数变更
      - `+ listener.ssl_early_data_enable`
  - **ShowListener**
    - 响应参数变更
      - `+ listener.ssl_early_data_enable`
  - **UpdateListener**
    - 请求参数变更
      - `+ listener.ssl_early_data_enable`
    - 响应参数变更
      - `+ listener.ssl_early_data_enable`
  - **ListLoadBalancers**
    - 请求参数变更
      - `+ log_topic_id`
      - `+ log_group_id`
    - 响应参数变更
      - `+ loadbalancers.charge_mode`
      - `+ loadbalancers.log_group_id`
      - `+ loadbalancers.log_topic_id`
  - **CreateLoadBalancer**
    - 请求参数变更
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.ipv6_vip_address`
    - 响应参数变更
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.log_group_id`
      - `+ loadbalancer.log_topic_id`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持以下接口：
    - `ListAppTemplates`
    - `ShowAppTemplate`
    - `ListFunctionApplications`
    - `CreateFunctionApp`
    - `ShowFunctionApp`
    - `DeleteFunctionApp`
    - `CreateCallbackWorkflow`
- _解决问题_
  - 无
- _特性变更_
  - **ImportFunction**
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ListFunctions**
    - 响应参数变更
      - `+ functions.pre_stop_handler`
      - `+ functions.pre_stop_timeout`
  - **CreateFunction**
    - 请求参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ShowFunctionConfig**
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **UpdateFunctionConfig**
    - 请求参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **UpdateFunctionMaxInstanceConfig**
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ListBridgeFunctions**
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ShowResInstanceInfo**
    - 响应参数变更
      - `+ resources.resource_detail.pre_stop_handler`
      - `+ resources.resource_detail.pre_stop_timeout`
  - **CreateFunctionVersion**
    - 响应参数变更
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ListFunctionVersions**
    - 响应参数变更
      - `+ versions.pre_stop_handler`
      - `+ versions.pre_stop_timeout`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`ShowRestoreTables`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持以下接口：
    - `ShowElbIpGroup`
    - `SwitchIpGroup`
    - `ListInstancesSession`
    - `DeleteInstancesSession`
    - `ListInstancesSessionStatistics`
    - `ResetParamGroupTemplate`
    - `ListRedisSlowLogs`
    - `ListCassandraSlowLogs`
    - `ListMongodbSlowLogs`
    - `ListLtsConfigs`
    - `SaveLtsConfigs`
    - `DeleteLtsConfigs`
    - `ListRestoreDatabases`
    - `ListRestoreTables`
    - `ListMongodbErrorLogs`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`ShowKafkaUserClientQuota`、`UpdateKafkaUserClientQuotaTask`、`CreateKafkaUserClientQuotaTask`、`DeleteKafkaUserClientQuotaTask`
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 请求参数变更
      - `+ status: enum value [DELETING,ERROR,CREATEFAILED,FREEZING,EXTENDING,SHRINKING,EXTENDEDFAILED,CONFIGURING,UPGRADING,UPGRADINGFAILED,ROLLBACK,ROLLBACKFAILED,VOLUMETYPECHANGING]`
      - `+ status: enum value [FAULTY,RESIZING,RESIZING FAILED]`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeIdCard**
    - 请求参数变更
      - `+ return_portrait_location`
    - 响应参数变更
      - `+ result.portrait_location`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstancesDetails**
    - 请求参数变更
      - `+ status: enum value [DELETING,FREEZING,EXTENDING,SHRINKING,EXTENDEDFAILED,CONFIGURING,UPGRADING,UPGRADINGFAILED,ROLLBACK,ROLLBACKFAILED,VOLUMETYPECHANGING]`
      - `+ status: enum value [STARTING,CLOSING]`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持以下接口：
    - `UpgradeDbMajorVersion`
    - `ShowAvailableVersion`
    - `UpgradeDbMajorVersionPreCheck`
    - `ListInspectionHistories`
    - `ListUpgradeHistories`
    - `ShowUpgradeDbMajorVersionStatus`
    - `UpdateTdeStatus`
    - `ShowTdeStatus`
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
  - **ListInstances**
    - 请求参数变更
      - `+ status: enum value [DELETING,ERROR,CREATEFAILED,FREEZING,EXTENDING,SHRINKING,EXTENDEDFAILED,CONFIGURING,UPGRADING,UPGRADINGFAILED,ROLLBACK,ROLLBACKFAILED,VOLUMETYPECHANGING]`
      - `+ status: enum value [FAULTY,RESIZING,RESIZING FAILED]`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateAssetByFileUpload**
    - 请求参数变更
      - `+ thumbnail.quantity`
      - `+ thumbnail.quantity_time`
      - `+ thumbnail.type: enum value [quantity]`
  - **PublishAssetFromObs**
    - 请求参数变更
      - `+ thumbnail.quantity`
      - `+ thumbnail.quantity_time`
      - `+ thumbnail.type: enum value [quantity]`
  - **CreateAssetProcessTask**
    - 请求参数变更
      - `+ thumbnail.quantity`
      - `+ thumbnail.quantity_time`
      - `+ thumbnail.type: enum value [quantity]`
  - **ListTopStatistics**
    - 响应参数变更
      - `+ top_urls.duration_ms`
  - **UploadMetaDataByUrl**
    - 请求参数变更
      - `+ upload_metadatas.thumbnail.quantity`
      - `+ upload_metadatas.thumbnail.quantity_time`
      - `+ upload_metadatas.thumbnail.type: enum value [quantity]`
  - **ListAssetList**
    - 响应参数变更
      - `+ assets.duration_ms`
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
      - `+ thumbnail_info.quantity`
  - **ShowTakeOverTaskDetails**
    - 响应参数变更
      - `+ assets.base_info.meta_data.duration_ms`

# 3.1.66 2023-11-16

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.business_type`
      - `+ configs.service_area`
      - `+ configs.remark`
      - `+ configs.flexible_origin`
      - `+ configs.slice_etag_status`
      - `+ configs.origin_receive_timeout`
      - `+ configs.remote_auth`
      - `+ configs.websocket`
      - `+ configs.video_seek`
      - `+ configs.request_limit_rules`
      - `+ configs.ip_frequency_limit`
      - `+ configs.hsts`
      - `+ configs.quic`
      - `+ configs.url_auth.sign_method`
      - `+ configs.url_auth.match_type`
      - `+ configs.url_auth.inherit_config`
      - `+ configs.url_auth.key`
      - `+ configs.url_auth.backup_key`
      - `+ configs.url_auth.sign_arg`
      - `+ configs.https.expire_time`
      - `+ configs.https.certificate_type`
      - `+ configs.https.ocsp_stapling_status`
      - `+ configs.sources.weight`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.sources.weight`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`

### HuaweiCloud SDK CodeArtsBuild

- _新增特性_
  - 支持以下接口：
    - `DownloadBuildLog`
    - `DownloadTaskLog`
    - `ShowFlowGraph`
    - `ShowRecordDetail`
    - `ShowOutputInfo`
    - `StopJob`
    - `CreateBuildJob`
    - `UpdateBuildJob`
    - `ListTemplates`
    - `CreateTemplates`
    - `DeleteTemplates`
    - `ListNotice`
    - `UpdateNotice`
    - `DisableNotice`
    - `ListJobConfig`
- _解决问题_
  - 无
- _特性变更_
  - **ShowRecordInfo**
    - 响应参数变更
      - `+ result.duration`

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreatePrivateZone**
    - 请求参数变更
      - `+ router.status`
  - **AssociateRouter**
    - 请求参数变更
      - `+ router.status`
  - **DisassociateRouter**
    - 请求参数变更
      - `+ router.status`
  - **ShowPrivateZone**
    - 响应参数变更
      - `+ routers.status`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持以下接口：
    - `ListFunctionTags`
    - `ListBridgeFunctions`
    - `ListBridgeVersions`
    - `UpdateFunctionCollectState`
    - `ListFunctionTemplate`
    - `ShowFunctionTemplate`
    - `ShowFuncReservedInstanceMetrics`
    - `ShowFunctionMetrics`
    - `EnableAsyncStatusLog`
    - `ShowProjectAsyncStatusLogInfo`
- _解决问题_
  - 无
- _特性变更_
  - **ListFunctions**
    - 响应参数变更
      - `+ functions.resource_id`
  - **ShowFunctionConfig**
    - 响应参数变更
      - `+ func_id`
      - `+ resource_id`
  - **UpdateFunctionConfig**
    - 响应参数变更
      - `+ func_id`
      - `+ resource_id`
  - **ShowResInstanceInfo**
    - 响应参数变更
      - `+ resources.resource_detail.resource_id`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateGaussMySqlInstance**
    - 响应参数变更
      - `* instance.volume.size: string -> int32`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowRuleAction**
    - 响应参数变更
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
  - **UpdateRuleAction**
    - 请求参数变更
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
    - 响应参数变更
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
  - **CreateRuleAction**
    - 请求参数变更
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
    - 响应参数变更
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
  - **ListRuleActions**
    - 响应参数变更
      - `+ actions.channel_detail.dms_kafka_forwarding.security_protocol`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `* groups.createdAt: int32 -> int64`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListTopnTrafficStatistics**
    - 响应参数变更
      - `+ results.cold_storage`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizePeruIdCard`
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
  - 移除接口`ShowRabbitMqProductCores`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`RevokePostgresqlDbPrivilege`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.65 2023-11-13

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ShowNodesInformation`、`DeleteCenterTask`、`DeleteDiagnosisTask`
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
  - **ListInstanceTopics**
    - 请求参数变更
      - `+ offset`
      - `+ limit`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **Createfavorite**
    - 请求参数变更
      - `+ is_global`
    - 响应参数变更
      - `+ is_global`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 支持接口`ShowRabbitMqProductCores`、`ShowCesHierarchy`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ListPostgresqlListHistoryTables`、`ListHistoryDatabase`、`BatchRestorePostgreSqlTables`、`BatchRestoreDatabase`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ListInstancesResourceMetrics`、`ListInstancesRecommendation`

# 3.1.64 2023-11-09

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddonInstance**
    - 响应参数变更
      - `+ status.status: enum value [unknown]`
  - **UpdateAddonInstance**
    - 响应参数变更
      - `+ status.status: enum value [unknown]`
  - **RollbackAddonInstance**
    - 响应参数变更
      - `+ status.status: enum value [unknown]`
  - **ShowCluster**
    - 响应参数变更
      - `+ spec.serviceNetwork`
  - **UpdateCluster**
    - 响应参数变更
      - `+ spec.serviceNetwork`
  - **DeleteCluster**
    - 响应参数变更
      - `+ spec.serviceNetwork`
  - **CreateAddonInstance**
    - 响应参数变更
      - `+ status.status: enum value [unknown]`
  - **ListAddonInstances**
    - 响应参数变更
      - `+ items.status.status: enum value [unknown]`
  - **CreateCluster**
    - 请求参数变更
      - `+ spec.serviceNetwork`
    - 响应参数变更
      - `+ spec.serviceNetwork`
  - **ListClusters**
    - 响应参数变更
      - `+ items.spec.serviceNetwork`
  - **ShowNode**
    - 响应参数变更
      - `- status.phase: enum value [Installed,ShutDown]`
  - **UpdateNode**
    - 响应参数变更
      - `- status.phase: enum value [Installed,ShutDown]`
  - **DeleteNode**
    - 响应参数变更
      - `- status.phase: enum value [Installed,ShutDown]`
  - **CreateNode**
    - 响应参数变更
      - `- status.phase: enum value [Installed,ShutDown]`
  - **ListNodes**
    - 响应参数变更
      - `- items.status.phase: enum value [Installed,ShutDown]`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`CheckMigrationConnectivity`
  - **ListBackupRecords**
    - 响应参数变更
      - `+ backup_record_response.backup_format`
      - `+ backup_record_response.execution_at`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`ShowInstanceConfigs`、`ModifyInstanceConfigs`
- _解决问题_
  - 无
- _特性变更_
  - **BatchRestartOrDeleteInstances**
    - 请求参数变更
      - `+ all_failure`
      - `- allFailure`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchRestartOrDeleteInstances**
    - 请求参数变更
      - `+ all_failure`
      - `- allFailure`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchDeleteInstances**
    - 请求参数变更
      - `+ all_failure`
      - `- allFailure`
  - **DeleteRocketMqMigrationTask**
    - 请求参数变更
      - `+ task_ids`
      - `- taskIds`

# 3.1.63 2023-11-02

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持以下接口：
    - `ShowConfigHistoryDetail`
    - `UpdateClientIpTransparentTransmission`
    - `UpdateInstanceConfig`
    - `ListInstanceOperations`
    - `ExportInstancesTask`
    - `ExportExcelJob`
    - `CreateResizeOrder`
    - `ShowExpireAutoScanConfig`
    - `UpdateExpireAutoScanConfig`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowNodesInformation`、`ShowBackUpInfo`、`CreateOrUpdateBackUpInfo`、`CreateConnectivityTest`

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowPrivateZone**
    - 响应参数变更
      - `+ enterprise_project_id`
      - `+ proxy_pattern`

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持接口`CollectPositionAsync`、`ShowPositionResult`
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
  - **ListListeners**
    - 请求参数变更
      - `+ proxy_protocol_enable`
    - 响应参数变更
      - `+ listeners.proxy_protocol_enable`
      - `+ listeners.insert_headers.X-Forwarded-Proto`
      - `+ listeners.insert_headers.X-Real-IP`
      - `+ listeners.insert_headers.X-Forwarded-ELB-ID`
      - `+ listeners.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listeners.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listeners.insert_headers.X-Forwarded-TLS-Cipher`
  - **CreateListener**
    - 请求参数变更
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
    - 响应参数变更
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
  - **ShowListener**
    - 响应参数变更
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
  - **UpdateListener**
    - 请求参数变更
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
    - 响应参数变更
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
  - **CreatePool**
    - 请求参数变更
      - `+ pool.ip_version`
  - **UpdatePool**
    - 请求参数变更
      - `+ pool.any_port_enable`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `ShowIntelligentDiagnosisAbnormalCountOfInstances`
    - `ShowIntelligentDiagnosisInstanceInfosPerMetric`
    - `ShrinkGaussMySqlProxy`
    - `ShowInstanceDatabaseVersion`
    - `CopyInstanceConfigurations`
    - `ShowAutoScalingPolicy`
    - `UpdateAutoScalingPolicy`
    - `CheckResource`
    - `UpdateInstanceConfigurations`
- _解决问题_
  - 无
- _特性变更_
  - **DeleteGaussMySqlBackup**
    - 响应参数变更
      - `+ backup_id`
      - `+ backup_name`
      - `- job_id`
  - **CreateGaussMySqlProxy**
    - 请求参数变更
      - `+ subnet_id`
  - **ShowGaussMySqlBackupList**
    - 请求参数变更
      - `+ name`
      - `+ instance_name`
    - 响应参数变更
      - `+ backups.instance_name`
      - `- backups.status: enum value [BUILDING,COMPLETED,FAILED,AVAILABLE]`
      - `- backups.type: enum value [auto,manual]`
  - **ShowGaussMySqlProxyList**
    - 响应参数变更
      - `+ proxy_list.proxy.subnet_id`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持接口`DeleteDatabase`
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 请求参数变更
      - `+ charge_mode`
  - **ListInstancesDetails**
    - 请求参数变更
      - `+ charge_mode`

### HuaweiCloud SDK KPS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ImportPrivateKey**
    - 响应参数变更
      - `+ keypair.user_id`
      - `+ keypair.key_protection`
      - `* keypair: object<KeypairBean> -> object<ImportPrivateKeyAction>`

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListNatGatewayDnatRules**
    - 响应参数变更
      - `+ dnat_rules.global_eip_id`
      - `+ dnat_rules.global_eip_address`
  - **CreateNatGatewayDnatRule**
    - 请求参数变更
      - `+ dnat_rule.global_eip_id`
    - 响应参数变更
      - `+ dnat_rule.global_eip_id`
      - `+ dnat_rule.global_eip_address`
  - **ShowNatGatewayDnatRule**
    - 响应参数变更
      - `+ dnat_rule.global_eip_id`
      - `+ dnat_rule.global_eip_address`
  - **UpdateNatGatewayDnatRule**
    - 请求参数变更
      - `+ dnat_rule.global_eip_id`
    - 响应参数变更
      - `+ dnat_rule.global_eip_id`
      - `+ dnat_rule.global_eip_address`
  - **BatchCreateNatGatewayDnatRules**
    - 请求参数变更
      - `+ dnat_rules.global_eip_id`
    - 响应参数变更
      - `+ dnat_rules.global_eip_id`
      - `+ dnat_rules.global_eip_address`
  - **ListNatGatewaySnatRules**
    - 响应参数变更
      - `+ snat_rules.global_eip_id`
      - `+ snat_rules.global_eip_address`
  - **CreateNatGatewaySnatRule**
    - 请求参数变更
      - `+ snat_rule.global_eip_id`
    - 响应参数变更
      - `+ snat_rule.global_eip_id`
      - `+ snat_rule.global_eip_address`
  - **ShowNatGatewaySnatRule**
    - 响应参数变更
      - `+ snat_rule.global_eip_id`
      - `+ snat_rule.global_eip_address`
  - **UpdateNatGatewaySnatRule**
    - 请求参数变更
      - `+ snat_rule.global_eip_id`
    - 响应参数变更
      - `+ snat_rule.global_eip_address`
      - `+ snat_rule.global_eip_id`
  - **ListNatGateways**
    - 响应参数变更
      - `+ nat_gateways.ngport_ip_address`
      - `+ nat_gateways.billing_info`
      - `+ nat_gateways.dnat_rules_limit`
      - `+ nat_gateways.snat_rule_public_ip_limit`
  - **CreateNatGateway**
    - 请求参数变更
      - `+ nat_gateway.ngport_ip_address`
    - 响应参数变更
      - `+ nat_gateway.ngport_ip_address`
      - `+ nat_gateway.billing_info`
      - `+ nat_gateway.dnat_rules_limit`
      - `+ nat_gateway.snat_rule_public_ip_limit`
  - **ShowNatGateway**
    - 响应参数变更
      - `+ nat_gateway.ngport_ip_address`
      - `+ nat_gateway.billing_info`
      - `+ nat_gateway.dnat_rules_limit`
      - `+ nat_gateway.snat_rule_public_ip_limit`
  - **UpdateNatGateway**
    - 响应参数变更
      - `+ nat_gateway.ngport_ip_address`
      - `+ nat_gateway.billing_info`
      - `+ nat_gateway.dnat_rules_limit`
      - `+ nat_gateway.snat_rule_public_ip_limit`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateRocketMqMigrationTask**
    - 请求参数变更
      - `* body: string -> map<string, object>`

# 3.1.62 2023-10-26

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`ShowStackInstance`、`UpdateStackInstances`
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
  - **CreateBareMetalServers**
    - 请求参数变更
      - `+ server.extendparam.chargingMode: enum value [postPaid]`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持以下接口：
    - `CreateRefreshTasks`
    - `CreatePreheatingTasks`
    - `ShowHistoryTasks`
    - `ShowHistoryTaskDetails`
    - `ShowUrlTaskInfo`
- _解决问题_
  - 无
- _特性变更_
  - **CreateRefreshTasks**
    - 请求参数变更
      - `+ refresh_task.zh_url_encode`
  - **CreatePreheatingTasks**
    - 请求参数变更
      - `+ preheating_task.zh_url_encode`

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持以下接口：
    - `ShowBackgroundTaskProgress`
    - `ListCenterTask`
    - `StartInstanceResizeCheckJob`
    - `ShowBackUpInfo`
    - `CreateOrUpdateBackUpInfo`
    - `ShowExpireKeyScanInfo`
    - `ScanExpireKey`
    - `ListMigrationTaskLogs`
    - `CheckMigrationConnectivity`
    - `ExchangeInstanceIp`
    - `ExecuteCommandMobilization`
    - `LoginWebCli`
    - `UpdateMigrationTask`
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
  - **ListProducts**
    - 请求参数变更
      - `+ product_name`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ResizeInstance**
    - 请求参数变更
      - `+ tenant_ips`
      - `+ second_tenant_subnet_id`
  - **ResizeEngineInstance**
    - 请求参数变更
      - `+ tenant_ips`
      - `+ second_tenant_subnet_id`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 支持接口`RunCreateAudioStreamModerationJob`、`RunCloseAudioStreamModerationJob`、`RunCreateVideoStreamModerationJob`、`RunCloseVideoStreamModerationJob`
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
  - **RecognizeGeneralTable**
    - 请求参数变更
      - `+ with_borders`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ListInstanceDiagnosis`、`ListInstancesInfoDiagnosis`
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
  - **ShowGroup**
    - 响应参数变更
      - `+ group_desc`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - 请求参数变更
      - `+ group_desc`
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `+ groups.group_desc`
  - **BatchUpdateConsumerGroup**
    - 请求参数变更
      - `+ groups.group_desc`

# 3.1.61 2023-10-19

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAgent**
    - 请求参数变更
      - `* agent_id: string -> list<string>`
  - **ListVault**
    - 请求参数变更
      - `* id: string -> list<string>`

### HuaweiCloud SDK CFW

- _新增特性_
  - 支持以下接口：
    - `ListDomainSets`
    - `AddDomainSet`
    - `UpdateDomainSet`
    - `DeleteDomainSet`
    - `ListFirewallList`
    - `BatchUpdateAclRuleActions`
    - `ListRuleAclTags`
    - `AddDomains`
    - `DeleteDomains`
    - `ListDomains`
    - `BatchDeleteAclRules`
    - `BatchDeleteServiceItems`
    - `BatchDeleteAddressItems`
- _解决问题_
  - 无
- _特性变更_
  - **ListFlowLogs**
    - 请求参数变更
      - `+ dst_host`
    - 响应参数变更
      - `+ data.records.dst_host`
  - **ListAccessControlLogs**
    - 请求参数变更
      - `+ dst_host`
      - `+ rule_name`
      - `+ action`
    - 响应参数变更
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
      - `+ data.records.dst_host`
  - **ListBlackWhiteLists**
    - 响应参数变更
      - `+ data.records.description`
  - **ListDomainParseDetail**
    - 请求参数变更
      - `+ address_type`
  - **UpdateDnsServers**
    - 请求参数变更
      - `+ health_check_domain_name`
  - **ListDnsServers**
    - 响应参数变更
      - `+ data.health_check_domain_name`
  - **ListAttackLogs**
    - 请求参数变更
      - `+ dst_host`
      - `+ log_type`
    - 响应参数变更
      - `+ data.records.dst_host`
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
  - **UpdateAclRule**
    - 请求参数变更
      - `+ tag`
      - `+ source.region_list_json`
      - `+ source.region_list`
      - `+ source.domain_set_id`
      - `+ source.domain_set_name`
      - `+ source.ip_address`
      - `+ source.address_group`
      - `+ source.address_group_names`
      - `+ service.custom_service`
      - `+ service.service_group`
      - `+ service.service_group_names`
  - **ListAclRules**
    - 请求参数变更
      - `+ tags_id`
      - `+ source`
      - `+ destination`
      - `+ service`
    - 响应参数变更
      - `+ data.records.tag`
      - `+ data.records.source.region_list_json`
      - `+ data.records.source.region_list`
      - `+ data.records.source.domain_set_id`
      - `+ data.records.source.domain_set_name`
      - `+ data.records.source.ip_address`
      - `+ data.records.source.address_group`
      - `+ data.records.source.address_group_names`
      - `+ data.records.service.custom_service`
      - `+ data.records.service.service_group`
      - `+ data.records.service.service_group_names`
  - **AddBlackWhiteList**
    - 请求参数变更
      - `+ description`
  - **UpdateBlackWhiteList**
    - 请求参数变更
      - `+ description`
  - **ListEipCount**
    - 响应参数变更
      - `+ data.eip_protected_self`
  - **ChangeEipStatus**
    - 响应参数变更
      - `+ data.object_id`
      - `+ data.fail_eip_id_list`
      - `- data.id`
      - `* data: object<IdObject> -> object<EIPSwitchStatusVO>`
  - **ListEastWestFirewall**
    - 响应参数变更
      - `+ data.mode`
      - `+ data.ew_vpc_route_limit`
      - `+ data.er_associated_subnet.ipv6_enable`
      - `+ data.protect_infos.protected_resource_mode`
  - **AddAclRule**
    - 请求参数变更
      - `+ rules.tag`
      - `+ rules.source.region_list_json`
      - `+ rules.source.region_list`
      - `+ rules.source.domain_set_id`
      - `+ rules.source.domain_set_name`
      - `+ rules.source.ip_address`
      - `+ rules.source.address_group`
      - `+ rules.source.address_group_names`
      - `+ rules.service.custom_service`
      - `+ rules.service.service_group`
      - `+ rules.service.service_group_names`
  - **ListEips**
    - 请求参数变更
      - `+ tags`
    - 响应参数变更
      - `+ data.records.object_id`
      - `+ data.records.tags`
      - `+ data.records.domain_id`
      - `+ data.records.owner`
      - `+ data.records.fw_domain_id`
  - **AddAddressItem**
    - 响应参数变更
      - `+ data.covered_ip`
  - **ListFirewallDetail**
    - 响应参数变更
      - `+ data.records.resource_id`
      - `+ data.records.support_url_filtering`
      - `+ data.records.flavor.session_concurrent`
      - `+ data.records.flavor.session_create`
      - `+ data.records.flavor.total_rule_count`
      - `+ data.records.flavor.used_rule_count`
      - `+ data.records.flavor.vpc_bandwith`

### HuaweiCloud SDK CodeArtsBuild

- _新增特性_
  - 支持以下接口：
    - `DownloadLogByRecordId`
    - `ShowRecordInfo`
    - `StopBuildJob`
    - `DeleteBuildJob`
    - `DisableBuildJob`
    - `ResumeBuildJob`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持以下接口：
    - `CreateConnectivityTest`
    - `ShowReplicationStates`
    - `ListAclAccounts`
    - `CreateAclAccount`
    - `UpdateAclAccountPassWord`
    - `ResetAclAccountPassWord`
    - `UpdateAclAccountRole`
    - `UpdateAclAccountRemark`
    - `DeleteAclAccount`
    - `ShowConfigTemplate`
    - `UpdateConfigTemplate`
    - `DeleteConfigTemplate`
- _解决问题_
  - 无
- _特性变更_
  - **ListConfigTemplates**
    - 响应参数变更
      - `+ templates`
      - `- config_templates`
  - **CreateRedislog**
    - 请求参数变更
      - `+ query_time: enum value [0,1,3,7]`
  - **ListInstances**
    - 响应参数变更
      - `+ instances.features.support_audit_log`
  - **ShowInstance**
    - 响应参数变更
      - `+ features.support_audit_log`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ReinstallServerWithCloudInit**
    - 请求参数变更
      - `+ os-reinstall.metadata.BYOL`
  - **ChangeServerOsWithCloudInit**
    - 请求参数变更
      - `+ os-change.metadata.BYOL`
  - **ChangeServerOsWithoutCloudInit**
    - 请求参数变更
      - `+ os-change.metadata.BYOL`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持以下接口：
    - `UpdateProxyNewConfigurations`
    - `CopyConfigurations`
    - `ListConfigurationsDifferences`
    - `ListConfigurationsInstances`
    - `ListModifyHistory`
    - `ListEnterpriseProjects`
    - `SwitchAccessControl`
    - `CreateAccessControl`
    - `DeleteScheduleTasK`
    - `ListInstanceConfigurations`
    - `ShowGaussMySqlIncrementalBackupList`
    - `UpdateBackupOffsitePolicy`
    - `CreateRestoreTables`
- _解决问题_
  - 无
- _特性变更_
  - **ListGaussMySqlDatabase**
    - 请求参数变更
      - `+ name`
      - `+ charset`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListStructuredLogsWithTimeRange**
    - 响应参数变更
      - `+ result`
      - `- context`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListEngineProducts**
    - 响应参数变更
      - `+ products.properties.product_alias`

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`RunAudioAssessment`、`RunMultiModalAssessment`

### HuaweiCloud SDK VPC

- _新增特性_
  - 支持接口`BatchCreateSecurityGroupRules`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.60 2023-10-12

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持以下接口：
    - `ListStackSets`
    - `CreateStackSet`
    - `ShowStackSetTemplate`
    - `ListStackSetOperations`
    - `ShowStackSetMetadata`
    - `ListStackInstances`
    - `CreateStackInstance`
    - `DeleteStackInstance`
    - `DeployStackSet`
    - `DeleteStackSet`
    - `UpdateStackSet`
    - `ShowStackSetOperationMetadata`
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
  - **CreateScalingConfig**
    - 请求参数变更
      - `+ source_scaling_configuration_id`

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateBareMetalServers**
    - 请求参数变更
      - `* server.server_tags: map<string, list<SystemTags>> -> list<SystemTags>`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowHistoryTasks**
    - 请求参数变更
      - `+ task_type`
  - **ShowUrlTaskInfo**
    - 响应参数变更
      - `+ result.mode`

### HuaweiCloud SDK CES

- _新增特性_
  - 支持以下接口：
    - `BatchUpdateNotificationMasks`
    - `BatchUpdateNotificationMaskTime`
    - `UpdateNotificationMasks`
    - `BatchDeleteNotificationMasks`
    - `ListNotificationMasks`
    - `ListNotificationMaskResources`
    - `ListOneClickAlarms`
    - `CreateOneClickAlarm`
    - `ListOneClickAlarmRules`
    - `BatchUpdateOneClickAlarmsEnabledState`
    - `BatchDeleteOneClickAlarms`
    - `UpdateOneClickAlarmNotifications`
    - `BatchUpdateOneClickAlarmPoliciesEnabledState`
    - `UpdateAlarmNotifications`
    - `ListCesTargetProjectTags`
- _解决问题_
  - 无
- _特性变更_
  - **ListAlarmHistories**
    - 响应参数变更
      - `+ alarm_histories.condition.suppress_duration: enum value [86400]`
  - **ListAgentInvocations**
    - 请求参数变更
      - `- instance_name`
      - `+ invocation_type: enum value [RETRY]`
    - 响应参数变更
      - `+ invocations.invocation_type: enum value [RETRY]`
  - **ListAgentStatus**
    - 响应参数变更
      - `+ agent_status.extensions.version`

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 支持接口`ShowExecutionParams`
- _解决问题_
  - 无
- _特性变更_
  - **ListAllApp**
    - 请求参数变更
      - `+ states`
      - `+ group_id`

### HuaweiCloud SDK CTS

- _新增特性_
  - 支持以下接口：
    - `ListOperations`
    - `BatchCreateResourceTags`
    - `BatchDeleteResourceTags`
    - `ListUserResources`
    - `CheckObsBuckets`
    - `ListTraceResources`
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
  - **ReinstallServerWithoutCloudInit**
    - 请求参数变更
      - `+ os-reinstall.metadata.BYOL`
  - **ListFlavors**
    - 响应参数变更
      - `+ flavors.os_extra_specs.quota:vif_max_num`
      - `+ flavors.os_extra_specs.quota:sub_network_interface_max_num`
  - **ListResizeFlavors**
    - 响应参数变更
      - `+ flavors.extra_specs.quota:vif_max_num`
      - `+ flavors.extra_specs.quota:sub_network_interface_max_num`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`ShowFunctionUrl`、`UpdateFunctionUrl`、`CreateFunctionUrl`、`DeleteFunctionUrl`
  - **ListAsyncInvocations**
    - 响应参数变更
      - `+ next_marker`
      - `+ count`
  - **ListActiveAsyncInvocations**
    - 响应参数变更
      - `+ next_marker`
      - `+ count`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 响应参数变更
      - `+ instances.datastore.complete_version`
      - `+ instances.datastore.hotfix_versions`
  - **ListInstancesDetails**
    - 响应参数变更
      - `+ instances.datastore.complete_version`
      - `+ instances.datastore.hotfix_versions`

### HuaweiCloud SDK ImageSearch

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunAddData**
    - 请求参数变更
      - `* optional_params.category: int -> int32`
    - 响应参数变更
      - `* data.image_info.objects.category: number -> integer`
  - **RunDeleteData**
    - 响应参数变更
      - `* data.delete_info.total_num: int -> int32`
      - `* data.delete_info.delete_num: int -> int32`
  - **RunSearch**
    - 请求参数变更
      - `* optional_params.category: int -> int32`
    - 响应参数变更
      - `* data.image_info.category: number -> integer`
      - `* data.image_info.objects.category: number -> integer`
      - `* data.search_info.total_num: int -> int32`
      - `* data.search_info.return_num: int -> int32`
      - `* data.search_info.search_time: long -> int32`
  - **RunCheckData**
    - 响应参数变更
      - `* data.check_info.total_num: int -> int32`
      - `* data.check_info.return_num: int -> int32`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowJob**
    - 响应参数变更
      - `+ entities.addition_error_code`
      - `+ entities.addition_error_msg`
      - `+ entities.error_code`
      - `+ entities.error`
      - `+ entities.alarm_code`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeColombiaIdCard`
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeVehicleLicense**
    - 响应参数变更
      - `+ result.energy_type`
      - `+ result.front`
      - `+ result.back`
  - **RecognizeWebImage**
    - 请求参数变更
      - `+ detect_text_direction`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持以下接口：
    - `ListPostgresqlHbaInfo`
    - `ModifyPostgresqlHbaConf`
    - `AddPostgresqlHbaConf`
    - `DeletePostgresqlHbaConf`
    - `ListPostgresqlHbaInfoHistory`
- _解决问题_
  - 无
- _特性变更_
  - **UpgradeDbVersionNew**
    - 请求参数变更
      - `+ is_delayed`
      - `- delay`

### HuaweiCloud SDK VPC

- _新增特性_
  - 支持以下接口：
    - `ListTrafficMirrorSessions`
    - `CreateTrafficMirrorSession`
    - `ShowTrafficMirrorSession`
    - `UpdateTrafficMirrorSession`
    - `DeleteTrafficMirrorSession`
    - `RemoveSourcesFromTrafficMirrorSession`
    - `AddSourcesToTrafficMirrorSession`
    - `ListTrafficMirrorFilters`
    - `CreateTrafficMirrorFilter`
    - `ShowTrafficMirrorFilter`
    - `UpdateTrafficMirrorFilter`
    - `DeleteTrafficMirrorFilter`
    - `ListTrafficMirrorFilterRules`
    - `CreateTrafficMirrorFilterRule`
    - `ShowTrafficMirrorFilterRule`
    - `UpdateTrafficMirrorFilterRule`
    - `DeleteTrafficMirrorFilterRule`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.59 2023-09-19

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateBareMetalServers**
    - 请求参数变更
      - `* server.server_tags: list<SystemTags> -> map<string, list<SystemTags>>`

### HuaweiCloud SDK CTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateTracker**
    - 请求参数变更
      - `+ is_organization_tracker`
      - `+ management_event_selector`
  - **CreateTracker**
    - 请求参数变更
      - `+ is_organization_tracker`
      - `+ management_event_selector`
    - 响应参数变更
      - `+ is_organization_tracker`
      - `+ management_event_selector`
  - **ListTrackers**
    - 响应参数变更
      - `+ trackers.is_organization_tracker`
      - `+ trackers.management_event_selector`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`ListActiveAsyncInvocations`
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
  - **CreateInstance**
    - 请求参数变更
      - `+ availability_zone_detail`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstanceTopics**
    - 响应参数变更
      - `+ topic_max_partitions`

### HuaweiCloud SDK Live

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateTranscodingsTemplate**
    - 请求参数变更
      - `+ quality_info.bitrate_adaptive`
      - `+ quality_info.i_frame_policy`
  - **CreateTranscodingsTemplate**
    - 请求参数变更
      - `+ quality_info.bitrate_adaptive`
      - `+ quality_info.i_frame_policy`
  - **ShowTranscodingsTemplate**
    - 响应参数变更
      - `+ templates.quality_info.bitrate_adaptive`
      - `+ templates.quality_info.i_frame_policy`

### HuaweiCloud SDK LTS

- _新增特性_
  - 支持以下接口：
    - `ShowLogConvergeConfig`
    - `ShowAdminConfig`
    - `UpdateSwitch`
    - `ShowMemberGroupAndStream`
    - `UpdateLogConvergeConfig`
- _解决问题_
  - 无
- _特性变更_
  - **ListCharts**
    - 响应参数变更
      - `+ config.can_sort`
      - `+ config.can_search`
      - `+ config.page_size`
      - `* config: object -> object<ChartConfig>`
  - **ShowNotificationTemplate**
    - 响应参数变更
      - `+ create_time`
      - `+ project_id`
      - `+ templates`
      - `+ modify_time`
      - `+ name`
      - `+ source`
      - `+ type`
      - `+ locale`
      - `+ desc`
      - `- body`
  - **DeleteTransfer**
    - 响应参数变更
      - `+ log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfer_info.log_transfer_detail.tags`
      - `* log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **ListTransfers**
    - 响应参数变更
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.tags`
      - `* log_transfers.log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **UpdateTransfer**
    - 响应参数变更
      - `+ log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfer_info.log_transfer_detail.tags`
      - `* log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **CreateTransfer**
    - 响应参数变更
      - `+ log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfer_info.log_transfer_detail.tags`
      - `* log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **ListNotificationTemplates**
    - 响应参数变更
      - `+ create_time`
      - `+ project_id`
      - `+ templates`
      - `+ modify_time`
      - `+ name`
      - `+ source`
      - `+ type`
      - `+ locale`
      - `+ desc`
      - `- body`
  - **UpdateSqlAlarmRule**
    - 请求参数变更
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
    - 响应参数变更
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
  - **CreateSqlAlarmRule**
    - 请求参数变更
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
  - **ListSqlAlarmRules**
    - 响应参数变更
      - `+ sql_alarm_rules.frequency.type`
      - `+ sql_alarm_rules.frequency.cron_expr`
      - `+ sql_alarm_rules.frequency.hour_of_day`
      - `+ sql_alarm_rules.frequency.day_of_week`
      - `+ sql_alarm_rules.frequency.fixed_rate`
      - `+ sql_alarm_rules.frequency.fixed_rate_unit`
      - `* sql_alarm_rules.frequency: object -> object<Frequency>`
  - **UpdateKeywordsAlarmRule**
    - 请求参数变更
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
  - **CreateKeywordsAlarmRule**
    - 请求参数变更
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
  - **ListKeywordsAlarmRules**
    - 响应参数变更
      - `+ keywords_alarm_rules.frequency.type`
      - `+ keywords_alarm_rules.frequency.cron_expr`
      - `+ keywords_alarm_rules.frequency.hour_of_day`
      - `+ keywords_alarm_rules.frequency.day_of_week`
      - `+ keywords_alarm_rules.frequency.fixed_rate`
      - `+ keywords_alarm_rules.frequency.fixed_rate_unit`
      - `* keywords_alarm_rules.frequency: object -> object<Frequency>`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeVehicleCertificate`、`RecognizeAcceptanceBill`、`RecognizeRealEstateCertificate`、`RecognizeVietnamIdCard`
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
      - `* body: object<ConsumerGroup> -> object<UpdateConsumerGroup>`
  - **CreateRocketMqMigrationTask**
    - 响应参数变更
      - `+ task_id`

# 3.1.58 2023-09-14

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateBareMetalServers**
    - 请求参数变更
      - `+ server.nics.allowed_address_pairs`

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateVault**
    - 请求参数变更
      - `- vault.billing.promotion_info`
      - `- vault.billing.purchase_mode`
      - `- vault.billing.order_id`
  - **CreatePostPaidVault**
    - 请求参数变更
      - `- vault.billing.promotion_info`
      - `- vault.billing.purchase_mode`
      - `- vault.billing.order_id`

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateEvents**
    - 请求参数变更
      - `- detail.dimensions`
  - **ListEventDetail**
    - 响应参数变更
      - `* event_info.detail.dimensions: object<MetricsDimension> -> list<MetricsDimension>`
      - `* event_info.detail: object<EventItemDetail> -> object<ShowEventItemDetail>`

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAppDetailById**
    - 响应参数变更
      - `* result.arrange_infos: object -> list<TaskV2Info>`
  - **ListNewHosts**
    - 响应参数变更
      - `+ result.permission.can_copy`
      - `- result.permission.can_connection_test`
      - `* result.permission: object<PermissionHostDetail> -> object<PermissionHostDetailNew>`
  - **ShowHostDetail**
    - 响应参数变更
      - `* result.proxy_host: string -> object<HostInfoDetail>`
      - `+ result.permission.can_copy`
      - `- result.permission.can_connection_test`
      - `* result.permission: object<PermissionHostDetail> -> object<PermissionHostDetailNew>`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListFlavors**
    - 响应参数变更
      - `+ flavors.replica_count`

### HuaweiCloud SDK EVS

- _新增特性_
  - 支持接口`ModifyVolumeQoS`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`ShowFunctionUrl`、`UpdateFunctionUrl`、`CreateFunctionUrl`、`DeleteFunctionUrl`
- _解决问题_
  - 无
- _特性变更_
  - **UpdateFuncSnapshot**
    - 请求参数变更
      - `+ action: enum value [enable,disable]`
  - **CreateFunction**
    - 请求参数变更
      - `+ custom_image`
      - `+ code_type: enum value [Custom-Image-Swr]`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`ListAuditLogDownloadLink`
- _解决问题_
  - 无
- _特性变更_
  - **CreateGaussMySqlInstance**
    - 响应参数变更
      - `+ instance.volume`

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `RunImageDescription`
    - `RunImageSuperResolution`
    - `CreateVideoTaggingMediaTask`
    - `ShowVideoTaggingMediaTask`
    - `CreateImageHighresolutionMattingTask`
    - `ShowImageHighresolutionMattingTask`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`UpdateInstanceConsumerGroup`、`UpdateInstanceUser`
- _解决问题_
  - 无
- _特性变更_
  - **CreateKafkaConsumerGroup**
    - 请求参数变更
      - `+ group_desc`
  - **CreateInstanceUser**
    - 请求参数变更
      - `+ user_desc`
  - **ShowInstanceUsers**
    - 响应参数变更
      - `+ users.user_desc`
  - **ShowInstanceMessages**
    - 请求参数变更
      - `+ keyword`

### HuaweiCloud SDK KPS

- _新增特性_
  - 支持接口`ImportPrivateKey`、`ExportPrivateKey`、`BatchAssociateKeypair`、`ClearPrivateKey`
- _解决问题_
  - 无
- _特性变更_
  - **ListKeypairDetail**
    - 响应参数变更
      - `+ keypair.key_id`
      - `+ keypair.algorithm`
  - **ListFailedTask**
    - 请求参数变更
      - `* limit: string -> int32`
      - `* offset: string -> int32`
  - **AssociateKeypair**
    - 请求参数变更
      - `+ server.port`
    - 响应参数变更
      - `+ error_msg`
      - `+ error_code`
      - `+ server_id`
      - `+ status`
  - **DisassociateKeypair**
    - 响应参数变更
      - `+ error_msg`
      - `+ error_code`
      - `+ server_id`
      - `+ status`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListCharts**
    - 响应参数变更
      - `- config.can_sort`
      - `- config.can_search`
      - `- config.page_size`
  - **ShowNotificationTemplate**
    - 响应参数变更
      - `+ body`
      - `- create_time`
      - `- project_id`
      - `- templates`
      - `- modify_time`
      - `- name`
      - `- source`
      - `- type`
      - `- locale`
      - `- desc`
  - **ListLogStream**
    - 请求参数变更
      - `- tag`
    - 响应参数变更
      - `* log_streams: list<LogStream> -> list<LogStreamResBody>`
  - **ListStructuredLogsWithTimeRange**
    - 响应参数变更
      - `+ context`
      - `- body`
  - **DeleteTransfer**
    - 响应参数变更
      - `- log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfer_info.log_transfer_detail.tags`
  - **ListTransfers**
    - 响应参数变更
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.tags`
  - **UpdateTransfer**
    - 响应参数变更
      - `- log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfer_info.log_transfer_detail.tags`
  - **CreateTransfer**
    - 响应参数变更
      - `- log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfer_info.log_transfer_detail.tags`
  - **ListNotificationTemplates**
    - 响应参数变更
      - `+ body`
      - `- create_time`
      - `- project_id`
      - `- templates`
      - `- modify_time`
      - `- name`
      - `- source`
      - `- type`
      - `- locale`
      - `- desc`
  - **UpdateSqlAlarmRule**
    - 请求参数变更
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
    - 响应参数变更
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
  - **CreateSqlAlarmRule**
    - 请求参数变更
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
  - **ListSqlAlarmRules**
    - 响应参数变更
      - `- sql_alarm_rules.frequency.type`
      - `- sql_alarm_rules.frequency.cron_expr`
      - `- sql_alarm_rules.frequency.hour_of_day`
      - `- sql_alarm_rules.frequency.day_of_week`
      - `- sql_alarm_rules.frequency.fixed_rate`
      - `- sql_alarm_rules.frequency.fixed_rate_unit`
  - **UpdateKeywordsAlarmRule**
    - 请求参数变更
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
  - **CreateKeywordsAlarmRule**
    - 请求参数变更
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
  - **ListKeywordsAlarmRules**
    - 响应参数变更
      - `- keywords_alarm_rules.frequency.type`
      - `- keywords_alarm_rules.frequency.cron_expr`
      - `- keywords_alarm_rules.frequency.hour_of_day`
      - `- keywords_alarm_rules.frequency.day_of_week`
      - `- keywords_alarm_rules.frequency.fixed_rate`
      - `- keywords_alarm_rules.frequency.fixed_rate_unit`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunCreateVideoModerationJob**
    - 请求参数变更
      - `+ biz_type`
  - **RunCreateAudioModerationJob**
    - 请求参数变更
      - `+ biz_type`
  - **RunTextModeration**
    - 请求参数变更
      - `+ biz_type`
  - **CheckImageModeration**
    - 请求参数变更
      - `+ biz_type`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`RestoreTablesNew`、`UpgradeDbVersionNew`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.57 2023-09-07

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`DeleteStackEnhanced`
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
  - **ListScalingActivityLogs**
    - 响应参数变更
      - `* scaling_activity_log.scaling_value: string -> int32`
  - **CreateScalingPolicy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **UpdateScalingPolicy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ShowScalingPolicy**
    - 响应参数变更
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListScalingPolicies**
    - 响应参数变更
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **CreateScalingV2Policy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListAllScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **UpdateScalingV2Policy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ShowScalingV2Policy**
    - 响应参数变更
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListScalingActivityV2Logs**
    - 响应参数变更
      - `* scaling_activity_log.scaling_value: string -> int32`
  - **CreateScalingGroup**
    - 请求参数变更
      - `+ lbaas_listeners.protocol_version`
  - **ListScalingGroups**
    - 响应参数变更
      - `+ scaling_groups.lbaas_listeners.protocol_version`
  - **UpdateScalingGroup**
    - 请求参数变更
      - `+ lbaas_listeners.protocol_version`
  - **ShowScalingGroup**
    - 响应参数变更
      - `+ scaling_group.lbaas_listeners.protocol_version`

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateEvents**
    - 请求参数变更
      - `+ detail.dimensions`
  - **ListEventDetail**
    - 响应参数变更
      - `- dimensions`
      - `+ event_info.detail.dimensions`

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持以下接口：
    - `StopJobAction`
    - `ShowDataProgress`
    - `UpdateDataProgress`
    - `ShowDataProcessingRulesResult`
    - `CheckDataFilter`
    - `ShowDataFilteringResult`
    - `CollectColumns`
    - `ShowColumnInfoResult`
    - `BatchStopJobsAction`
    - `ExportOperationInfo`
    - `BatchTagAction`
    - `ListProjectTags`
    - `ShowInstanceTags`
    - `UpdateStartPosition`
    - `ShowMonitorData`
    - `ShowSupportObjectType`
    - `ShowIncrementComponentsDetail`
    - `CollectDbObjectsInfo`
    - `ShowDbObjectsList`
- _解决问题_
  - 无
- _特性变更_
  - **ShowDbObjectTemplateResult**
    - 请求参数变更
      - `+ type: enum value [change]`
  - **ShowUpdateObjectSavingStatus**
    - 请求参数变更
      - `+ X-Language: enum value [en-us,zh-cn]`
  - **ShowObjectMapping**
    - 请求参数变更
      - `+ X-Language: enum value [en-us,zh-cn]`
  - **ListJobs**
    - 请求参数变更
      - `+ instance_ids`
      - `+ instance_ip`
  - **ShowDbObjectCollectionStatus**
    - 请求参数变更
      - `+ X-Language: enum value [en-us,zh-cn]`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.type: enum value [re_create,expired_days]`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.type: enum value [re_create,expired_days]`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ListInstancesResourceMetrics`、`ListInstancesRecommendation`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.56 2023-08-31

### HuaweiCloud SDK CCE

- _新增特性_
  - 支持接口`RollbackAddonInstance`、`ResizeCluster`、`BatchCreateClusterTags`、`BatchDeleteClusterTags`
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddonInstance**
    - 响应参数变更
      - `+ status.isRollbackable`
      - `+ status.previousVersion`
      - `+ status.status: enum value [rollbackFailed]`
  - **UpdateAddonInstance**
    - 响应参数变更
      - `+ status.isRollbackable`
      - `+ status.previousVersion`
      - `+ status.status: enum value [rollbackFailed]`
  - **CreateAddonInstance**
    - 响应参数变更
      - `+ status.isRollbackable`
      - `+ status.previousVersion`
      - `+ status.status: enum value [rollbackFailed]`
  - **ListAddonInstances**
    - 响应参数变更
      - `+ items.status.isRollbackable`
      - `+ items.status.previousVersion`
      - `+ items.status.status: enum value [rollbackFailed]`

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowResourceGroup**
    - 响应参数变更
      - `+ resources.event_type`
  - **ListResourceGroup**
    - 响应参数变更
      - `+ resource_groups.type`
      - `+ resource_groups.relation_ids`
      - `+ resource_groups.resources`
  - **ListEventDetail**
    - 响应参数变更
      - `+ dimensions`

### HuaweiCloud SDK CES

- _新增特性_
  - 支持以下接口：
    - `ListDashboardInfos`
    - `CreateOneDashboard`
    - `UpdateDashboard`
    - `DeleteDashboards`
    - `ListDashboardWidgets`
    - `CreateDashboardWidgets`
    - `ShowWidget`
    - `DeleteOneWidget`
    - `BatchUpdateWidgets`
- _解决问题_
  - 无
- _特性变更_
  - **ListAlarmRulePolicies**
    - 响应参数变更
      - `+ policies.extra_info`
      - `+ policies.type`
      - `* policies: list<Policy> -> list<ListPolicy>`
  - **UpdateAlarmRulePolicies**
    - 请求参数变更
      - `+ policies.type`
      - `* policies: list<Policy> -> list<UpdatePolicy>`
    - 响应参数变更
      - `+ policies.type`
      - `* policies: list<Policy> -> list<UpdatePolicy>`
  - **ListAlarmTemplates**
    - 响应参数变更
      - `- alarm_templates.association_alarm_total`
      - `- alarm_templates.policy_total`
      - `- alarm_templates.policy_statistics`
      - `- alarm_templates.association_resource_groups`
  - **ShowAlarmTemplate**
    - 响应参数变更
      - `- association_alarm_total`

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 支持以下接口：
    - `ListHostClusters`
    - `CreateHostCluster`
    - `ShowHostClusterDetail`
    - `ListNewHosts`
    - `CreateHost`
    - `ShowHostDetail`
    - `ListEnvironments`
    - `CreateEnvironment`
    - `ShowEnvironmentDetail`
    - `DeleteEnvironment`
    - `ImportHostToEnvironment`
    - `DeleteHostFromEnvironment`
    - `ListAllApp`
    - `CreateApp`
    - `ShowAppDetailById`
    - `DeleteApplication`
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
  - **ShowInstance**
    - 响应参数变更
      - `+ available_zones`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowJob**
    - 响应参数变更
      - `+ entities.server_id`
      - `+ entities.nic_id`
  - **CreateServers**
    - 请求参数变更
      - `+ server.extendparam.CB_CSBS_BACKUP`

### HuaweiCloud SDK FRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DetectFaceByFile**
    - 响应参数变更
      - `+ faces.attributes.gender`
  - **DetectFaceByFileIntl**
    - 响应参数变更
      - `+ faces.attributes.gender`
  - **DetectFaceByUrl**
    - 响应参数变更
      - `+ faces.attributes.gender`
  - **DetectFaceByUrlIntl**
    - 响应参数变更
      - `+ faces.attributes.gender`
  - **DetectFaceByBase64**
    - 响应参数变更
      - `+ faces.attributes.gender`
  - **DetectFaceByBase64Intl**
    - 响应参数变更
      - `+ faces.attributes.gender`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `- engine_version: enum value [1.1.0,2.7]`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- engine_version: enum value [1.1.0,2.7]`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeSmartDocumentRecognizer`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 响应参数变更
      - `+ instances.public_dns_names`

# 3.1.55 2023-08-24

HuaweiCloud SDK APIG

- 新增特性
  - 支持以下接口：
    - ListEndpointConnections
    - AcceptOrRejectEndpointConnections
    - ListEndpointPermissions
    - AddEndpointPermissions
    - DeleteEndpointPermissions
- 解决问题
  - 无
- 特性变更
  - AssociateSignatureKeyV2
    - 响应参数变更
      - + bindings.req_method
  - ListSignatureKeysBindedToApiV2
    - 响应参数变更
      - + bindings.req_method
  - ListApisNotBoundWithSignatureKeyV2
    - 响应参数变更
      - + apis.req_method
  - ListApisBindedToSignatureKeyV2
    - 响应参数变更
      - + bindings.req_method
  - ListApisBindedToRequestThrottlingPolicyV2
    - 响应参数变更
      - + apis.req_method
  - ListApisUnbindedToRequestThrottlingPolicyV2
    - 响应参数变更
      - + apis.req_method
  - ListApiRuntimeDefinitionV2
    - 响应参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - ListApisBindedToAclPolicyV2
    - 响应参数变更
      - + apis.req_method
  - ListApisUnbindedToAclPolicyV2
    - 响应参数变更
      - + apis.req_method
  - ShowDetailsOfCustomAuthorizersV2
    - 响应参数变更
      - + network_type
  - UpdateCustomAuthorizerV2
    - 请求参数变更
      - + network_type
    - 响应参数变更
      - + network_type
  - ListInstancesV2
    - 响应参数变更
      - + instances.cbc_operation_locks
      - + instances.status: enum value [Resizing,ResizeFailed,ResizeTimeout]
      - + instances.instance_status: enum value [42,43,44]
      - + instances.spec: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - CreateInstanceV2
    - 请求参数变更
      - + spec_id: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - ShowDetailsOfInstanceV2
    - 响应参数变更
      - + cbc_operation_locks
      - + status: enum value [Resizing,ResizeFailed,ResizeTimeout]
      - + instance_status: enum value [42,43,44]
      - + spec: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - UpdateInstanceV2
    - 响应参数变更
      - + cbc_operation_locks
      - + status: enum value [Resizing,ResizeFailed,ResizeTimeout]
      - + instance_status: enum value [42,43,44]
      - + spec: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - ShowDetailsOfApiV2
    - 响应参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - UpdateApiV2
    - 请求参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
    - 响应参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - ListApiVersionDetailV2
    - 响应参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - CreateCustomAuthorizerV2
    - 请求参数变更
      - + network_type
    - 响应参数变更
      - + network_type
  - ListCustomAuthorizersV2
    - 响应参数变更
      - + network_type
      - + authorizer_list.network_type
  - CreateApiV2
    - 请求参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
    - 响应参数变更
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - ListApisV2
    - 响应参数变更
      - + apis.content_type: enum value [multipart/form-data]
      - - apis.content_type: enum value [multipart/form-date]

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListJarPackageHostInfo**
    - 响应参数变更
      - `* data_list.record_time: int32 -> int64`

### HuaweiCloud SDK IMS

- _新增特性_
  - 支持以下接口：
    - `ListAimMsgTemplate`
    - `CreateAimMsgTemplate`
    - `ShowAimMsgTemplateVariable`
    - `SendAimBatchMessages`
    - `SendAimBatchDifferentMessages`
    - `DeleteAimMsgSignature`
    - `ShowAimMsgTemplateDetail`
    - `UpdateAimMsgTemplate`
    - `DeleteAimMsgTemplate`
    - `ListAimMsgSignature`
    - `AddAimMsgSignature`
    - `ListAimMsgApp`
    - `CreateSmsApp`
    - `ListAimMsgAppDetail`
    - `UpdateAimMsgApp`
    - `ShowAimMsgSignatureFileInfo`
    - `UploadAimMsgSignatureFile`
    - `ListAimMsgSignatureDetail`
    - `UpdateAimMsgSignature`
- _解决问题_
  - 无
- _特性变更_
  - **ListAimResolveDetails**
    - 请求参数变更
      - `+ task_name`
    - 响应参数变更
      - `+ resolve_details.task_name`
  - **ListResolveTasks**
    - 请求参数变更
      - `+ task_name`
    - 响应参数变更
      - `+ resolve_tasks.task_name`

### HuaweiCloud SDK LTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateLogStream**
    - 请求参数变更
      - `* tags: object<tagsBody> -> list<tagsBody>`

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListNatGateways**
    - 响应参数变更
      - `+ nat_gateways.session_conf`
  - **CreateNatGateway**
    - 请求参数变更
      - `+ nat_gateway.session_conf`
    - 响应参数变更
      - `+ nat_gateway.session_conf`
  - **ShowNatGateway**
    - 响应参数变更
      - `+ nat_gateway.session_conf`
  - **UpdateNatGateway**
    - 请求参数变更
      - `+ nat_gateway.session_conf`
    - 响应参数变更
      - `+ nat_gateway.session_conf`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`ShowLoginType`
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
  - **RunTts**
    - 请求参数变更
      - `+ config.property: enum value [chinese_huaxiaoman_common,chinese_huaxiaofang_common,chinese_huaxiaojun_common]`

### HuaweiCloud SDK VPC

# 3.1.54 2023-08-21

### HuaweiCloud SDK LTS

- _新增特性_
  - 支持接口`DeleteDashboard`
- _解决问题_
  - 无
- _特性变更_
  - **CreateDashBoard**
    - 响应参数变更
      - `* last_update_time: string -> int64`
      - `* useSystemTemplate: string -> boolean`
  - **CreateLogStream**
    - 请求参数变更
      - `- enterprise_project_name`
      - `- log_stream_name: enum value [lts-stream-13ci]`
      - `* ttl_in_days: string -> int32`
      - `* tags: list<tagsBody> -> object<tagsBody>`
  - **ListAccessConfig**
    - 响应参数变更
      - `+ cluster_id`
      - `+ result.cluster_id`
  - **UpdateAccessConfig**
    - 请求参数变更
      - `+ cluster_id`
    - 响应参数变更
      - `+ cluster_id`
  - **CreateAccessConfig**
    - 请求参数变更
      - `+ cluster_id`
    - 响应参数变更
      - `+ cluster_id`
  - **DeleteAccessConfig**
    - 响应参数变更
      - `+ cluster_id`
      - `+ result.cluster_id`

# 3.1.53 2023-08-17

### HuaweiCloud SDK AOS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateStack**
    - 请求参数变更
      - `+ agencies.agency_urn`
  - **GetStackMetadata**
    - 响应参数变更
      - `+ agencies.agency_urn`
  - **CreateStack**
    - 请求参数变更
      - `+ agencies.agency_urn`

### HuaweiCloud SDK CloudRTC

- _新增特性_
  - 支持接口`ListRtcAbnormalEvent`、`ListRtcEvent`、`ListObsBuckets`、`ListObsBucketObjects`、`UpdateObsBucketAuthority`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ShowNodesInformation`
- _解决问题_
  - 无
- _特性变更_
  - **ShowInstance**
    - 响应参数变更
      - `+ cloud_service_type_code`
      - `+ inquery_spec_code`
      - `+ cloud_resource_type_code`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateServers**
    - 请求参数变更
      - `+ server.root_volume.iops`
      - `+ server.root_volume.throughput`
      - `+ server.root_volume.volumetype: enum value [GPSSD2,ESSD2]`
      - `+ server.data_volumes.iops`
      - `+ server.data_volumes.throughput`
      - `+ server.data_volumes.volumetype: enum value [GPSSD2,ESSD2]`
  - **CreatePostPaidServers**
    - 请求参数变更
      - `+ server.data_volumes.iops`
      - `+ server.data_volumes.throughput`
      - `+ server.data_volumes.volumetype: enum value [GPSSD2,ESSD2]`
      - `+ server.root_volume.iops`
      - `+ server.root_volume.throughput`
      - `+ server.root_volume.volumetype: enum value [GPSSD2,ESSD2]`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`ModifyGaussMysqlDns`、`CreateGaussMysqlDns`
- _解决问题_
  - 无
- _特性变更_
  - **ShowGaussMySqlInstanceInfo**
    - 响应参数变更
      - `+ instance.private_dns_names`
  - **ListGaussMySqlInstanceDetailInfo**
    - 响应参数变更
      - `+ instances.private_dns_names`

### HuaweiCloud SDK ImageSearch

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `RunCreateInstance`
    - `RunModifyPicture`
    - `RunAddPicture`
    - `RunDeletePicture`
    - `RunSearchPicture`
    - `RunCheckPicture`
    - `RunQueryInstance`
    - `RunDeleteInstance`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchRestartOrDeleteInstances**
    - 请求参数变更
      - `+ allFailure`
      - `- all_failure`
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `- engine_version: enum value [2.3.0]`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- engine_version: enum value [2.3.0]`

### HuaweiCloud SDK Live

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSnapshotConfigs**
    - 响应参数变更
      - `* body: object<LiveSnapshotConfig> -> list<LiveSnapshotConfig>`

### HuaweiCloud SDK MPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateThumbnailsTask**
    - 请求参数变更
      - `+ thumbnail_para.dots_ms`
      - `+ thumbnail_para.type: enum value [DOTS_MS]`
  - **CreateTranscodingTask**
    - 请求参数变更
      - `+ thumbnail.params.dots_ms`
      - `+ thumbnail.params.type: enum value [DOTS_MS]`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchRestartOrDeleteInstances**
    - 请求参数变更
      - `+ allFailure`
      - `- all_failure`
  - **CreatePostPaidInstanceByEngine**
    - 请求参数变更
      - `- engine_version: enum value [3.7.17]`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- engine_version: enum value [3.7.17]`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BatchDeleteInstances**
    - 请求参数变更
      - `+ allFailure`
      - `- all_failure`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `- engine_version: enum value [5.x]`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateSecurityGroupRule**
    - 请求参数变更
      - `+ security_group_rule.remote_address_group_id`
  - **NeutronCreateSecurityGroupRule**
    - 请求参数变更
      - `+ security_group_rule.remote_address_group_id`

# 3.1.52 2023-08-10

### HuaweiCloud SDK CodeArtsBuild

- _新增特性_
  - 支持编译构建服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPrivateZones**
    - 请求参数变更
      - `* type: optional -> required`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`UpdateProxyPort`、`DescribeBackupEncryptStatus`、`ModifyBackupEncryptStatus`
- _解决问题_
  - 无
- _特性变更_
  - **UpdateProxySessionConsistence**
    - 请求参数变更
      - `+ consistence_mode`
  - **CreateGaussMySqlInstance**
    - 请求参数变更
      - `* datastore: object<MysqlDatastore> -> object<MysqlDatastoreInReq>`
    - 响应参数变更
      - `* instance.datastore: object<MysqlDatastore> -> object<MysqlDatastoreInRes>`
  - **ShowGaussMySqlBackupList**
    - 响应参数变更
      - `- backups.datastore.kernel_version`
      - `* backups.datastore: object<MysqlDatastore> -> object<MysqlDatastoreInBackup>`
  - **ShowGaussMySqlProxyList**
    - 响应参数变更
      - `+ proxy_list.proxy.consistence_mode`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstanceConsumerGroups**
    - 响应参数变更
      - `+ groups.createdAt`
      - `+ groups.group_desc`
      - `+ groups.lag`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeMyanmarIdcard**
    - 请求参数变更
      - `+ return_translation`
    - 响应参数变更
      - `+ result.translation_info`

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持接口`ListXellogFiles`、`CreateXelLogDownload`
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
  - **ShowOneTopic**
    - 响应参数变更
      - `+ message_type`
  - **ShowTopicStatus**
    - 响应参数变更
      - `+ max_offset`
      - `+ min_offset`
  - **ShowInstance**
    - 响应参数变更
      - `+ grpc_address`
      - `+ public_grpc_address`
  - **CreateTopicOrBatchDeleteTopic**
    - 请求参数变更
      - `+ message_type`
  - **ListRocketInstanceTopics**
    - 响应参数变更
      - `+ message_type`
      - `+ topics.message_type`
  - **ListMessages**
    - 响应参数变更
      - `* messages.reconsume_times: string -> int32`
      - `* messages.queue_id: string -> int32`
      - `* messages.queue_offset: string -> int32`
  - **ExportDlqMessage**
    - 响应参数变更
      - `* reconsume_times: string -> int32`
      - `* queue_id: string -> int32`
      - `* queue_offset: string -> int32`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ engine_version: enum value [5.x]`
  - **ListInstances**
    - 响应参数变更
      - `+ grpc_address`
      - `+ public_grpc_address`
      - `+ instances.grpc_address`
      - `+ instances.public_grpc_address`
  - **ShowConsumerListOrDetails**
    - 响应参数变更
      - `+ lag`
      - `+ max_offset`
      - `+ consumer_offset`

# 3.1.51 2023-08-03

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `- spec.extendParam.enterprise_project_id`
  - **UpdateNode**
    - 响应参数变更
      - `- spec.extendParam.enterprise_project_id`
  - **DeleteNode**
    - 响应参数变更
      - `- spec.extendParam.enterprise_project_id`
  - **CreateNode**
    - 请求参数变更
      - `- spec.extendParam.enterprise_project_id`
    - 响应参数变更
      - `- spec.extendParam.enterprise_project_id`
  - **ListNodes**
    - 响应参数变更
      - `- items.spec.extendParam.enterprise_project_id`
  - **ShowNodePool**
    - 响应参数变更
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **UpdateNodePool**
    - 响应参数变更
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **DeleteNodePool**
    - 响应参数变更
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **CreateNodePool**
    - 请求参数变更
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
    - 响应参数变更
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **ListNodePools**
    - 响应参数变更
      - `- items.spec.nodeTemplate.extendParam.enterprise_project_id`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainDetailByName**
    - 响应参数变更
      - `- domain.sources.weight`
      - `* domain.sources: list<SourcesConfig> -> list<SourcesDomainConfig>`
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.remark`
      - `+ configs.ip_frequency_limit`
      - `+ configs.hsts`
      - `+ configs.quic`
      - `+ configs.url_auth.inherit_config`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.request_limit_rules.priority`
      - `+ configs.request_limit_rules.match_type`
      - `+ configs.request_limit_rules.match_value`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.remark`
      - `+ configs.ip_frequency_limit`
      - `+ configs.hsts`
      - `+ configs.quic`
      - `+ configs.url_auth.inherit_config`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.request_limit_rules.priority`
      - `+ configs.request_limit_rules.match_type`
      - `+ configs.request_limit_rules.match_value`

### HuaweiCloud SDK CTS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **DeleteTracker**
    - 请求参数变更
      - `+ tracker_type: enum value [system]`

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持接口`ModifyGaussMySqlProxyRouteMode`
- _解决问题_
  - 无
- _特性变更_
  - **ShowGaussMySqlEngineVersion**
    - 响应参数变更
      - `+ datastores.version`
      - `+ datastores.kernel_version`
  - **CreateGaussMySqlProxy**
    - 请求参数变更
      - `+ route_mode`
  - **CreateGaussMySqlInstance**
    - 请求参数变更
      - `+ datastore.kernel_version`
    - 响应参数变更
      - `+ instance.datastore.kernel_version`
  - **ShowGaussMySqlBackupList**
    - 响应参数变更
      - `+ backups.datastore.kernel_version`
  - **ShowGaussMySqlProxyList**
    - 响应参数变更
      - `+ proxy_list.proxy.route_mode`
      - `+ proxy_list.proxy.balance_route_mode_enabled`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstances**
    - 响应参数变更
      - `+ instances.backup_used_space`
  - **ListComponentInfos**
    - 请求参数变更
      - `+ component_type`
      - `+ availability_zone_id`
    - 响应参数变更
      - `+ nodes.name`
      - `+ nodes.availability_zone_id`
      - `+ nodes.description`
      - `+ nodes.status`
      - `+ nodes.components.distributed_id`
  - **ListInstancesDetails**
    - 响应参数变更
      - `+ instances.backup_used_space`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowIssueV4**
    - 响应参数变更
      - `+ find_release_dev`
      - `+ release_dev`
      - `+ env`

### HuaweiCloud SDK RDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListDatastores**
    - 请求参数变更
      - `+ database_name: enum value [MariaDB]`
  - **ListConfigurations**
    - 响应参数变更
      - `+ configurations.datastore_name: enum value [mariadb]`
  - **CreateConfiguration**
    - 请求参数变更
      - `+ datastore.type: enum value [MariaDB]`
    - 响应参数变更
      - `+ configuration.datastore_name: enum value [mariadb]`
  - **ShowConfiguration**
    - 响应参数变更
      - `+ datastore_name: enum value [mariadb]`
  - **ShowInstanceConfiguration**
    - 响应参数变更
      - `+ datastore_name: enum value [mariadb]`
  - **ListFlavors**
    - 请求参数变更
      - `+ database_name: enum value [MariaDB]`
  - **ListStorageTypes**
    - 请求参数变更
      - `+ database_name: enum value [MariaDB]`
  - **ListInstances**
    - 请求参数变更
      - `+ datastore_type: enum value [MariaDB]`
    - 响应参数变更
      - `+ instances.datastore.type: enum value [MariaDB]`
  - **CreateInstance**
    - 请求参数变更
      - `+ datastore.type: enum value [MariaDB]`
    - 响应参数变更
      - `+ instance.datastore.type: enum value [MariaDB]`
  - **CreateRestoreInstance**
    - 请求参数变更
      - `+ datastore.type: enum value [MariaDB]`
    - 响应参数变更
      - `+ instance.datastore.type: enum value [MariaDB]`
  - **ListBackups**
    - 响应参数变更
      - `+ backups.datastore.type: enum value [MariaDB]`
  - **ListOffSiteBackups**
    - 响应参数变更
      - `+ backups.datastore.type: enum value [MariaDB]`
  - **ListOffSiteInstances**
    - 响应参数变更
      - `+ offsite_backup_instances.datastore.type: enum value [MariaDB]`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListMessageTrace**
    - 请求参数变更
      - `* msg_id: optional -> required`
  - **ListMessages**
    - 请求参数变更
      - `+ key`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPorts**
    - 请求参数变更
      - `+ enable_efi`
    - 响应参数变更
      - `+ ports.enable_efi`
  - **CreatePort**
    - 响应参数变更
      - `+ port.enable_efi`
  - **ShowPort**
    - 响应参数变更
      - `+ port.enable_efi`
  - **UpdatePort**
    - 响应参数变更
      - `+ port.enable_efi`

# 3.1.50 2023-07-31

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpdateIssueV4**
    - 响应参数变更
      - `+ find_release_dev`
      - `+ order`
      - `+ release_dev`
      - `+ env`
  - **ListIssuesV4**
    - 响应参数变更
      - `+ find_release_dev`
      - `+ order`
      - `+ release_dev`
      - `+ env`
      - `+ issues.order`
      - `+ issues.release_dev`
      - `+ issues.find_release_dev`
      - `+ issues.env`
  - **ListChildIssuesV4**
    - 响应参数变更
      - `+ find_release_dev`
      - `+ order`
      - `+ release_dev`
      - `+ env`
      - `+ issues.order`
      - `+ issues.release_dev`
      - `+ issues.find_release_dev`
      - `+ issues.env`

# 3.1.49 2023-07-27

### HuaweiCloud SDK DRS

- _新增特性_
  - 支持以下接口：
    - `DownloadBatchCreateTemplate`
    - `ImportBatchCreateJobs`
    - `CopyJob`
    - `ShowMetering`
    - `ShowDirtyData`
    - `ShowComparePolicy`
    - `ShowHealthCompareJobList`
    - `ShowProgressData`
    - `ShowObjectMapping`
    - `ShowActions`
    - `ValidateJobName`
    - `ShowEnterpriseProject`
- _解决问题_
  - 无
- _特性变更_
  - **DownloadDbObjectTemplate**
    - 请求参数变更
      - `+ file_import_db_level`
  - **UploadDbObjectTemplate**
    - 请求参数变更
      - `+ file_import_db_level`
  - **ListAsyncJobs**
    - 响应参数变更
      - `+ jobs.status: enum value [AUTO_PARAM_VALIDATE_SUCCESS,COMMIT_SUCCESS]`
      - `- jobs.status: enum value [ASYNC_JOB_CREATING,ASYNC_JOB_CREATE_FAILED,ASYNC_JOB_COMPLETED]`
  - **CreateJob**
    - 请求参数变更
      - `+ job.node_info.base_info`
    - 响应参数变更
      - `+ is_clone_job`
      - `+ create_time`
      - `+ name`
      - `+ id`
      - `+ status`
      - `+ job.is_clone_job`
  - **BatchCreateJobsAsync**
    - 请求参数变更
      - `+ jobs.node_info.base_info`
  - **ListAsyncJobDetail**
    - 响应参数变更
      - `+ jobs.support_import_file_resp`
      - `+ jobs.instance_features`
      - `+ jobs.task_version`
      - `+ jobs.node_info.base_info`
  - **UpdateBatchAsyncJobs**
    - 请求参数变更
      - `+ jobs.type: enum value [policy]`
      - `- jobs.type: enum value [policy_config]`
      - `+ jobs.params.node_info.base_info`
  - **ShowJobDetail**
    - 请求参数变更
      - `+ type: enum value [file]`
    - 响应参数变更
      - `+ job.support_import_file_resp`
      - `+ job.instance_features`
      - `+ job.task_version`
      - `+ job.node_info.base_info`
  - **UpdateJob**
    - 请求参数变更
      - `+ job.type: enum value [policy]`
      - `- job.type: enum value [policy_config]`
      - `+ job.params.node_info.base_info`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **AttachShareBandwidth**
    - 响应参数变更
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **DetachShareBandwidth**
    - 响应参数变更
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **EnableNat64**
    - 响应参数变更
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **DisableNat64**
    - 响应参数变更
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **AttachBatchPublicIp**
    - 响应参数变更
      - `+ publicips.publicip.vnic.vtep`
      - `+ publicips.publicip.vnic.vni`
      - `+ publicips.publicip.vnic.port_profile`
  - **DetachBatchPublicIp**
    - 响应参数变更
      - `+ publicips.publicip.vnic.vtep`
      - `+ publicips.publicip.vnic.vni`
      - `+ publicips.publicip.vnic.port_profile`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateTags**
    - 请求参数变更
      - `+ tags.key`
      - `+ tags.value`
      - `* tags: list<Kv> -> list<KvItem>`
  - **DeleteTags**
    - 请求参数变更
      - `+ tags.key`
      - `+ tags.value`
      - `* tags: list<Kv> -> list<KvItem>`
  - **ShowResInstanceInfo**
    - 请求参数变更
      - `+ matches.key`
      - `+ matches.value`
      - `* matches: list<Kv> -> list<KvItem>`
    - 响应参数变更
      - `+ resources.tags.key`
      - `+ resources.tags.value`
      - `* resources.tags: list<Kv> -> list<KvItem>`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ShowInstanceBiactiveRegions`
- _解决问题_
  - 无
- _特性变更_
  - **ListConfigurations**
    - 响应参数变更
      - `+ quota`
      - `+ configurations.mode`
  - **ListConfigurationTemplates**
    - 响应参数变更
      - `+ quota`
      - `+ configurations.mode`
  - **ShowInstanceConfiguration**
    - 响应参数变更
      - `+ mode`
      - `+ id`
  - **ListConfigurationDatastores**
    - 响应参数变更
      - `+ datastores.mode`
  - **ShowQuotas**
    - 请求参数变更
      - `+ datastore_type`
      - `+ mode`
  - **ListInstances**
    - 响应参数变更
      - `+ instances.datastore.whole_version`

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持接口`DownloadBackup`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持以下接口：
    - `ListDeviceTunnels`
    - `AddTunnel`
    - `ShowDeviceTunnel`
    - `CloseDeviceTunnel`
    - `DeleteDeviceTunnel`
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
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ disk_encrypted_enable`
      - `+ disk_encrypted_key`

### HuaweiCloud SDK LTS

- _新增特性_
  - 支持接口`UpdateLogStream`
- _解决问题_
  - 无
- _特性变更_
  - **UpdateLogGroup**
    - 请求参数变更
      - `+ tags`
  - **CreateLogGroup**
    - 请求参数变更
      - `+ tags`
  - **CreateLogStream**
    - 请求参数变更
      - `+ enterprise_project_name`
      - `+ ttl_in_days`
      - `+ tags`
      - `+ log_stream_name: enum value [lts-stream-13ci]`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowInstanceExtendProductInfo**
    - 响应参数变更
      - `+ monthly`
      - `+ hourly`
      - `- engine`
      - `- versions`
      - `- products`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ValidateConsumedMessage**
    - 请求参数变更
      - `+ engine: enum value [reliability]`
  - **ListInstances**
    - 请求参数变更
      - `+ engine: enum value [reliability]`

# 3.1.48 2023-07-20

### HuaweiCloud SDK LTS

- _新增特性_
  - 支持云日志服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDBforopenGauss

- _新增特性_
  - 支持云数据库 GaussDB服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK GaussDB

- _新增特性_
  - 支持云数据库 GaussDB服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RDS

- _新增特性_
  - 支持云数据库服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CloudRTC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateIndividualStreamJob**
    - 请求参数变更
      - `- publish_param`
  - **UpdateIndividualStreamJob**
    - 请求参数变更
      - `- publish_param`
  - **CreateMixJob**
    - 请求参数变更
      - `- publish_param`

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持以下接口：
    - `AttachShareBandwidth`
    - `AttachBatchPublicIp`
    - `DetachShareBandwidth`
    - `DetachBatchPublicIp`
    - `EnableNat64`
    - `DisableNat64`
    - `ListBandwidth`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`DeleteBatchTask`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`ListTopicPartitions`、`ListTopicProducers`
- _解决问题_
  - 无
- _特性变更_
  - **ListProducts**
    - 请求参数变更
      - `+ engine: enum value [kafka]`
  - **UpdateInstanceTopic**
    - 请求参数变更
      - `+ topics.topic_other_configs`
      - `+ topics.topic_desc`
  - **CreateInstanceTopic**
    - 请求参数变更
      - `+ topic_other_configs`
      - `+ topic_desc`
    - 响应参数变更
      - `+ id`
  - **ListInstanceTopics**
    - 请求参数变更
      - `- offset`
      - `- limit`
    - 响应参数变更
      - `+ topics.topic_other_configs`
      - `+ topics.topic_desc`
      - `+ topics.created_at`
  - **ListInstances**
    - 请求参数变更
      - `+ engine: enum value [kafka]`
  - **ResizeEngineInstance**
    - 请求参数变更
      - `+ engine: enum value [kafka]`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowInstanceExtendProductInfo**
    - 请求参数变更
      - `+ engine: enum value [rabbitmq]`
    - 响应参数变更
      - `+ engine`
      - `+ versions`
      - `+ products`
      - `- monthly`
      - `- hourly`
  - **ListProducts**
    - 请求参数变更
      - `+ engine: enum value [rabbitmq]`
  - **ResizeEngineInstance**
    - 请求参数变更
      - `+ engine: enum value [rabbitmq]`
  - **ShowEngineInstanceExtendProductInfo**
    - 请求参数变更
      - `+ engine: enum value [rabbitmq]`

# 3.1.47 2023-07-13

### HuaweiCloud SDK CodeArtsDeploy

- _新增特性_
  - 支持部署服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK AS

- _新增特性_
  - 支持接口`ListGroupScheduledTasks`、`CreateGroupScheduledTask`、`UpdateGroupScheduledTask`、`DeleteGroupScheduledTask`
- _解决问题_
  - 无
- _特性变更_
  - **CreateScalingPolicy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **UpdateScalingPolicy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ShowScalingPolicy**
    - 响应参数变更
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ListScalingPolicies**
    - 响应参数变更
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **CreateScalingV2Policy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ListAllScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **UpdateScalingV2Policy**
    - 请求参数变更
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ShowScalingV2Policy**
    - 响应参数变更
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ListScalingV2Policies**
    - 响应参数变更
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **PushTranscriberJobs**
    - 请求参数变更
      - `+ Enterprise-Project-Id`

### HuaweiCloud SDK VPC

- _新增特性_
  - 支持以下接口：
    - `ListApiVersion`
    - `NeutronListPorts`
    - `NeutronCreatePort`
    - `NeutronShowPort`
    - `NeutronUpdatePort`
    - `NeutronDeletePort`
    - `NeutronListNetworks`
    - `NeutronCreateNetwork`
    - `NeutronShowNetwork`
    - `NeutronUpdateNetwork`
    - `NeutronDeleteNetwork`
    - `NeutronListSubnets`
    - `NeutronCreateSubnet`
    - `NeutronShowSubnet`
    - `NeutronUpdateSubnet`
    - `NeutronDeleteSubnet`
    - `NeutronListRouters`
    - `NeutronCreateRouter`
    - `NeutronShowRouter`
    - `NeutronUpdateRouter`
    - `NeutronDeleteRouter`
    - `NeutronAddRouterInterface`
    - `NeutronRemoveRouterInterface`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.46 2023-07-06

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **UpgradeCluster**
    - 响应参数变更
      - `+ metadata`
      - `+ spec`
      - `- uid`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainDetailByName**
    - 响应参数变更
      - `+ domain.sources.weight`
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.business_type`
      - `+ configs.service_area`
      - `+ configs.sources.weight`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.business_type`
      - `+ configs.service_area`
      - `+ configs.sources.weight`

### HuaweiCloud SDK EVS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateVolume**
    - 请求参数变更
      - `+ volume.iops`
      - `+ volume.throughput`
      - `+ volume.volume_type: enum value [GPSSD2,ESSD2]`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RunCreateVideoModerationJob**
    - 请求参数变更
      - `+ data.language`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListSecurityGroupRules**
    - 请求参数变更
      - `+ remote_ip_prefix`

# 3.1.45 2023-06-29

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`ListTemplateVersions`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ExecuteClusterSwitchover`、`ShowJobInfo`
- _解决问题_
  - 无
- _特性变更_
  - **ListConfigTemplates**
    - 响应参数变更
      - `+ config_templates.created_at`
  - **CreateInstance**
    - 请求参数变更
      - `+ template_id`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateCommand**
    - 响应参数变更
      - `+ error_msg`
      - `+ error_code`
  - **ListProperties**
    - 响应参数变更
      - `+ error_msg`
      - `+ error_code`
  - **UpdateProperties**
    - 响应参数变更
      - `+ error_msg`
      - `+ error_code`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddressGroup**
    - 响应参数变更
      - `+ address_group.tags`
  - **UpdateAddressGroup**
    - 响应参数变更
      - `+ address_group.tags`
  - **ListAddressGroup**
    - 响应参数变更
      - `+ address_groups.tags`
  - **CreateAddressGroup**
    - 响应参数变更
      - `+ address_group.tags`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **AddOrRemoveServicePermissions**
    - 请求参数变更
      - `+ permission_type`
    - 响应参数变更
      - `+ permission_type`
  - **UpdateEndpointService**
    - 响应参数变更
      - `- cidr_type`
  - **ListServicePermissionsDetails**
    - 响应参数变更
      - `+ permissions.permission_type`
  - **BatchAddEndpointServicePermissions**
    - 请求参数变更
      - `+ permission_type`
    - 响应参数变更
      - `+ permissions.permission_type`
  - **BatchRemoveEndpointServicePermissions**
    - 响应参数变更
      - `+ permissions.permission_type`
  - **UpdateEndpointServicePermissionDesc**
    - 响应参数变更
      - `+ permissions.permission_type`
  - **CreateEndpointService**
    - 响应参数变更
      - `- cidr_type`

# 3.1.44 2023-06-21

### HuaweiCloud SDK CloudRTC

- _新增特性_
  - 支持华为云实时音视频服务
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Classroom

- _新增特性_
  - 支持以下接口：
    - `ListPackages`
    - `ShowPackageDetail`
    - `ListExercises`
    - `ShowExerciseDetail`
    - `ExecuteExercise`
    - `ListAllDifficults`
    - `ListMyKnowledgePoints`
- _解决问题_
  - 无
- _特性变更_
  - **ApplyJudgement**
    - 请求参数变更
      - `+ runtime_type: enum value [javaScript]`

### HuaweiCloud SDK DNS

- _新增特性_
  - 支持接口`ShowDomainQuota`
- _解决问题_
  - 无
- _特性变更_
  - **ShowRecordSetWithLine**
    - 响应参数变更
      - `+ bundle`
  - **SetRecordSetsStatus**
    - 响应参数变更
      - `+ bundle`
  - **BatchUpdateRecordSetWithLine**
    - 响应参数变更
      - `+ bundle`
      - `+ recordsets.bundle`
  - **BatchDeleteRecordSetWithLine**
    - 响应参数变更
      - `+ bundle`
      - `+ recordsets.bundle`
  - **CreateRecordSetWithBatchLines**
    - 响应参数变更
      - `+ bundle`
      - `+ recordsets.bundle`

# 3.1.43 2023-06-15

### HuaweiCloud SDK CBR

- _新增特性_
    - 支持云备份服务
- _解决问题_
    - 无
- _特性变更_
    - 无

### HuaweiCloud SDK Live

- _新增特性_
    - 支持视频直播服务
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
  - **CreateBatchTask**
    - 响应参数变更
      - `- task_progress.device_in_progress`
      - `- task_progress.rejected`
  - **ListBatchTasks**
    - 响应参数变更
      - `- batchtasks.task_progress.device_in_progress`
      - `- batchtasks.task_progress.rejected`
  - **ShowBatchTask**
    - 响应参数变更
      - `- batchtask.task_progress.device_in_progress`
      - `- batchtask.task_progress.rejected`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeGeneralText**
    - 请求参数变更
      - `+ single_orientation_mode`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **SendDlqMessage**
    - 请求参数变更
      - `+ engine: enum value [reliability]`
  - **CreateRocketMqMigrationTask**
    - 请求参数变更
      - `+ type: enum value [kafka]`

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowVocabularies**
    - 请求参数变更
      - `+ offset`
      - `+ limit`

# 3.1.42 2023-06-08

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
    - 响应参数变更
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.extendParam.kube-reserved-mem`
      - `+ items.spec.extendParam.system-reserved-mem`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **UpdateNodePool**
    - 响应参数变更
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
    - 响应参数变更
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.type: enum value [pm]`
      - `+ items.spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ items.spec.nodeTemplate.extendParam.system-reserved-mem`

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListRecordSetsByZone**
    - 请求参数变更
      - `+ search_mode`
  - **CreateRecordSet**
    - 请求参数变更
      - `* body: object<CreateRecordSetReq> -> object<CreateRecordSetRequestBody>`
  - **CreateRecordSetWithLine**
    - 请求参数变更
      - `* body: object<CreateRecordSetWithLineReq> -> object<CreateRecordSetWithLineRequestBody>`
  - **ListPublicZones**
    - 请求参数变更
      - `+ search_mode`
  - **ListPrivateZones**
    - 请求参数变更
      - `+ search_mode`
  - **ListRecordSets**
    - 请求参数变更
      - `+ search_mode`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`ChangeServerChargeMode`
- _解决问题_
  - 无
- _特性变更_
  - **CreateServers**
    - 请求参数变更
      - `+ server.nics.allowed_address_pairs`
  - **CreatePostPaidServers**
    - 请求参数变更
      - `+ server.nics.allowed_address_pairs`

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListListeners**
    - 响应参数变更
      - `+ listeners.port_ranges`
  - **CreateListener**
    - 请求参数变更
      - `+ listener.port_ranges`
    - 响应参数变更
      - `+ listener.port_ranges`
  - **ShowListener**
    - 响应参数变更
      - `+ listener.port_ranges`
  - **UpdateListener**
    - 响应参数变更
      - `+ listener.port_ranges`
  - **ListPools**
    - 响应参数变更
      - `+ pools.any_port_enable`
  - **CreatePool**
    - 请求参数变更
      - `+ pool.any_port_enable`
    - 响应参数变更
      - `+ pool.any_port_enable`
  - **ShowPool**
    - 响应参数变更
      - `+ pool.any_port_enable`
  - **UpdatePool**
    - 响应参数变更
      - `+ pool.any_port_enable`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持以下接口：
    - `UpdateFuncSnapshot`
    - `ShowFuncSnapshotState`
    - `ShowResInstanceInfo`
    - `ShowProjectTagsList`
    - `CreateTags`
    - `DeleteTags`
    - `CreateVpcEndpoint`
    - `DeleteVpcEndpoint`
- _解决问题_
  - 无
- _特性变更_
  - **ListStatistics**
    - 响应参数变更
      - `* count.value: int32 -> number`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`RetryBatchTask`、`StopBatchTask`
- _解决问题_
  - 无
- _特性变更_
  - **CreateBatchTask**
    - 响应参数变更
      - `+ task_progress.removed`
      - `+ task_progress.device_in_progress`
      - `+ task_progress.rejected`
  - **ListBatchTasks**
    - 响应参数变更
      - `+ batchtasks.task_progress.removed`
      - `+ batchtasks.task_progress.device_in_progress`
      - `+ batchtasks.task_progress.rejected`
  - **ShowBatchTask**
    - 请求参数变更
      - `+ task_detail_status`
      - `+ target`
    - 响应参数变更
      - `+ batchtask.task_progress.removed`
      - `+ batchtask.task_progress.device_in_progress`
      - `+ batchtask.task_progress.rejected`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`AddIssueWorkHours`、`ListProjectWorkHoursType`
- _解决问题_
  - 无
- _特性变更_
  - **ShowProjectWorkHours**
    - 响应参数变更
      - `+ work_hours.work_hours_created_time`
      - `+ work_hours.work_hours_updated_time`
  - **ListProjectWorkHours**
    - 响应参数变更
      - `+ work_hours.work_hours_created_time`
      - `+ work_hours.work_hours_updated_time`
  - **ListIssueCustomFields**
    - 请求参数变更
      - `+ included_not_in_use`
    - 响应参数变更
      - `+ datas.create_time`
  - **ListIssuesV4**
    - 请求参数变更
      - `+ created_time_interval`
      - `+ closed_time_interval`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持接口`SendDlqMessage`、`ValidateConsumedMessage`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`SendRocketMqDlqMessage`、`ValidateRocketMqConsumedMessage`
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ product_id: enum value [c6.4u8g.cluster.small]`

### HuaweiCloud SDK TMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListResource**
    - 响应参数变更
      - `+ resources.tags`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddressGroup**
    - 响应参数变更
      - `+ address_group.enterprise_project_id`
  - **UpdateAddressGroup**
    - 响应参数变更
      - `+ address_group.enterprise_project_id`
  - **ListAddressGroup**
    - 请求参数变更
      - `+ enterprise_project_id`
    - 响应参数变更
      - `+ address_groups.enterprise_project_id`
  - **CreateAddressGroup**
    - 请求参数变更
      - `+ address_group.enterprise_project_id`
    - 响应参数变更
      - `+ address_group.enterprise_project_id`

# 3.1.41 2023-06-01

### HuaweiCloud SDK CBR

- _新增特性_
  - 支持接口`ShowSummary`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowAddonInstance**
    - 响应参数变更
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
  - **UpdateAddonInstance**
    - 请求参数变更
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
    - 响应参数变更
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
  - **CreateAddonInstance**
    - 请求参数变更
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
    - 响应参数变更
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
  - **ListAddonInstances**
    - 响应参数变更
      - `+ items.metadata.alias`
      - `* items.metadata: object<Metadata> -> object<AddonMetadata>`
  - **ListAddonTemplates**
    - 响应参数变更
      - `+ items.metadata.alias`
      - `* items.metadata: object<Metadata> -> object<AddonMetadata>`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowLogs**
    - 请求参数变更
      - `+ start_time`
      - `+ end_time`
      - `- query_date`
  - **ShowDomainFullConfig**
    - 请求参数变更
      - `+ show_special_configs`
    - 响应参数变更
      - `- configs.error_code_cache.code: enum value [400,403,404,405,414,500,501,502,503,504]`
      - `+ configs.flexible_origin.back_sources.http_port`
      - `+ configs.flexible_origin.back_sources.https_port`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `- configs.error_code_cache.code: enum value [400,403,404,405,414,500,501,502,503,504]`
      - `+ configs.flexible_origin.back_sources.http_port`
      - `+ configs.flexible_origin.back_sources.https_port`

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RestorePtrRecord**
    - 请求参数变更
      - `* ptrdname: string -> object`
  - **ShowRecordSet**
    - 响应参数变更
      - `+ bundle`
  - **CreateEipRecordSet**
    - 响应参数变更
      - `+ enterprise_project_id`
  - **ShowPtrRecordSet**
    - 响应参数变更
      - `+ enterprise_project_id`
  - **ShowResourceTag**
    - 响应参数变更
      - `+ enterpriseProjectOrDefault`
  - **ListPrivateZones**
    - 请求参数变更
      - `* type: required -> optional`

### HuaweiCloud SDK ELB

- _新增特性_
  - 支持接口`DeleteLoadBalancerForce`、`DeleteListenerForce`、`BatchUpdateMembers`
- _解决问题_
  - 无
- _特性变更_
  - **ShowQuota**
    - 响应参数变更
      - `+ quota.condition_per_policy`
      - `+ quota.listeners_per_pool`
      - `+ quota.listeners_per_loadbalancer`
      - `* quota.ipgroup_bindings: string -> int32`
      - `* quota.ipgroup_max_length: string -> int32`
  - **ShowLoadBalancer**
    - 响应参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **UpdateLoadBalancer**
    - 请求参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - 响应参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ListListeners**
    - 请求参数变更
      - `+ protection_status`
    - 响应参数变更
      - `+ listeners.protection_status`
      - `+ listeners.protection_reason`
      - `+ listeners.gzip_enable`
  - **CreateListener**
    - 请求参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
    - 响应参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
  - **ShowListener**
    - 响应参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
  - **UpdateListener**
    - 请求参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
    - 响应参数变更
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
  - **ListPools**
    - 请求参数变更
      - `+ protection_status`
    - 响应参数变更
      - `+ pools.protection_status`
      - `+ pools.protection_reason`
  - **CreatePool**
    - 请求参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - 响应参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
  - **ShowPool**
    - 响应参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
  - **UpdatePool**
    - 请求参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - 响应参数变更
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
  - **UpdateMember**
    - 请求参数变更
      - `+ member.protocol_port`
  - **ListLoadBalancers**
    - 请求参数变更
      - `+ protection_status`
      - `+ global_eips`
    - 响应参数变更
      - `+ loadbalancers.protection_status`
      - `+ loadbalancers.protection_reason`
  - **CreateLoadBalancer**
    - 请求参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - 响应参数变更
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ListL7Policies**
    - 响应参数变更
      - `+ l7policies.redirect_pools_extend_config`
      - `- l7policies.redirect_pools_config`
  - **CreateL7Policy**
    - 请求参数变更
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
    - 响应参数变更
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
  - **ShowL7Policy**
    - 响应参数变更
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
  - **UpdateL7Policy**
    - 请求参数变更
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
    - 响应参数变更
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListInstanceTopics**
    - 请求参数变更
      - `+ offset`
      - `+ limit`
  - **ListInstances**
    - 请求参数变更
      - `+ offset`
      - `+ limit`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowIssueV4**
    - 响应参数变更
      - `+ story_point`
  - **SearchIssues**
    - 响应参数变更
      - `+ issue_list.due_date`
  - **ListIssueCommentsV4**
    - 响应参数变更
      - `+ comments.timestamp`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreatePostPaidInstanceByEngine**
    - 请求参数变更
      - `+ bss_param`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ bss_param`
  - **ListInstancesDetails**
    - 请求参数变更
      - `+ offset`
      - `+ limit`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持以下接口：
    - `SendRocketMqDlqMessage`
    - `ValidateRocketMqConsumedMessage`
    - `ListRocketMqMigrationTask`
    - `CreateRocketMqMigrationTask`
    - `DeleteRocketMqMigrationTask`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK SMN

- _新增特性_
  - 支持以下接口：
    - `UpdateSubscription`
    - `ListLogtank`
    - `CreateLogtank`
    - `UpdateLogtank`
    - `DeleteLogtank`
- _解决问题_
  - 无
- _特性变更_
  - **ListTopicDetails**
    - 响应参数变更
      - `+ topic_id`
  - **ListTopics**
    - 请求参数变更
      - `+ topic_id`
    - 响应参数变更
      - `+ topics.topic_id`
  - **ListTopicAttributes**
    - 响应参数变更
      - `+ attributes.access_policy`
      - `+ attributes.introduction`
      - `- attributes.Version`
      - `- attributes.Id`
      - `- attributes.Statement`
  - **AddSubscription**
    - 请求参数变更
      - `+ extension`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateAssetByFileUpload**
    - 请求参数变更
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
  - **PublishAssetFromObs**
    - 请求参数变更
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
  - **CreateAssetReviewTask**
    - 请求参数变更
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
    - 响应参数变更
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
  - **UploadMetaDataByUrl**
    - 请求参数变更
      - `+ upload_metadatas.review.interval`
      - `+ upload_metadatas.review.politics`
      - `+ upload_metadatas.review.terrorism`
      - `+ upload_metadatas.review.porn`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateVpcPeering**
    - 请求参数变更
      - `+ peering.description`

# 3.1.40 2023-05-25

### HuaweiCloud SDK CBR

- _新增特性_
  - 支持以下接口：
    - `ImportCheckpoint`
    - `ListExternalVault`
    - `BatchUpdateVault`
    - `SetVaultResource`
    - `ShowMetadata`
    - `CheckAgent`
    - `ListProjects`
    - `ListDomainProjects`
    - `ShowDomain`
    - `ShowMigrateStatus`
    - `MigrateDomain`
    - `ShowStorageUsage`
    - `UpdateOrder`
    - `CreatePostPaidVault`
    - `UpdateBackup`
- _解决问题_
  - 无
- _特性变更_
  - **CreateVault**
    - 请求参数变更
      - `+ vault.threshold`
      - `+ vault.smn_notify`
      - `+ vault.backup_name_prefix`
      - `+ vault.demand_billing`
    - 响应参数变更
      - `+ vault.backup_name_prefix`
      - `+ vault.demand_billing`
      - `+ vault.cbc_delete_count`
      - `+ vault.frozen`

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowCluster**
    - 响应参数变更
      - `+ metadata.alias`
  - **UpdateCluster**
    - 请求参数变更
      - `+ metadata`
    - 响应参数变更
      - `+ metadata.alias`
  - **DeleteCluster**
    - 响应参数变更
      - `+ metadata.alias`
  - **MigrateNode**
    - 请求参数变更
      - `+ spec.runtime`
    - 响应参数变更
      - `+ spec.runtime`
  - **CreateCluster**
    - 请求参数变更
      - `+ metadata.alias`
    - 响应参数变更
      - `+ metadata.alias`
  - **ListClusters**
    - 响应参数变更
      - `+ items.metadata.alias`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainDetailByName**
    - 响应参数变更
      - `+ domain.domain_name`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListMigrationTask**
    - 响应参数变更
      - `- task_name`
      - `- target_instance_id`
      - `- target_instance_address`
      - `- target_instance_name`
      - `- migrate_type`
      - `- created_at`
      - `- source_instance_id`
      - `- task_id`
      - `- data_source`
      - `- migration_method`
      - `- source_instance_name`
      - `- status`
  - **ListConfigTemplates**
    - 响应参数变更
      - `* template_num: number -> integer`
  - **ListInstances**
    - 响应参数变更
      - `+ instances.updated_at`
  - **ListBackgroundTask**
    - 响应参数变更
      - `- updated_at`
      - `- created_at`
      - `- status`
  - **ListFlavors**
    - 响应参数变更
      - `+ flavors.flavors_available_zones.unit`
      - `+ flavors.flavors_available_zones.available_zones`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`ListFlavorSellPolicies`
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
  - **ListPublicipsByTags**
    - 响应参数变更
      - `+ resources.resource_detail`
      - `- resources.resouce_detail`
  - **AddPublicipsIntoSharedBandwidth**
    - 响应参数变更
      - `+ bandwidth.enable_bandwidth_rules`
      - `+ bandwidth.rule_quota`
      - `+ bandwidth.bandwidth_rules`

### HuaweiCloud SDK IAM

- _新增特性_
  - 支持接口`AssociateRoleToAgencyOnEnterpriseProject`、`RevokeRoleFromAgencyOnEnterpriseProject`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`CreateVideoObjectMaskingTask`、`ShowVideoObjectMaskingTask`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`DeleteConnector`、`CreateDeleteConnectorOrder`、`CreateKafkaConsumerGroup`、`CloseKafkaManager`
- _解决问题_
  - 无
- _特性变更_
  - **ShowInstance**
    - 响应参数变更
      - `+ kafka_manager_enable`
  - **ListInstances**
    - 响应参数变更
      - `+ kafka_manager_enable`
      - `+ instances.kafka_manager_enable`

### HuaweiCloud SDK MSGSMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowSignatureFile**
    - 响应参数变更
      - `+ file_desc`
  - **UpdateApp**
    - 响应参数变更
      - `- app_secret`

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreatePostPaidInstanceByEngine**
    - 请求参数变更
      - `+ engine_version: enum value [3.8.35]`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ engine_version: enum value [3.8.35]`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateVpc**
    - 请求参数变更
      - `+ vpc.tags`
  - **CreateSubnet**
    - 请求参数变更
      - `+ subnet.tags`
    - **ShowAddressGroup**
    - 响应参数变更
      - `+ address_group.max_capacity`
      - `+ address_group.status`
      - `+ address_group.status_message`
  - **UpdateAddressGroup**
    - 请求参数变更
      - `+ address_group.max_capacity`
    - 响应参数变更
      - `+ address_group.max_capacity`
      - `+ address_group.status`
      - `+ address_group.status_message`
  - **ListAddressGroup**
    - 响应参数变更
      - `+ address_groups.max_capacity`
      - `+ address_groups.status`
      - `+ address_groups.status_message`
  - **CreateAddressGroup**
    - 请求参数变更
      - `+ address_group.max_capacity`
    - 响应参数变更
      - `+ address_group.max_capacity`
      - `+ address_group.status`
      - `+ address_group.status_message`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListServiceDescribeDetails**
    - 响应参数变更
      - `+ enable_policy`
  - **ListServiceDetails**
    - 响应参数变更
      - `- vip_port_id`
  - **UpdateEndpointService**
    - 请求参数变更
      - `- vip_port_id`
    - 响应参数变更
      - `- vip_port_id`
  - **ListServicePublicDetails**
    - 响应参数变更
      - `+ endpoint_services.enable_policy`
  - **CreateEndpointService**
    - 请求参数变更
      - `- vip_port_id`
    - 响应参数变更
      - `- vip_port_id`
  - **ListEndpointService**
    - 响应参数变更
      - `- endpoint_services.vip_port_id`

# 3.1.39 2023-05-18

### HuaweiCloud SDK CBR

- _新增特性_
  - 支持以下接口：
    - `AddAgentPath`
    - `ShowAgent`
    - `UpdateAgent`
    - `UnregisterAgent`
    - `ListAgent`
    - `RegisterAgent`
    - `RemoveAgentPath`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ status.lastProbeTime`
  - **UpdateNode**
    - 响应参数变更
      - `+ status.lastProbeTime`
  - **DeleteNode**
    - 响应参数变更
      - `+ status.lastProbeTime`
  - **CreateNode**
    - 响应参数变更
      - `+ status.lastProbeTime`
  - **ListNodes**
    - 响应参数变更
      - `+ items.status.lastProbeTime`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateRefreshTasks**
    - 请求参数变更
      - `* refresh_task.mode: boolean -> string`
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.flexible_origin`
      - `+ configs.slice_etag_status`
      - `+ configs.origin_receive_timeout`
      - `+ configs.remote_auth`
      - `+ configs.websocket`
      - `+ configs.video_seek`
      - `+ configs.request_limit_rules`
      - `+ configs.url_auth.sign_method`
      - `+ configs.url_auth.match_type`
      - `+ configs.url_auth.key`
      - `+ configs.url_auth.backup_key`
      - `+ configs.url_auth.sign_arg`
      - `+ configs.https.expire_time`
      - `+ configs.https.certificate_type`
      - `+ configs.https.ocsp_stapling_status`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.flexible_origin`
      - `+ configs.slice_etag_status`
      - `+ configs.origin_receive_timeout`
      - `+ configs.remote_auth`
      - `+ configs.websocket`
      - `+ configs.video_seek`
      - `+ configs.request_limit_rules`
      - `+ configs.url_auth.sign_method`
      - `+ configs.url_auth.match_type`
      - `+ configs.url_auth.backup_key`
      - `+ configs.url_auth.sign_arg`
      - `+ configs.https.certificate_type`
      - `+ configs.https.ocsp_stapling_status`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`
  - **ShowDomainDetailByName**
    - 响应参数变更
      - `+ domain.sources.obs_bucket_type`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateServers**
    - 请求参数变更
      - `+ server.root_volume.metadata`
      - `- server.root_volume.extendparam.__system__encrypted`
      - `- server.root_volume.extendparam.__system__cmkid`
      - `+ server.data_volumes.delete_on_termination`
  - **CreatePostPaidServers**
    - 请求参数变更
      - `+ server.data_volumes.delete_on_termination`
      - `+ server.root_volume.metadata`
      - `- server.root_volume.extendparam.__system__encrypted`
      - `- server.root_volume.extendparam.__system__cmkid`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **BroadcastMessage**
    - 请求参数变更
      - `+ ttl`
      - `+ message_id`
  - **ShowDeviceGroup**
    - 响应参数变更
      - `+ dynamic_group_rule`
      - `+ group_type`
  - **UpdateDeviceGroup**
    - 响应参数变更
      - `+ dynamic_group_rule`
      - `+ group_type`
  - **SearchDevices**
    - 响应参数变更
      - `+ devices.groups`
  - **AddDeviceGroup**
    - 请求参数变更
      - `+ group_type`
      - `+ dynamic_group_rule`
    - 响应参数变更
      - `+ dynamic_group_rule`
      - `+ group_type`
  - **ListDeviceGroups**
    - 请求参数变更
      - `+ group_type`
      - `+ name`
    - 响应参数变更
      - `+ device_groups.group_type`
      - `* device_groups: list<DeviceGroupResponsSummery> -> list<DeviceGroupResponseSummary>`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`ListTemplates`、`SearchIssues`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.38 2023-05-11

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`ContinueDeployStack`
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
  - **ShowVaultResourceInstances**
    - 响应参数变更
      - `* resources.resource_detail: list<Vault> -> object<InstancesResourceDetail>`
  - **ListPolicies**
    - 响应参数变更
      - `+ policies.operation_definition.full_backup_interval`
  - **CreatePolicy**
    - 请求参数变更
      - `+ policy.operation_definition.full_backup_interval`
    - 响应参数变更
      - `+ policy.operation_definition.full_backup_interval`
  - **ShowPolicy**
    - 响应参数变更
      - `+ policy.operation_definition.full_backup_interval`
  - **UpdatePolicy**
    - 请求参数变更
      - `+ policy.operation_definition.full_backup_interval`
    - 响应参数变更
      - `+ policy.operation_definition.full_backup_interval`
  - **CreateVault**
    - 请求参数变更
      - `- vault.billing.extra_info`

### HuaweiCloud SDK ECS

- _新增特性_
  - 支持接口`NovaAttachInterface`
- _解决问题_
  - 无
- _特性变更_
  - **ReinstallServerWithoutCloudInit**
    - 请求参数变更
      - `+ os-reinstall.metadata`
  - **ChangeServerOsWithoutCloudInit**
    - 请求参数变更
      - `+ os-change.metadata`
  - **ReinstallServerWithCloudInit**
    - 请求参数变更
      - `+ os-reinstall.metadata.__system__encrypted`
      - `+ os-reinstall.metadata.__system__cmkid`
  - **ChangeServerOsWithCloudInit**
    - 请求参数变更
      - `+ os-change.metadata.__system__encrypted`
      - `+ os-change.metadata.__system__cmkid`
  - **CreateServers**
    - 请求参数变更
      - `+ server.root_volume.extendparam.__system__encrypted`
      - `+ server.root_volume.extendparam.__system__cmkid`
  - **CreatePostPaidServers**
    - 请求参数变更
      - `+ server.root_volume.extendparam.__system__encrypted`
      - `+ server.root_volume.extendparam.__system__cmkid`

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`CreateVideoTaggingMediaTask`、`ShowVideoTaggingMediaTask`
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
  - **ListImages**
    - 请求参数变更
      - `+ __imagetype: enum value [market]`

# 3.1.37 2023-04-27

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.ipv6_accelerate`
      - `+ configs.origin_range_status`

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListIpsProtectModeUsingPost**
    - 响应参数变更
      - `+ data`
      - `- object_id`
      - `- status`

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ResetPassword`、`UpdateInstanceBandwidth`、`ListConfigTemplates`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`RunQueryCustomTags`、`RunDeleteCustomTags`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateInstanceByEngine**
    - 请求参数变更
      - `+ kafka_security_protocol`
      - `+ sasl_enabled_mechanisms`
  - **ShowInstance**
    - 响应参数变更
      - `+ kafka_security_protocol`
      - `+ sasl_enabled_mechanisms: enum value [PLAIN,SCRAM-SHA-512]`
  - **CreatePostPaidInstance**
    - 请求参数变更
      - `+ kafka_security_protocol`
      - `+ sasl_enabled_mechanisms: enum value [PLAIN,SCRAM-SHA-512]`
  - **ListInstances**
    - 响应参数变更
      - `+ kafka_security_protocol`
      - `+ instances.kafka_security_protocol`
      - `+ instances.sasl_enabled_mechanisms: enum value [PLAIN,SCRAM-SHA-512]`

### HuaweiCloud SDK KMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListKeys**
    - 响应参数变更
      - `+ key_details.partition_type`
  - **ListKeyDetail**
    - 响应参数变更
      - `+ key_info.partition_type`
  - **ListRetirableGrants**
    - 响应参数变更
      - `+ total`
  - **ListKmsByTags**
    - 响应参数变更
      - `+ resources.resource_detail.partition_type`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowConsumerListOrDetails**
    - 响应参数变更
      - `* total: int64 -> int32`

# 3.1.36 2023-04-20

### HuaweiCloud SDK AOS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **GetStackTemplate**
    - 请求参数变更
      - `- executor`
  - **ListStackEvents**
    - 请求参数变更
      - `- executor`
  - **ListStackOutputs**
    - 请求参数变更
      - `- executor`
  - **DeleteStack**
    - 请求参数变更
      - `- executor`
  - **DeleteExecutionPlan**
    - 请求参数变更
      - `- executor`
  - **ApplyExecutionPlan**
    - 请求参数变更
      - `- executor`
  - **GetExecutionPlan**
    - 请求参数变更
      - `- executor`
  - **ListStackResources**
    - 请求参数变更
      - `- executor`
  - **ListExecutionPlans**
    - 请求参数变更
      - `- executor`
  - **CreateExecutionPlan**
    - 请求参数变更
      - `- executor`
  - **GetExecutionPlanMetadata**
    - 请求参数变更
      - `- executor`
  - **GetStackMetadata**
    - 请求参数变更
      - `- executor`
  - **ListStacks**
    - 请求参数变更
      - `- executor`
  - **CreateStack**
    - 请求参数变更
      - `- executor`
  - **DeployStack**
    - 请求参数变更
      - `- executor`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ShowDomainFullConfig`、`UpdateDomainFullConfig`
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainFullConfig**
    - 响应参数变更
      - `+ configs.origin_follow302_status`
      - `+ configs.cache_rules`
      - `+ configs.ip_filter`
      - `+ configs.referer`
      - `+ configs.force_redirect.redirect_code`
  - **UpdateDomainFullConfig**
    - 请求参数变更
      - `+ configs.origin_follow302_status`
      - `+ configs.cache_rules`
      - `+ configs.ip_filter`
      - `+ configs.referer`
      - `+ configs.force_redirect.redirect_code`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateRedislogDownloadLink**
    - 响应参数变更
      - `+ backup_id`

### HuaweiCloud SDK DDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateConfiguration**
    - 响应参数变更
      - `+ configuration`
      - `- datastore_version`
      - `- created`
      - `- name`
      - `- description`
      - `- id`
      - `- datastore_name`
      - `- updated`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ImportFunction**
    - 响应参数变更
      - `+ gpu_memory`
      - `+ func_vpc.security_groups`
  - **ListFunctions**
    - 响应参数变更
      - `+ functions.gpu_memory`
      - `+ functions.is_bridge_function`
      - `+ functions.bind_bridge_funcUrns`
  - **CreateFunction**
    - 请求参数变更
      - `+ gpu_memory`
      - `+ log_config`
      - `+ network_controller`
      - `+ func_vpc.security_groups`
    - 响应参数变更
      - `+ gpu_memory`
      - `+ func_vpc.security_groups`
  - **ShowFunctionConfig**
    - 响应参数变更
      - `+ gpu_memory`
      - `+ ephemeral_storage`
      - `+ func_vpc.security_groups`
  - **UpdateFunctionConfig**
    - 请求参数变更
      - `+ gpu_memory`
      - `+ ephemeral_storage`
      - `+ log_config`
      - `+ network_controller`
      - `+ restore_hook_handler`
      - `+ restore_hook_timeout`
      - `+ func_vpc.security_groups`
    - 响应参数变更
      - `+ gpu_memory`
      - `+ ephemeral_storage`
      - `+ func_vpc.security_groups`
  - **UpdateFunctionMaxInstanceConfig**
    - 响应参数变更
      - `+ func_vpc.security_groups`
  - **CreateFunctionVersion**
    - 响应参数变更
      - `+ func_vpc.security_groups`

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `CreateVideoTranslateTask`
    - `ShowVideoTranslateTask`
    - `CreateImageTranslateTask`
    - `ShowImageTranslateTask`
    - `CreateVideoCoverAnalysisTask`
    - `ShowVideoCoverAnalysisTask`
    - `CreateVideoSummarizationAnalysisTask`
    - `ShowVideoSummarizationAnalysisTask`
    - `CreateVideoShotSplitTask`
    - `ShowVideoShotSplitTask`
  - **CreateImageHighresolutionMattingTask**
    - 请求参数变更
      - `- input.data.bucket`
      - `- input.data.path`
  - **ShowImageHighresolutionMattingTask**
    - 响应参数变更
      - `- input.data.bucket`
      - `- input.data.path`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`BroadcastMessage`
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
  - **RecognizeDriverLicense**
    - 响应参数变更
      - `+ result.front`
      - `+ result.back`
  - **RecognizeThailandIdcard**
    - 响应参数变更
      - `+ result.type`
      - `+ result.name_en`
      - `+ result.ref_number`
      - `+ result.confidence.name_en`
      - `+ result.confidence.ref_number`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持接口`ShowConsumerConnections`
- _解决问题_
  - 无
- _特性变更_
  - **ShowConsumerListOrDetails**
    - 响应参数变更
      - `+ total`
      - `+ brokers`
  - **ShowUser**
    - 响应参数变更
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
  - **UpdateUser**
    - 请求参数变更
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
    - 响应参数变更
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
  - **UpdateInstance**
    - 请求参数变更
      - `+ enable_publicip`
      - `+ publicip_id`
  - **CreateUser**
    - 请求参数变更
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
    - 响应参数变更
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
  - **ListUser**
    - 响应参数变更
      - `- users.default_group_perm: enum value [PUB,PUB|SUB]`
      - `- users.group_perms.perm: enum value [PUB,PUB|SUB]`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListVpcsByTags**
    - 响应参数变更
      - `+ resources.resource_detail`
      - `- resources.resouce_detail`
  - **ListSubnetsByTags**
    - 响应参数变更
      - `+ resources.resource_detail`
      - `- resources.resouce_detail`
  - **UpdateRouteTable**
    - 请求参数变更
      - `+ routetable.routes.add`
      - `+ routetable.routes.mod`
      - `+ routetable.routes.del`
      - `* routetable.routes: map<string, list<RouteTableRoute>> -> object<RouteTableRouteAction>`

### HuaweiCloud SDK VPCEP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListServiceDescribeDetails**
    - 响应参数变更
      - `+ public_border_group`
  - **ListServiceDetails**
    - 响应参数变更
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
  - **UpdateEndpointService**
    - 请求参数变更
      - `+ tcp_proxy`
    - 响应参数变更
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
  - **ListEndpointInfoDetails**
    - 响应参数变更
      - `+ endpoint_pool_id`
      - `+ public_border_group`
  - **CreateEndpointService**
    - 请求参数变更
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
    - 响应参数变更
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
  - **ListEndpointService**
    - 响应参数变更
      - `+ endpoint_services.enable_policy`
      - `+ endpoint_services.tcp_proxy: enum value [proxy_vni]`
  - **CreateEndpoint**
    - 响应参数变更
      - `+ endpoint_pool_id`
      - `+ public_border_group`
      - `+ ip`

# 3.1.35 2023-04-13

### HuaweiCloud SDK EVS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowVolume**
    - 响应参数变更
      - `+ volume.iops`
      - `+ volume.throughput`
  - **ListVolumes**
    - 响应参数变更
      - `+ volumes.iops`
      - `+ volumes.throughput`

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `CreateVideoSynthesisTask`
    - `ShowVideoSynthesisTask`
    - `CreateImageToVideoTask`
    - `ShowImageToVideoTask`
    - `CreateVideoCuttingTask`
    - `ShowVideoCuttingTask`
    - `RunImageWisedesignCrop`
    - `RunImageWisedesignInpainting`
  - **RunImageTagging**
    - 响应参数变更
      - `+ result.tags.instances.bounding_box.width`
      - `+ result.tags.instances.bounding_box.height`
      - `+ result.tags.instances.bounding_box.top_left_x`
      - `+ result.tags.instances.bounding_box.top_left_y`
      - `* result.tags.instances.bounding_box: object -> object<ImageTaggingBoundingBox>`
  - **RunImageMediaTagging**
    - 响应参数变更
      - `+ result.tags.instances.bounding_box.width`
      - `+ result.tags.instances.bounding_box.height`
      - `+ result.tags.instances.bounding_box.top_left_x`
      - `+ result.tags.instances.bounding_box.top_left_y`
      - `* result.tags.instances.bounding_box: object -> object<BoundingBox>`
      - `* result.tags.instances: list<ImageTaggingInstance> -> list<ImageMediaTaggingInstance>`
  - **RunImageMediaTaggingDet**
    - 响应参数变更
      - `+ result.tags.instances.bounding_box.width`
      - `+ result.tags.instances.bounding_box.height`
      - `+ result.tags.instances.bounding_box.top_left_x`
      - `+ result.tags.instances.bounding_box.top_left_y`
      - `* result.tags.instances.bounding_box: object -> object<BoundingBox>`
  - **ShowVideoShotSplitTask**
    - 响应参数变更
      - `- state: enum value [SUCCEEDED,FAILED,RUNNING]`
  - **CreateVideoTranslateTask**
    - 请求参数变更
      - `* body: object<VideoTranslateRequestBody> -> object<CreateVideoTranslateTaskRequestBody>`
  - **CreateImageHighresolutionMattingTask**
    - 请求参数变更
      - `* input.data: list<TaskInputData> -> list<ImageHighresolutionMattingInputData>`
      - `* input: object<TaskInput> -> object<ImageHighresolutionMattingInput>`
  - **ShowImageHighresolutionMattingTask**
    - 响应参数变更
      - `* input.data: list<TaskInputData> -> list<ImageHighresolutionMattingInputData>`
      - `* input: object<TaskInput> -> object<ImageHighresolutionMattingInput>`
  - **CreateImageTranslateTask**
    - 请求参数变更
      - `* input.data: list<TaskInputData> -> list<ImageTranslateTaskInputData>`
      - `* input: object<TaskInput> -> object<ImageTranslateTaskInput>`
      - `* body: object<ImageTranslateRequestBody> -> object<CreateImageTranslateRequestBody>`
  - **ShowImageTranslateTask**
    - 响应参数变更
      - `* input.data: list<TaskInputData> -> list<ImageTranslateTaskInputData>`
      - `* input: object<TaskInput> -> object<ImageTranslateTaskInput>`
  - **CreateVideoCoverAnalysisTask**
    - 请求参数变更
      - `* input.data: list<TaskInputData> -> list<VideoCoverAnalysisTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoCoverAnalysisTaskInput>`
      - `* body: object<VideoCoverAnalysisCreateTaskRequestBody> -> object<CreateVideoCoverAnalysisTaskRequestBody>`
  - **ShowVideoCoverAnalysisTask**
    - 响应参数变更
      - `* input.data: list<TaskInputData> -> list<VideoCoverAnalysisTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoCoverAnalysisTaskInput>`
  - **CreateVideoSummarizationAnalysisTask**
    - 请求参数变更
      - `* input.data: list<TaskInputData> -> list<VideoSummarizationTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoSummarizationTaskInput>`
      - `* body: object<VideoSummarizationCreateTaskRequestBody> -> object<CreateVideoSummarizationTaskRequestBody>`
  - **ShowVideoSummarizationAnalysisTask**
    - 响应参数变更
      - `* input.data: list<TaskInputData> -> list<VideoSummarizationTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoSummarizationTaskInput>`
  - **CreateVideoObjectMaskingTask**
    - 请求参数变更
      - `* input.data: list<TaskInputData> -> list<ObjectMaskingTaskInputData>`
      - `* input: object<TaskInput> -> object<ObjectMaskingTaskInput>`
  - **ShowVideoObjectMaskingTask**
    - 响应参数变更
      - `* input.data: list<TaskInputData> -> list<ObjectMaskingTaskInputData>`
      - `* input: object<TaskInput> -> object<ObjectMaskingTaskInput>`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`BatchDeleteGroup`
- _解决问题_
  - 无
- _特性变更_
  - **ResizeEngineInstance**
    - 请求参数变更
      - `+ publicip_id`

### HuaweiCloud SDK SIS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeShortAudio**
    - 请求参数变更
      - `+ config.property: enum value [english_8k_common,english_16k_common]`
  - **CollectTranscriberJob**
    - 响应参数变更
      - `+ job_id`

# 3.1.34 2023-04-06

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateRefreshTasks**
    - 请求参数变更
      - `+ refresh_task.mode`

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListAlarmHistories**
    - 响应参数变更
      - `+ alarm_histories.type: enum value [DNSHealthCheck,RESOURCE_GROUP,MULTI_INSTANCE,ALL_INSTANCE]`
  - **ListAlarmRules**
    - 响应参数变更
      - `+ alarms.type: enum value [EVENT.SYS,EVENT.CUSTOM,DNSHealthCheck,RESOURCE_GROUP,MULTI_INSTANCE,ALL_INSTANCE]`
  - **CreateAlarmRules**
    - 请求参数变更
      - `+ type: enum value [EVENT.SYS,EVENT.CUSTOM,DNSHealthCheck,RESOURCE_GROUP,MULTI_INSTANCE,ALL_INSTANCE]`

### HuaweiCloud SDK Image

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`CreateTextToImageTask`、`ShowTextToImageTask`、`CreateImageVariationTask`、`ShowImageVariationTask`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **RecognizeFinancialStatement**
    - 请求参数变更
      - `+ return_rectification_matrix`
    - 响应参数变更
      - `+ result.rectification_matrix`

# 3.1.33 2023-03-30

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListBackups**
    - 请求参数变更
      - `+ incremental`
  - **ListVault**
    - 响应参数变更
      - `+ vaults.billing.object_type: enum value [vmware,rds,file]`
  - **CreateVault**
    - 请求参数变更
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
    - 响应参数变更
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
  - **ShowVault**
    - 响应参数变更
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
  - **UpdateVault**
    - 响应参数变更
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
  - **ShowVaultResourceInstances**
    - 响应参数变更
      - `+ resources.resource_detail.billing.object_type: enum value [vmware,rds,file]`
  - **ListProtectable**
    - 响应参数变更
      - `+ instances.protectable.vault.billing.object_type: enum value [vmware,rds,file]`
  - **ShowProtectable**
    - 响应参数变更
      - `+ instance.protectable.vault.billing.object_type: enum value [vmware,rds,file]`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListOtaPackageInfo**
    - 请求参数变更
      - `- Sp-Auth-Token`
  - **CreateOtaPackage**
    - 请求参数变更
      - `- Sp-Auth-Token`
  - **DeleteOtaPackage**
    - 请求参数变更
      - `- Sp-Auth-Token`
  - **ShowOtaPackage**
    - 请求参数变更
      - `- Sp-Auth-Token`
  - **ShowRuleAction**
    - 响应参数变更
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
  - **UpdateRuleAction**
    - 请求参数变更
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
    - 响应参数变更
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
  - **CreateRuleAction**
    - 请求参数变更
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
    - 响应参数变更
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
  - **ListRuleActions**
    - 响应参数变更
      - `+ actions.channel_detail.http_forwarding.signature_enable`
      - `+ actions.channel_detail.http_forwarding.token`
  - **ShowRule**
    - 响应参数变更
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
  - **UpdateRule**
    - 请求参数变更
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
    - 响应参数变更
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
  - **CreateRule**
    - 请求参数变更
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
    - 响应参数变更
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
  - **ListRules**
    - 响应参数变更
      - `+ rules.actions.device_alarm.dimension`
      - `+ rules.condition_group.conditions.device_linkage_status_condition`
      - `+ rules.condition_group.conditions.device_property_condition.filters.in_values`

### HuaweiCloud SDK NAT

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListPrivateDnats**
    - 响应参数变更
      - `* page_info.current_count: number -> integer`
  - **ListPrivateNats**
    - 响应参数变更
      - `* page_info.current_count: number -> integer`
  - **ListPrivateSnats**
    - 响应参数变更
      - `* page_info.current_count: number -> integer`
  - **ListTransitIps**
    - 响应参数变更
      - `* page_info.current_count: number -> integer`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **PublishAssetFromObs**
    - 请求参数变更
      - `+ video_type: enum value [RMVB,WEBM]`

# 3.1.32 2023-03-23

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowNode**
    - 响应参数变更
      - `+ spec.extendParam.agency_name`
  - **UpdateNode**
    - 响应参数变更
      - `+ spec.extendParam.agency_name`
  - **DeleteNode**
    - 响应参数变更
      - `+ spec.extendParam.agency_name`
  - **CreateNode**
    - 请求参数变更
      - `+ spec.extendParam.agency_name`
    - 响应参数变更
      - `+ spec.extendParam.agency_name`
  - **ListNodes**
    - 响应参数变更
      - `+ items.spec.extendParam.agency_name`
  - **ShowNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **UpdateNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **DeleteNodePool**
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **CreateNodePool**
    - 请求参数变更
      - `+ spec.nodeTemplate.extendParam.agency_name`
    - 响应参数变更
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **ListNodePools**
    - 响应参数变更
      - `+ items.spec.nodeTemplate.extendParam.agency_name`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowDomainDetailByName**
    - 响应参数变更
      - `- domain.banned_reason`
      - `- domain.locked_reason`
      - `- domain.enterprise_project_id`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **CreateMigrationTask**
    - 请求参数变更
      - `+ backup_files.file_source: enum value [backup_record]`
  - **ShowMigrationTask**
    - 响应参数变更
      - `+ backup_files.file_source: enum value [backup_record]`
  - **StopMigrationTask**
    - 响应参数变更
      - `+ backup_files.file_source: enum value [backup_record]`

### HuaweiCloud SDK DDS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowReplSetName**
    - 响应参数变更
      - `+ name`
  - **UpdateReplSetName**
    - 响应参数变更
      - `+ job_id`

### HuaweiCloud SDK NAT

- _新增特性_
  - 支持以下接口：
    - `ListPrivateNats`
    - `CreatePrivateNat`
    - `ShowPrivateNat`
    - `UpdatePrivateNat`
    - `DeletePrivateNat`
    - `ListPrivateDnats`
    - `CreatePrivateDnat`
    - `ShowPrivateDnat`
    - `UpdatePrivateDnat`
    - `DeletePrivateDnat`
    - `ListPrivateSnats`
    - `CreatePrivateSnat`
    - `ShowPrivateSnat`
    - `UpdatePrivateSnat`
    - `DeletePrivateSnat`
    - `ListTransitIps`
    - `CreateTransitIp`
    - `ShowTransitIp`
    - `DeleteTransitIp`
    - `ListPrivateNatsByTags`
    - `ListPrivateNatTags`
    - `ShowPrivateNatTags`
    - `CreatePrivateNatTag`
    - `BatchCreateDeletePrivateNatTags`
    - `DeletePrivateNatTag`
    - `ListTransitIpsByTags`
    - `ListTransitIpTags`
    - `ShowTransitIpTags`
    - `CreateTransitIpTag`
    - `BatchCreateDeleteTransitIpTags`
    - `DeleteTransitIpTag`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RabbitMQ

- _新增特性_
  - 支持接口`ShowEngineInstanceExtendProductInfo`、`ResizeEngineInstance`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.31 2023-03-16

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ShowJobInfos**
    - 响应参数变更
      - `* begin_time: date-time -> string`
      - `* end_time: date-time -> string`
      - `* entities.sub_jobs.begin_time: date-time -> string`
      - `* entities.sub_jobs.end_time: date-time -> string`

### HuaweiCloud SDK CDN

- _新增特性_
  - 支持接口`ListDomains`、`ShowDomainDetailByName`
- _解决问题_
  - 无
- _特性变更_
  - **ListDomains**
    - 请求参数变更
      - `+ show_tags`
      - `+ exact_match`
    - 响应参数变更
      - `+ domains.tags`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **ListBandwidthPkg**
    - 请求参数变更
      - `+ limit`
      - `+ marker`
      - `+ offset`
  - **ListCommonPools**
    - 请求参数变更
      - `+ limit`
      - `+ offset`
  - **ListShareBandwidthTypes**
    - 请求参数变更
      - `+ marker`
      - `+ offset`

### HuaweiCloud SDK IAM

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - **KeystoneListMappings**
    - 响应参数变更
      - `* mappings.rules.local.groups: object -> string`
  - **KeystoneShowMapping**
    - 响应参数变更
      - `* mapping.rules.local.groups: object -> string`
  - **KeystoneCreateMapping**
    - 请求参数变更
      - `* mapping.rules.local.groups: object -> string`
    - 响应参数变更
      - `* mapping.rules.local.groups: object -> string`
  - **KeystoneUpdateMapping**
    - 请求参数变更
      - `* mapping.rules.local.groups: object -> string`
    - 响应参数变更
      - `* mapping.rules.local.groups: object -> string`

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`CreateVideoObjectMaskingTask`、`ShowVideoObjectMaskingTask`
- _解决问题_
  - 无
- _特性变更_
  - **CreateTextToImageTask**
    - 请求参数变更
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`
  - **ShowTextToImageTask**
    - 响应参数变更
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`
  - **CreateImageVariationTask**
    - 请求参数变更
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`
  - **ShowImageVariationTask**
    - 响应参数变更
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`

### HuaweiCloud SDK IVS

- _新增特性_
  - 支持接口`DetectStandardByVideoAndIdCardImage`、`DetectStandardByVideoAndNameAndId`
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
  - **RecognizeMvsInvoice**
    - 请求参数变更
      - `+ return_text_location`
      - `+ return_confidence`
      - `+ type`
    - 响应参数变更
      - `+ result.buyer_address`
      - `+ result.buyer_phone`
      - `+ result.licence_plate_number`
      - `+ result.registration_number`
      - `+ result.dept_motor_vehicles`
      - `+ result.auction_org_name`
      - `+ result.auction_org_address`
      - `+ result.auction_org_id`
      - `+ result.auction_org_bank_account`
      - `+ result.auction_org_phone`
      - `+ result.used_vehicle_market_name`
      - `+ result.used_vehicle_market_id`
      - `+ result.used_vehicle_market_address`
      - `+ result.used_vehicle_market_bank_account`
      - `+ result.used_vehicle_market_phone`
      - `+ result.remark`
      - `+ result.drawer_name`
      - `+ result.type`
      - `+ result.text_location`
      - `+ result.confidence`

# 3.1.30 2023-03-14

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`CreateTextToImageTask`、`ShowTextToImageTask`、`CreateImageVariationTask`、`ShowImageVariationTask`
- _解决问题_
  - 无
- _特性变更_
  - 移除接口`RunImageWisedesignColorfilter`、`RunImageWisedesignCombine`

# 3.1.29 2023-03-09

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持以下接口：
    - `ListTemplates`
    - `DeleteTemplate`
    - `ShowTemplateMetadata`
    - `UpdateTemplateMetadata`
    - `ShowTemplateVersionContent`
    - `DeleteTemplateVersion`
    - `ShowTemplateVersionMetadata`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListExecutionPlans`:
    - 响应参数`status`新增枚举值`APPLY_IN_PROGRESS`
    - 响应参数`stack_name`、`execution_plan_name`改为必填
  - 接口`GetExecutionPlan`响应参数`action`移除枚举值`IN_PLACE_UPDATE`
  - 接口`GetExecutionPlanMetadata`响应参数`stack_name`、`execution_plan_name`改为必填
  - 接口`ListStackResources`新增响应参数 `resource_attributes`
  - 接口`EstimateExecutionPlanPrice`:
    - 新增响应参数 `unsupported_message`
    - 响应参数`sale_price`类型调整 `object` -> `double`
    - 响应参数`discount`类型调整 `object` -> `double`
    - 响应参数`original_price`类型调整 `object` -> `double`
    - 响应参数`period_type`移除枚举值`WEEK`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateDevice`新增响应参数 `connection_status_update_time`、`active_time`
  - 接口`ShowDevice`新增响应参数 `connection_status_update_time`、`active_time`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeAutoClassification`新增请求参数 `extended_parameters`

# 3.1.28 2023-03-07

### HuaweiCloud SDK VOD

- _新增特性_
  - 支持接口`ModifySubtitle`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.27 2023-03-02

### HuaweiCloud SDK BMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListBareMetalServers`:
    - 响应参数`status`新增枚举值`HARD_REBOOT`、`DELETED`
    - 响应参数`OS-EXT-STS:vm_state`移除枚举值`suspended`
  - 接口`CreateBareMetalServers`:
    - 新增请求参数 `chargingMode`
    - 移除请求参数 `chargingmode`
  - 接口`ChangeBaremetalServerName`响应参数`OS-EXT-STS:vm_state`移除枚举值`SUSPENDED`
  - 接口`ListBareMetalServerDetails`:
    - 响应参数`status`新增枚举值`HARD_REBOOT`、`DELETED`
    - 响应参数`OS-EXT-STS:vm_state`移除枚举值`suspended`

### HuaweiCloud SDK CDN

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowDomainFullConfig`:
    - 响应参数`error_code`类型调整 `string` -> `int32`
    - 响应参数`target_code`类型调整 `string` -> `int32`
  - 接口`UpdateDomainFullConfig`:
    - 请求参数`error_code`类型调整 `string` -> `int32`
    - 请求参数`target_code`类型调整 `string` -> `int32`

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持接口`ShowReplSetName`、`UpdateReplSetName`
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
  - 接口`UpdateTrigger`:
    - 新增请求参数 `event_data`
    - 新增响应参数 `trigger_id`、`trigger_type_code`、`trigger_status`、`event_data`、`last_updated_time`、`created_time`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持以下接口：
    - `ResetDbUserPassword`
    - `ModifyDbUserPrivilege`
    - `ListDbUsers`
    - `CreateDbUser`
    - `DeleteDbUser`
    - `ListInstanceDatabases`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK Image

- _新增特性_
  - 支持以下接口：
    - `CreateVideoSynthesisTask`
    - `ShowVideoSynthesisTask`
    - `CreateImageToVideoTask`
    - `ShowImageToVideoTask`
    - `CreateVideoCuttingTask`
    - `ShowVideoCuttingTask`
    - `CreateVideoTranslateTask`
    - `ShowVideoTranslateTask`
    - `CreateImageHighresolutionMattingTask`
    - `ShowImageHighresolutionMattingTask`
    - `CreateImageTranslateTask`
    - `ShowImageTranslateTask`
    - `CreateVideoCoverAnalysisTask`
    - `ShowVideoCoverAnalysisTask`
    - `CreateVideoSummarizationAnalysisTask`
    - `ShowVideoSummarizationAnalysisTask`
    - `CreateVideoShotSplitTask`
    - `ShowVideoShotSplitTask`
    - `RunImageWisedesignCrop`
    - `RunImageWisedesignInpainting`
    - `RunImageWisedesignColorfilter`
    - `RunImageWisedesignCombine`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`ListOtaPackageInfo`、`CreateOtaPackage`、`ShowOtaPackage`、`DeleteOtaPackage`
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
  - 接口`ListInstanceConsumerGroups`:
    - 新增响应参数 `groups`
    - 移除响应参数 `group_ids`、`next_offset`、`previous_offset`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`ListSpecIssueStayTimes`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.26 2023-02-23

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListVault`响应参数`value`改为必填
  - 接口`CreateVault`:
    - 请求参数`value`改为必填
    - 响应参数`value`改为必填
  - 接口`ShowVault`响应参数`value`改为必填
  - 接口`UpdateVault`:
    - 请求参数`value`改为必填
    - 响应参数`value`改为必填
  - 接口`ListProtectable`响应参数`value`改为必填
  - 接口`ShowProtectable`响应参数`value`改为必填
  - 接口`ShowVaultResourceInstances`响应参数`value`改为必填

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持接口`ShrinkInstanceNodes`
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
  - 接口`ListRoutingRules`新增请求参数 `active`
  - 接口`CreateRuleAction`新增请求参数 `mysql_forwarding`
  - 接口`ListRuleActions`新增响应参数 `mysql_forwarding`
  - 接口`UpdateRuleAction`:
    - 新增请求参数 `mysql_forwarding`
    - 新增响应参数 `mysql_forwarding`
  - 接口`ShowRuleAction`新增响应参数 `mysql_forwarding`

# 3.1.25 2023-02-16

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`CreateCustomTemplate`、`CreateAutoExpireScanTask`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK FRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DetectLiveByUrl`新增请求参数 `nod_threshold`
  - 接口`DetectLiveByUrlIntl`新增请求参数 `nod_threshold`
  - 接口`DetectLiveByFile`新增请求参数 `nod_threshold`
  - 接口`DetectLiveByFileIntl`新增请求参数 `nod_threshold`
  - 接口`DetectLiveByBase64`新增请求参数 `nod_threshold`
  - 接口`DetectLiveByBase64Intl`新增请求参数 `nod_threshold`

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`RunImageSuperResolution`、`RunRecaptureDetect`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持接口`CreateInstanceByEngine`、`BatchCreateOrDeleteRocketmqTag`、`ShowRocketmqTags`、`ShowRocketmqProjectTags`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增请求参数 `limit`、`offset`
  - 接口`ShowConsumerListOrDetails`新增请求参数 `limit`、`offset`
  - 接口`ListConsumerGroupOfTopic`新增请求参数 `limit`、`offset`

# 3.1.24 2023-02-09

### HuaweiCloud SDK DDS

- _新增特性_
  - 支持接口`ListLtsSlowLogs`
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
  - 接口`ListAsyncInvocations`新增响应参数 `error_code`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowPauseResumeStutus`:
    - 新增请求参数 `X-Auth-Token`
    - 新增响应参数 `master_instance_id`、`slave_instance_id`、`data_sync_indicators`、`rto_and_rpo_indicators`
    - 移除请求参数 `x-auth-token`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListRuleActions`新增响应参数 `roma_forwarding`、`influxdb_forwarding`、`functiongraph_forwarding`、`mrs_kafka_forwarding`、`dms_rocketmq_forwarding`
  - 接口`CreateRuleAction`新增请求参数 `roma_forwarding`、`influxdb_forwarding`、`functiongraph_forwarding`、`mrs_kafka_forwarding`、`dms_rocketmq_forwarding`
  - 接口`UpdateRuleAction`:
    - 新增请求参数 `roma_forwarding`、`influxdb_forwarding`、`functiongraph_forwarding`、`mrs_kafka_forwarding`、`dms_rocketmq_forwarding`
    - 新增响应参数 `roma_forwarding`、`influxdb_forwarding`、`functiongraph_forwarding`、`mrs_kafka_forwarding`、`dms_rocketmq_forwarding`
  - 接口`ShowRuleAction`新增响应参数 `roma_forwarding`、`influxdb_forwarding`、`functiongraph_forwarding`、`mrs_kafka_forwarding`、`dms_rocketmq_forwarding`

### HuaweiCloud SDK OCR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeTollInvoice`:
    - 新增请求参数 `return_text_location`
    - 新增响应参数 `text_location`

# 3.1.23 2023-02-02

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`UpdateStack`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ApplyExecutionPlan`新增请求参数 `executor`
  - 接口`ListStackEvents`:
    - 新增请求参数 `filter`、`field`
    - 移除响应参数 `resource_id_key`、`resource_id_value`、`resource_name`、`resource_type`、`time`、`event_type`、`event_message`、`elapsed_seconds`
  - 接口`GetStackMetadata`响应参数`stack_name`改为必填
  - 接口`CreateStack`新增请求参数 `executor`
  - 接口`ListStackResources`:
    - 新增响应参数 `index_key`
    - 响应参数`resource_status`移除枚举值`DELETION_SKIPPED`
  - 接口`DeployStack`新增请求参数 `executor`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateImage`请求参数`type`新增枚举值`IsoImage`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 支持接口`CreateInstanceByEngine`、`ShowEngineInstanceExtendProductInfo`、`ResizeEngineInstance`、`CreateReassignmentTask`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListInstances`新增响应参数 `sasl_enabled_mechanisms`
  - 接口`CreatePostPaidInstance`请求参数`kafka_manager_user`、`kafka_manager_password`改为非必填
  - 接口`ShowInstance`新增响应参数 `sasl_enabled_mechanisms`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunTextModeration`新增请求参数 `white_glossaries`

# 3.1.22 2023-01-19

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`UploadBatchTaskFile`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.21 2023-01-12

### HuaweiCloud SDK CES

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListAlarmHistories`:
    - 新增响应参数 `data_points`
    - 移除响应参数 `datapoints`

### HuaweiCloud SDK FRS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DetectLiveByUrl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveByUrlIntl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveFaceByUrl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveByFile`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveByFileIntl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveFaceByFile`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveByBase64`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveByBase64Intl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectLiveFaceByBase64`新增请求参数 `Enterprise-Project-Id`
  - 接口`SearchFaceByFaceId`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectFaceByFile`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectFaceByFileIntl`新增请求参数 `Enterprise-Project-Id`
  - 接口`UpdateFace`新增请求参数 `Enterprise-Project-Id`
  - 接口`DeleteFaceByExternalImageId`新增请求参数 `Enterprise-Project-Id`
  - 接口`ShowFacesByLimit`新增请求参数 `Enterprise-Project-Id`
  - 接口`CompareFaceByFile`新增请求参数 `Enterprise-Project-Id`
  - 接口`DeleteFaceByFaceId`新增请求参数 `Enterprise-Project-Id`
  - 接口`ShowFacesByFaceId`新增请求参数 `Enterprise-Project-Id`
  - 接口`AddFacesByBase64`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectFaceByUrl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectFaceByUrlIntl`新增请求参数 `Enterprise-Project-Id`
  - 接口`DeleteFaceSet`新增请求参数 `Enterprise-Project-Id`
  - 接口`ShowFaceSet`新增请求参数 `Enterprise-Project-Id`
  - 接口`CompareFaceByBase64`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectFaceByBase64`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectFaceByBase64Intl`新增请求参数 `Enterprise-Project-Id`
  - 接口`CreateFaceSet`新增请求参数 `Enterprise-Project-Id`
  - 接口`ShowAllFaceSets`新增请求参数 `Enterprise-Project-Id`
  - 接口`SearchFaceByFile`新增请求参数 `Enterprise-Project-Id`
  - 接口`AddFacesByUrl`新增请求参数 `Enterprise-Project-Id`
  - 接口`AddFacesByFile`新增请求参数 `Enterprise-Project-Id`
  - 接口`SearchFaceByUrl`新增请求参数 `Enterprise-Project-Id`
  - 接口`SearchFaceByBase64`新增请求参数 `Enterprise-Project-Id`
  - 接口`CompareFaceByUrl`新增请求参数 `Enterprise-Project-Id`
  - 接口`BatchDeleteFaces`新增请求参数 `Enterprise-Project-Id`

### HuaweiCloud SDK IVS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`DetectStandardByIdCardImage`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectStandardByNameAndId`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectExtentionByNameAndId`新增请求参数 `Enterprise-Project-Id`
  - 接口`DetectExtentionByIdCardImage`新增请求参数 `Enterprise-Project-Id`

### HuaweiCloud SDK OCR

- _新增特性_
  - 支持接口`RecognizeCustomTemplate`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RecognizeGeneralTable`:
    - 新增请求参数 `return_char_location`、`return_rectification_matrix`
    - 新增响应参数 `char_list`
  - 接口`RecognizeGeneralText`新增请求参数 `language`
  - 接口`RecognizeWebImage`:
    - 新增响应参数 `extracted_data`
    - 移除响应参数 `extracted_data`、`contact_info`、`image_size`、`height`、`width`、`name`、`phone`、`province`、`city`、`district`、`detail_address`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 支持接口`ListRocketInstanceTopics`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowOneTopic`新增响应参数 `name`

# 3.1.20 2023-01-05

### HuaweiCloud SDK DCS

- _新增特性_
  - 支持接口`ListConfigHistories`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DNS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 移除以下接口：
    - `ListResoleRules`
    - `SetPrivateZoneProxyPattern`
    - `ShowDomainQuota`
    - `ShowRetrieval`
    - `CreateRetrieval`
    - `ShowRetrievalVerification`
    - `CreateRetrievalVerification`
    - `ListEndpoints`
    - `CreateEndpoint`
    - `ShowEndpoint`
    - `UpdateEndpoint`
    - `DeleteEndpoint`
    - `ListEndpointIpaddresses`
    - `AssociateEndpointIpaddress`
    - `DisassociateEndpointIpaddress`
    - `ListEndpointVpcs`
    - `CreateResolveRule`
    - `AssociateResolveRuleRouter`
    - `DisassociateResolveRuleRouter`
    - `ShowResoleRule`
    - `UpdateResolveRule`
    - `DeleteResolveRule`
    - `BatchDeleteZones`
    - `BatchDeletePtrRecords`
    - `BatchSetZonesStatus`
    - `BatchSetRecordSetsStatus`
    - `BatchDeleteRecordSets`
  - 接口`CreatePrivateZone`:
    - 新增请求参数 `proxy_pattern`
    - 新增响应参数 `proxy_pattern`
  - 接口`ListPrivateZones`新增响应参数 `proxy_pattern`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListFunctionTriggers`响应参数`trigger_status`新增枚举值`DISABLED`, 移除枚举值`DISABLE`
  - 接口`UpdateTrigger`请求参数`trigger_status`新增枚举值`DISABLED`, 移除枚举值`DISABLE`
  - 接口`ShowFunctionTrigger`响应参数`trigger_status`新增枚举值`DISABLED`, 移除枚举值`DISABLE`
  - 接口`CreateWorkflow`新增请求参数 `enable_stream_response`
  - 接口`UpdateWorkFlow`新增请求参数 `enable_stream_response`
  - 接口`ShowWorkFlow`新增响应参数 `enable_stream_response`

### HuaweiCloud SDK Moderation

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunTextModeration`新增请求参数 `white_glossary_names`

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListPorts`:
    - 新增请求参数 `security_groups`
    - 请求参数`fixed_ips`类型调整 `string` -> `array`

# 3.1.19 2022-12-29

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListDnsServers`新增请求参数 `fw_instance_id`、`enterprise_project_id`
  - 接口`UpdateDnsServers`新增请求参数 `fw_instance_id`、`enterprise_project_id`
  - 接口`ListVpcProtects`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListRuleHitCount`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`DeleteAclRuleCount`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ChangeIpsSwitchUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListIpsSwitchStatusUsingGet`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListEastWestFirewall`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ChangeEwProtectStatus`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListFlowLogs`新增请求参数 `enterprise_project_id`
  - 接口`ListAccessControlLogs`新增请求参数 `enterprise_project_id`
  - 接口`ListAttackLogs`新增请求参数 `enterprise_project_id`
  - 接口`AddRuleAclUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`DeleteRuleAclUsingDelete`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`UpdateRuleAclUsingPut`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListRuleAclsUsingGet`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListRuleAclUsingPut`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`AddBlackWhiteListUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`DeleteBlackWhiteListUsingDelete`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`UpdateBlackWhiteListUsingPut`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListBlackWhiteListsUsingGet`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ChangeIpsProtectModeUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListIpsProtectModeUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListFirewallUsingGet`:
    - 新增请求参数 `enterprise_project_id`、`fw_instance_id`
    - 新增响应参数 `fw_instance_name`、`enterprise_project_id`
  - 接口`AddServiceSetUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`DeleteServiceSetUsingDelete`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListServiceSetDetails`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`UpdateServiceSetUsingPut`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`AddServiceItemsUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListServiceItemsDetails`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`DeleteServiceItemUsingDelete`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListParseDomainDetails`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`CountEips`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ChangeProtectEip`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListEipResources`:
    - 新增请求参数 `fw_instance_id`、`fw_key_word`、`eps_id`
    - 新增响应参数 `fw_instance_name`、`fw_instance_id`、`fw_enterprise_project_id`
  - 接口`DeleteAddressItemUsingDelete`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`AddAddressItemsUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListAddressItemsUsingGet`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`AddAddressSetInfoUsingPost`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListAddressSetListUsingGet`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`DeleteAddressSetInfoUsingDelete`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListAddressSetDetailUsingGet`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`UpdateAddressSetInfoUsingPut`新增请求参数 `enterprise_project_id`、`fw_instance_id`
  - 接口`ListServiceSet`新增请求参数 `enterprise_project_id`、`fw_instance_id`

### HuaweiCloud SDK DCS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateBigkeyScanTask`响应参数`size`类型调整 `int32` -> `int64`
  - 接口`ShowBigkeyScanTaskDetails`响应参数`size`类型调整 `int32` -> `int64`
  - 接口`CreateHotkeyScanTask`响应参数`size`类型调整 `int32` -> `int64`
  - 接口`ShowHotkeyTaskDetails`响应参数`size`类型调整 `int32` -> `int64`

### HuaweiCloud SDK DNS

- _新增特性_
  - 支持接口`AssociateResolveRuleRouter`、`DisassociateResolveRuleRouter`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListPublicZones`移除响应参数 `total_count`
  - 接口`ListPrivateZones`移除响应参数 `total_count`
  - 接口`ListRecordSetsByZone`移除响应参数 `total_count`
  - 接口`ListRecordSets`移除响应参数 `total_count`
  - 接口`BatchDeleteRecordSetWithLine`移除响应参数 `total_count`
  - 接口`BatchUpdateRecordSetWithLine`移除响应参数 `total_count`
  - 接口`ListRecordSetsWithLine`移除响应参数 `total_count`
  - 接口`CreateRecordSetWithBatchLines`移除响应参数 `total_count`
  - 接口`ShowRecordSetByZone`移除响应参数 `total_count`
  - 接口`ListPtrRecords`移除响应参数 `total_count`
  - 接口`ListCustomLine`移除响应参数 `total_count`

### HuaweiCloud SDK EIP

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ChangeBandwidthToPeriod`新增请求参数 `extendParam`
  - 接口`ChangePublicipToPeriod`新增请求参数 `extendParam`
  - 接口`ListBandwidthPkg`:
    - 新增响应参数 `tenantId`
    - 移除响应参数 `tenant_id`
  - 接口`UpdateAssociatePublicip`请求参数`associate_instance_type`、`associate_instance_id`改为必填
  - 接口`AssociatePublicips`请求参数`associate_instance_type`、`associate_instance_id`改为必填

### HuaweiCloud SDK ELB

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListLoadbalancersByTags`:
    - 移除请求参数 `without_any_tag`
    - 请求参数`values`改为必填
  - 接口`ListListenersByTags`:
    - 移除请求参数 `without_any_tag`
    - 请求参数`values`改为必填
  - 接口`ShowQuota`新增响应参数 `ipgroup_bindings`、`ipgroup_max_length`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowJob`新增响应参数 `sub_jobs_result`、`sub_jobs_list`
  - 接口`ShowJobProgress`新增响应参数 `sub_jobs_result`、`sub_jobs_list`

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateTranscodeTemplate`请求参数`name`改为非必填
  - 接口`UpdateTemplateGroupCollection`:
    - 请求参数`collection_id`改为必填
    - 请求参数`name`、`template_group_list`改为非必填

### HuaweiCloud SDK VPC

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListVpcs`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`CreateVpc`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`ShowVpc`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`UpdateVpc`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`ListSubnets`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`CreateSubnet`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`ShowSubnet`新增响应参数 `tenant_id`、`created_at`、`updated_at`
  - 接口`ListRouteTables`新增响应参数 `created_at`、`updated_at`
  - 接口`CreateRouteTable`新增响应参数 `created_at`、`updated_at`
  - 接口`ShowRouteTable`新增响应参数 `created_at`、`updated_at`
  - 接口`UpdateRouteTable`新增响应参数 `created_at`、`updated_at`
  - 接口`AssociateRouteTable`新增响应参数 `created_at`、`updated_at`
  - 接口`DisassociateRouteTable`新增响应参数 `created_at`、`updated_at`

# 3.1.18 2022-12-26

### HuaweiCloud SDK VOD

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`UpdateTranscodeTemplate`请求参数`group_id`、`name`、`bitrate`、`frame_rate`、`video_codec`、`format`、`hls_interval`改为必填
  - 接口`ListTranscodeTemplate`响应参数`bitrate`、`frame_rate`、`video_codec`、`format`、`hls_interval`改为必填
  - 接口`CreateTranscodeTemplate`请求参数`name`、`bitrate`、`frame_rate`、`video_codec`、`format`、`hls_interval`改为必填
  - 接口`UpdateTemplateGroupCollection`请求参数`name`、`template_group_list`改为必填
  - 接口`CreateTemplateGroupCollection`请求参数`name`、`template_group_list`改为必填

# 3.1.17 2022-12-22

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ShowWorkflowExecutionForPage`:
    - 新增响应参数 `created_by`
    - 移除响应参数 `create_by`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 支持接口`ModifyVolume`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListAvailableFlavorInfos`新增请求参数 `offset`、`limit`

### HuaweiCloud SDK IMS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CopyImageCrossRegion`新增请求参数 `vault_id`

### HuaweiCloud SDK IoTDA

- _新增特性_
  - 支持接口`SearchDevices`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateRule`新增请求参数 `device_side`
  - 接口`ListRules`新增响应参数 `device_side`
  - 接口`ShowRule`新增响应参数 `device_side`
  - 接口`UpdateRule`:
    - 新增请求参数 `device_side`
    - 新增响应参数 `device_side`

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidInstance`新增请求参数 `sasl_enabled_mechanisms`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidInstance`新增请求参数 `enterprise_project_id`、`enable_acl`

# 3.1.16 2022-12-19

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateVault`:
    - 请求参数`object_type`新增枚举值`workspace`
    - 响应参数`object_type`新增枚举值`workspace`
  - 接口`ListVault`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowVault`响应参数`object_type`新增枚举值`workspace`
  - 接口`UpdateVault`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowBackup`响应参数`resource_type`新增枚举值`OS::Workspace::DesktopV2`
  - 接口`ListBackups`:
    - 请求参数`resource_type`新增枚举值`OS::Workspace::DesktopV2`
    - 响应参数`resource_type`新增枚举值`OS::Workspace::DesktopV2`
  - 接口`ListProtectable`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowProtectable`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowVaultResourceInstances`响应参数`object_type`新增枚举值`workspace`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListServersDetails`新增请求参数 `server_id`

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持接口`ShowResourcesJobDetail`、`ChangeBandwidthToPeriod`、`ChangePublicipToPeriod`
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
    - 新增请求参数 `depend_version_list`、`func_vpc`
    - 新增响应参数 `depend_version_list`
  - 接口`UpdateFunctionCode`:
    - 新增请求参数 `depend_version_list`
    - 新增响应参数 `depend_version_list`
  - 接口`ShowFunctionCode`新增响应参数 `depend_version_list`
  - 接口`ShowFunctionConfig`新增响应参数 `depend_version_list`
  - 接口`ListReservedInstanceConfigs`:
    - 新增请求参数 `marker`、`limit`
    - 新增响应参数 `reserved_instances`
    - 移除响应参数 `reservedinstances`
  - 接口`ImportFunction`新增响应参数 `depend_version_list`
  - 接口`ListFunctionReservedInstances`:
    - 新增请求参数 `limit`
    - 移除请求参数 `maxitems`
  - 接口`ShowWorkflowExecutionForPage`:
    - 新增请求参数 `offset`、`limit`、`start_time`、`end_time`
    - 移除请求参数 `CreateWorkflowRequestBody`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListConfigurationDatastores`:
    - 新增响应参数 `datastore_name`
    - 移除响应参数 `datastore_type`
  - 接口`ModifyEpsQuotas`移除请求参数 `instance`、`vcpus`、`ram`
  - 接口`ListEpsQuotas`移除响应参数 `instance`、`vcpus`、`ram`、`instance`、`vcpus`、`ram`

# 3.1.15 2022-12-15

### HuaweiCloud SDK CBR

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateVault`:
    - 请求参数`object_type`新增枚举值`workspace`
    - 响应参数`object_type`新增枚举值`workspace`
  - 接口`ListVault`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowVault`响应参数`object_type`新增枚举值`workspace`
  - 接口`UpdateVault`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowBackup`响应参数`resource_type`新增枚举值`OS::Workspace::DesktopV2`
  - 接口`ListBackups`:
    - 请求参数`resource_type`新增枚举值`OS::Workspace::DesktopV2`
    - 响应参数`resource_type`新增枚举值`OS::Workspace::DesktopV2`
  - 接口`ListProtectable`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowProtectable`响应参数`object_type`新增枚举值`workspace`
  - 接口`ShowVaultResourceInstances`响应参数`object_type`新增枚举值`workspace`

### HuaweiCloud SDK ECS

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListServersDetails`新增请求参数 `server_id`

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持接口`ShowResourcesJobDetail`、`ChangeBandwidthToPeriod`、`ChangePublicipToPeriod`
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
    - 新增请求参数 `depend_version_list`、`func_vpc`
    - 新增响应参数 `depend_version_list`
  - 接口`UpdateFunctionCode`:
    - 新增请求参数 `depend_version_list`
    - 新增响应参数 `depend_version_list`
  - 接口`ShowFunctionCode`新增响应参数 `depend_version_list`
  - 接口`ShowFunctionConfig`新增响应参数 `depend_version_list`
  - 接口`ListReservedInstanceConfigs`:
    - 新增请求参数 `marker`、`limit`
    - 新增响应参数 `reserved_instances`
    - 移除响应参数 `reservedinstances`
  - 接口`ImportFunction`新增响应参数 `depend_version_list`
  - 接口`ListFunctionReservedInstances`:
    - 新增请求参数 `limit`
    - 移除请求参数 `maxitems`
  - 接口`ShowWorkflowExecutionForPage`:
    - 新增请求参数 `offset`、`limit`、`start_time`、`end_time`
    - 移除请求参数 `CreateWorkflowRequestBody`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListConfigurationDatastores`:
    - 新增响应参数 `datastore_name`
    - 移除响应参数 `datastore_type`
  - 接口`ModifyEpsQuotas`移除请求参数 `instance`、`vcpus`、`ram`
  - 接口`ListEpsQuotas`移除响应参数 `instance`、`vcpus`、`ram`、`instance`、`vcpus`、`ram`

# 3.1.14 2022-12-08

### HuaweiCloud SDK AOS

- _新增特性_
  - 支持接口`GetExecutionPlan`、`DeleteExecutionPlan`、`DescribeExecutionPlan`、`GetStackMetadata`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListExecutionPlans`移除请求参数 `executor`
  - 接口`CreateExecutionPlan`移除请求参数 `executor`
  - 接口`ApplyExecutionPlan`移除请求参数 `executor`
  - 接口`ListStackEvents`:
    - 移除请求参数 `limit`、`marker`、`executor`
    - 移除响应参数 `next_marker`
  - 接口`ListStacks`移除请求参数 `executor`
  - 接口`CreateStack`移除请求参数 `executor`
  - 接口`GetStackTemplate`移除请求参数 `executor`
  - 接口`ListStackResources`:
    - 移除请求参数 `executor`
    - 移除响应参数 `create_time`、`update_time`
  - 接口`ListStackOutputs`:
    - 移除请求参数 `executor`、`limit`、`marker`
    - 移除响应参数 `next_marker`
  - 接口`DeployStack`移除请求参数 `executor`
  - 接口`DeleteStack`移除请求参数 `executor`

### HuaweiCloud SDK CCE

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateAddonInstance`请求参数`version`改为非必填
  - 接口`UpdateAddonInstance`请求参数`version`改为非必填

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListIpsSwitchStatusUsingGet`:
    - 新增响应参数 `id`、`virtual_patches_status`
    - 移除响应参数 `object_id`、`virtual_patches_stauts`
  - 接口`ChangeIpsSwitchUsingPost`请求参数`ips_type`改为必填
  - 接口`ListFirewallUsingGet`移除响应参数 `fw_instance_id`、`resource_id`、`name`、`ha_type`、`charge_mode`、`service_type`、`engine_type`、`flavor`、`protect_objects`、`status`、`description`、`is_old_firewall_instance`、`support_ipv6`、`feature_toggle`

### HuaweiCloud SDK EIP

- _新增特性_
  - 支持以下接口：
    - `ListBandwidthPkg`
    - `CountPublicIp`
    - `ShowPublicIpType`
    - `CountPublicIpInstance`
    - `BatchCreatePublicips`
    - `BatchDeletePublicIp`
    - `BatchDisassociatePublicips`
    - `CountEipAvailableResources`
- _解决问题_
  - 无
- _特性变更_
  - 接口`AssociatePublicips`请求参数`associate_instance_type`移除枚举值``
  - 接口`UpdateAssociatePublicip`请求参数`associate_instance_type`移除枚举值``

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateDependency`新增响应参数 `dep_id`
  - 接口`CreateDependencyVersion`新增响应参数 `dep_id`
  - 接口`UpdateFunctionConfig`新增请求参数 `enable_dynamic_memory`、`enable_auth_in_header`
  - 接口`ShowWorkflowExecutionForPage`:
    - 新增请求参数 `offset`、`limit`
    - 新增响应参数 `total`、`size`、`executions`
    - 移除请求参数 `page`、`page_size`
    - 移除响应参数 `pager`、`hisRecords`

### HuaweiCloud SDK GaussDBforNoSQL

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListAvailableFlavorInfos`:
    - 新增请求参数 `x-auth-token`
    - 新增响应参数 `list`
    - 移除响应参数 `optional_flavor_list`
    - 响应参数`instance_id`、`instance_name`、`vcpus`、`ram`、`spec_code`、`az_status`、`region_status`、`total_count`改为必填
  - 接口`ShowSlowLogDesensitization`:
    - 新增请求参数 `x-auth-token`
    - 响应参数`desensitization_status`改为必填
  - 接口`ListProjectTags`响应参数`type`、`key`、`values`、`total_count`改为必填
  - 接口`ModifyEpsQuotas`请求参数`instance`、`vcpus`、`ram`改为必填
  - 接口`ListEpsQuotas`:
    - 移除响应参数 `enterprise_project_id`、`enterprise_project_name`、`quota`、`used`
    - 响应参数`total_count`改为必填

### HuaweiCloud SDK Kafka

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ResizeInstance`新增请求参数 `publicip_id`

### HuaweiCloud SDK ProjectMan

- _新增特性_
  - 支持接口`DownloadAttachment`、`DeleteAttachment`、`ListStatusStatistic`
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreateIssueV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`
  - 接口`ListIssuesSfV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`
  - 接口`ListIssuesV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`
  - 接口`UpdateIssueV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`
  - 接口`ShowIssueV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`
  - 接口`ListChildIssuesV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`
  - 接口`ListProjectIssuesRecordsV4`新增响应参数 `user_id`、`user_num_id`
  - 接口`CreateSystemIssueV4`新增响应参数 `user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`、`user_id`、`user_num_id`

### HuaweiCloud SDK RocketMQ

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`CreatePostPaidInstance`请求参数`broker_num`改为必填
  - 接口`UpdateInstance`:
    - 新增请求参数 `enable_acl`
    - 移除请求参数 `retention_policy`
  - 接口`BatchUpdateConsumerGroup`新增响应参数 `job_id`
  - 接口`ShowGroup`:
    - 新增响应参数 `app_id`、`app_name`、`permissions`
    - 移除响应参数 `from_beginning`

### HuaweiCloud SDK TMS

- _新增特性_
  - 支持以下接口：
    - `ListResource`
    - `CreateResourceTag`
    - `DeleteResourceTag`
    - `ListTagKeys`
    - `ListTagValues`
    - `ShowResourceTag`
- _解决问题_
  - 无
- _特性变更_
  - 无

# 3.1.13 2022-12-01

### HuaweiCloud SDK CFW

- _新增特性_
  - 无
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListIpsSwitchStatusUsingGet`:
    - 新增响应参数 `data`
    - 移除响应参数 `object_id`、`basic_defense_status`、`virtual_patches_stauts`
  - 接口`ListEastWestFirewall`:
    - 新增响应参数 `protect_infos`
    - 移除响应参数 `protected_infos`
  - 接口`ListAttackLogs`请求参数`fw_instance_id`改为非必填
  - 接口`UpdateRuleAclUsingPut`新增请求参数 `type`
  - 接口`UpdateBlackWhiteListUsingPut`新增请求参数 `list_type`、`object_id`
  - 接口`ListFirewallUsingGet`:
    - 新增响应参数 `data`
    - 移除响应参数 `fw_instance_id`、`resource_id`、`name`、`ha_type`、`charge_mode`、`service_type`、`engine_type`、`flavor`、`protect_objects`、`status`、`description`、`is_old_firewall_instance`、`support_ipv6`、`feature_toggle`
  - 接口`ListServiceSetDetails`:
    - 新增响应参数 `data`
    - 移除响应参数 `id`、`name`、`description`
  - 接口`CountEips`:
    - 新增响应参数 `data`
    - 移除响应参数 `object_id`、`eip_total`、`eip_protected`
  - 接口`ListEipResources`:
    - 新增响应参数 `data`
    - 移除响应参数 `id`、`public_ip`、`status`、`public_ipv6`、`enterprise_project_id`、`device_id`、`device_name`、`device_owner`、`associate_instance_type`
  - 接口`UpdateAddressSetInfoUsingPut`新增请求参数 `address_type`

### HuaweiCloud SDK FunctionGraph

- _新增特性_
  - 支持接口`AsyncInvokeReservedFunction`
- _解决问题_
  - 无
- _特性变更_
  - 接口`ListDependencies`响应参数`runtime`新增枚举值`http`
  - 接口`ListDependencyVersion`响应参数`runtime`新增枚举值`http`
  - 接口`CreateFunction`:
    - 请求参数`runtime`新增枚举值`http`
    - 响应参数`runtime`新增枚举值`http`
  - 接口`ListFunctions`响应参数`runtime`新增枚举值`http`
  - 接口`UpdateFunctionCode`响应参数`runtime`新增枚举值`http`
  - 接口`ShowFunctionCode`响应参数`runtime`新增枚举值`http`
  - 接口`UpdateFunctionConfig`:
    - 请求参数`runtime`新增枚举值`http`
    - 响应参数`runtime`新增枚举值`http`
  - 接口`ShowFunctionConfig`响应参数`runtime`新增枚举值`http`
  - 接口`UpdateFunctionMaxInstanceConfig`响应参数`runtime`新增枚举值`http`
  - 接口`ListReservedInstanceConfigs`:
    - 新增响应参数 `reservedinstances`、`page_info`、`count`
    - 移除响应参数 `function_urn`、`qualifier_type`、`qualifier_name`、`min_count`、`idle_mode`、`tactics_config`
  - 接口`CreateFunctionVersion`响应参数`runtime`新增枚举值`http`
  - 接口`ListFunctionVersions`响应参数`runtime`新增枚举值`http`
  - 接口`ImportFunction`响应参数`runtime`新增枚举值`http`

### HuaweiCloud SDK Image

- _新增特性_
  - 支持接口`RunQueryCustomTags`、`RunDeleteCustomTags`、`RunImageMediaTaggingDet`
- _解决问题_
  - 无
- _特性变更_
  - 接口`RunImageMediaTagging`新增请求参数 `use_default_tags`

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
    
