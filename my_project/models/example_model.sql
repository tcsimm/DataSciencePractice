-- models/example_model.sql
SELECT
  CURRENT_DATE AS today,
  CURRENT_USER() AS user,
  CURRENT_ROLE() AS role
