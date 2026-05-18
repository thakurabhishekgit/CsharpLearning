# LINQ + Backend Practice Questions (Users & Payments Scenario)

Your setup is already GOOD enough to start real backend-oriented LINQ practice.

And honestly, this is the correct way to learn LINQ:

* realistic entities
* relationships
* filtering
* analytics
* response shaping

NOT random number arrays.

---

# LEVEL 1 — Basic Filtering & Retrieval

These build LINQ fundamentals.

---

## Users

1. Get all active users.
2. Get all inactive users.
3. Get users from `"Chicago"`.
4. Get users whose age is greater than 30.
5. Get users whose name starts with `"A"`.
6. Get users whose name contains `"a"`.
7. Find the first active user.
8. Find user with `Id = 3`.
9. Check if any user belongs to `"Houston"`.
10. Count total active users.

---

## Payments

11. Get all completed payments.
12. Get all failed payments.
13. Get payments greater than `100`.
14. Get payment with highest amount.
15. Get payment with lowest amount.
16. Count completed payments.
17. Check if any failed payment exists.
18. Get all payments sorted by amount ascending.
19. Get all payments sorted descending.
20. Calculate total payment amount.

---

# LEVEL 2 — Projection & API Response Shaping

These simulate backend API responses.

---

21. Return only user names.
22. Return only cities.
23. Return user name + city only.
24. Return payment amount + status only.
25. Create custom response:

```text id="7p2xqr"
{
   UserName,
   IsActive
}
```

26. Create response:

```text id="2m7xpr"
{
   PaymentId,
   Amount,
   Status
}
```

27. Return all active users with uppercase names.
28. Return all completed payment amounts rounded to integer.
29. Return only distinct cities.
30. Return total number of users + total payments in one object.

---

# LEVEL 3 — Relationship / JOIN Questions (MOST IMPORTANT)

These are REAL backend questions.

---

31. Join users with payments.
32. Show:

```text id="9n4xqp"
UserName + PaymentAmount
```

33. Show only users with completed payments.
34. Show users with failed payments.
35. Show users whose payment amount > 100.
36. Get all payments with corresponding user city.
37. Show:

```text id="5m8xpr"
{
   UserName,
   Amount,
   Status,
   City
}
```

38. Find total payment amount per user.
39. Find user with highest payment.
40. Find all users who made completed payments.

---

# LEVEL 4 — Aggregation & Analytics

These are VERY backend/dashboard-oriented.

---

41. Total revenue from completed payments.
42. Average payment amount.
43. Highest completed payment.
44. Lowest failed payment.
45. Count payments by status.
46. Group payments by status.
47. Group users by city.
48. Find city with most users.
49. Find total completed payment amount grouped by city.
50. Find average payment amount per user.

---

# LEVEL 5 — Real Backend Business Logic

These simulate actual backend features.

---

51. Get all active users with completed payments only.
52. Get inactive users who still made payments.
53. Find users who never made completed payments.
54. Find users whose all payments failed.
55. Get top 3 highest-paying users.
56. Find suspicious payments above certain threshold.
57. Return dashboard object:

```text id="1k7xqp"
{
   TotalUsers,
   ActiveUsers,
   TotalRevenue,
   FailedPayments
}
```

58. Paginate users:

```text id="8q4xpr"
Skip + Take
```

59. Search users dynamically by name or city.
60. Sort users dynamically by age/name/city.

---

# LEVEL 6 — ASP.NET Core Style Questions

These directly prepare you for APIs.

---

61. Create API-style response DTO using `Select`.
62. Convert entity → response object.
63. Filter only required fields for API response.
64. Simulate admin dashboard analytics response.
65. Simulate transaction history API.
66. Simulate user profile API with payment history.
67. Simulate payment summary API.
68. Simulate active users endpoint.
69. Simulate failed transactions endpoint.
70. Simulate revenue analytics endpoint.

---

# LEVEL 7 — Advanced LINQ Thinking

These develop professional backend querying skills.

---

71. Use `GroupBy` + `Select`.
72. Use `Join` + filtering together.
73. Use nested projections.
74. Use `OrderBy` + `ThenBy`.
75. Use `Any` inside `Where`.
76. Use `All` to validate conditions.
77. Use `Contains` for filtering.
78. Use `SelectMany`.
79. Create nested response objects.
80. Build mini analytics report object.

---

# MOST IMPORTANT LINQ METHODS You Must Master

Before ASP.NET Core, become comfortable with:

| Method         | Priority  |
| -------------- | --------- |
| Where          | CRITICAL  |
| Select         | CRITICAL  |
| FirstOrDefault | CRITICAL  |
| Any            | CRITICAL  |
| Count          | VERY HIGH |
| OrderBy        | VERY HIGH |
| GroupBy        | VERY HIGH |
| Join           | VERY HIGH |
| Sum            | HIGH      |
| Skip/Take      | HIGH      |
| Distinct       | HIGH      |

---

# Final Recommendation

If you can comfortably solve:

* joins
* grouping
* projections
* filtering
* DTO shaping

using your current scenario,

then honestly:

# you are ready to start ASP.NET Core APIs.

Because real backend development is mostly:

* request handling
* data transformation
* querying
* response shaping

which LINQ teaches extremely well.
