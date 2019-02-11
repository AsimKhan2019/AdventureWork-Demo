
/* Drop session if already exists */
IF EXISTS(SELECT * FROM sys.server_event_sessions WHERE name='Jamuro.AdventureWorks2016') 
	DROP EVENT SESSION [Jamuro.AdventureWorks2016] ON SERVER 
GO

/* Create new session */
CREATE EVENT SESSION [Jamuro.AdventureWorks2016] ON SERVER 

ADD EVENT sqlserver.rpc_completed(SET collect_statement=(1)
    ACTION(sqlserver.client_app_name,sqlserver.database_name)
    WHERE ([sqlserver].[database_name]=N'AdventureWorks2016')),

ADD EVENT sqlserver.sql_statement_completed(SET collect_statement=(1)
    ACTION(sqlserver.client_app_name,sqlserver.database_name)
    WHERE ([sqlserver].[database_name]=N'AdventureWorks2016'))

WITH (MAX_MEMORY=4096 KB,EVENT_RETENTION_MODE=ALLOW_SINGLE_EVENT_LOSS,MAX_DISPATCH_LATENCY=30 SECONDS,MAX_EVENT_SIZE=0 KB,MEMORY_PARTITION_MODE=NONE,TRACK_CAUSALITY=ON,STARTUP_STATE=OFF)
GO

