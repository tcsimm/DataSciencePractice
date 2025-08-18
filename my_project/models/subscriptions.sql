-- models/subscriptions.sql-- models/subscriptions.sql

select * from (
    select 1 as customer_id, '2023-01-01'::date as subscription_start_date, '2023-12-31'::date as subscription_end_date, 100 as amount, 'active' as status
    union all
    select 2, '2023-03-15', '2023-09-15', 200, 'inactive'
    union all
    select 1, '2024-01-01', '2024-12-31', 150, 'active'
    union all
    select 3, '2023-06-01', '2023-11-30', 300, 'active'
    union all
    select 4, '2022-01-01', '2022-12-31', 120, 'inactive'
) as subscriptions

