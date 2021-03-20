SELECT count(vendor_id), vendor_state
FROM vendors
GROUP BY vendor_state
ORDER BY count(vendor_id) desc; --#1

SELECT count(vendor_id), vendor_city, vendor_state
FROM vendors
GROUP BY vendor_city, vendor_state
ORDER BY count(vendor_id) desc; --#2

SELECT sum(invoice_total) AS "Total", vendor_name
FROM invoices i INNER JOIN vendors v 
ON i.vendor_id = v.vendor_id
GROUP BY vendor_name
ORDER BY "Total" desc; --#3

SELECT sum(invoice_total) AS "Total Due", sum(payment_total) AS "Paid",
        vendor_state
FROM invoices i INNER JOIN vendors v
ON i.vendor_id = v.vendor_id
GROUP BY vendor_state
ORDER BY "Total Due" desc; --#4

SELECT sum(invoice_total) AS "Charged", invoice_number
FROM invoices
GROUP BY invoice_number
ORDER BY "Charged" desc; --#5

SELECT sum(invoice_total) AS "Total", avg(invoice_total) as "Average"
FROM invoices; --#6 

SELECT vendor_name, invoice_date, 
invoice_total - payment_total - credit_total AS "Balance"
FROM invoices i INNER JOIN vendors v 
ON i.vendor_id = v.vendor_id
WHERE invoice_total - payment_total - credit_total <> 0
ORDER BY invoice_date asc; --#7

SELECT vendor_name AS "Vendor", invoice_due_date AS "Due Date", 
sum(invoice_total - payment_total - credit_total) AS "Balance",
vendor_contact_first_name ||' '|| vendor_contact_last_name AS "Contact Name",
vendor_phone AS "Phone Number"
FROM invoices i INNER JOIN vendors v
ON i.vendor_id = v.vendor_id
WHERE invoice_total - payment_total - credit_total <> 0
GROUP BY vendor_name, invoice_due_date, 
vendor_contact_first_name ||' '|| vendor_contact_last_name, vendor_phone
ORDER BY "Balance" desc, invoice_due_date asc; --#8

SELECT vendor_name, vendor_address1 ||' '|| vendor_address2 ||' '|| vendor_city
||', '|| vendor_state || vendor_zip_code AS "Address"
FROM Vendors
WHERE vendor_address2 <> 'NULL'; --#9

SELECT g.account_number, account_description, sum(line_item_amt)
FROM general_ledger_accounts g INNER JOIN invoice_line_items i
ON g.account_number = i.account_number
GROUP BY g.account_number, account_description 
ORDER BY sum(line_item_amt) desc; --#10

SELECT customer_first_name ||' '|| customer_last_name AS "Name", 
count(order_id) AS "Total Orders"
FROM customers_om c INNER JOIN orders o 
ON c.customer_id = o.customer_id
GROUP BY customer_first_name ||' '|| customer_last_name
ORDER BY count(order_id) desc; --#11

SELECT customer_state AS "State", 
count(order_id) AS "Total Orders"
FROM customers_om c INNER JOIN orders o 
ON c.customer_id = o.customer_id
GROUP BY customer_state
ORDER BY count(order_id) desc; --#12

SELECT artist, count(order_id)
FROM items i INNER JOIN order_details o 
ON i.item_id = o.item_id
GROUP BY artist 
ORDER BY count(order_id) desc; --#13

SELECT artist
FROM items i 
LEFT OUTER JOIN order_details o ON i.item_id = o.item_id
WHERE i.item_id IS NULL; --#14

SELECT category_name, count(product_id)
FROM categories c INNER JOIN products p
ON c.category_id = p.category_id
GROUP BY category_name
ORDER BY count(product_id) desc; --#15

SELECT count(address_id) AS "Number of Addresses", state
FROM addresses
GROUP BY state
ORDER BY count(address_id) desc; -- #16

SELECT count(customer_address) AS "Number of Addresses", 
customer_state
FROM customers_om
GROUP BY customer_state
ORDER BY count(customer_address) desc; --#16

SELECT terms_description, count(i.terms_id)
FROM invoices i INNER JOIN terms t
ON i.terms_id = t.terms_id
GROUP BY terms_description
ORDER BY count(i.terms_id) desc; --#17

SELECT terms_description, count(i.terms_id), 
sum(invoice_total) AS "Total Due"
FROM invoices i INNER JOIN terms t
ON i.terms_id = t.terms_id
GROUP BY terms_description
ORDER BY count(i.terms_id) desc; --#18

SELECT line_item_description, count(invoice_id)
FROM invoice_line_items
HAVING count(line_item_description) > 1
GROUP BY line_item_description
ORDER BY count(invoice_id) desc; -- #19

SELECT sum(line_item_amt), line_item_description
FROM invoice_line_items
GROUP BY line_item_description; --#20
