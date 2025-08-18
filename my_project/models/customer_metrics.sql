== models/arr.sql

SELECT
	customer_id,
	MIN(subscription_start_date) AS start_date,
	MAX(subscription_end_date) AS end_date,
	SUM(amount) AS arr
FROM {{ ref('subscriptions') }}
WHERE status = 'active'
GROUP BY customer_id
