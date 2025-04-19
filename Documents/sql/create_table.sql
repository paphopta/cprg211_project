CREATE TABLE customer (
    customer_id VARCHAR(10) PRIMARY KEY, 
    first_name VARCHAR(30), 
    last_name VARCHAR(30), 
    phone VARCHAR(12), 
    email VARCHAR(30) 
);

CREATE TABLE inventory (
    part_id VARCHAR(10) PRIMARY KEY, 
    brand VARCHAR(20), 
    model VARCHAR(20),
    part_name VARCHAR(40), 
    unit_price DOUBLE(9,2), 
    inventory_quantity INT
);

CREATE TABLE job_order (
    order_id VARCHAR(10) PRIMARY KEY, 
    customer_id VARCHAR(10), 
    order_date DATE, 
    work_description VARCHAR(500), 
    service_charge DOUBLE(9,2), 
    total_price DOUBLE(9,2)
);

CREATE TABLE job_order_inventory (
    order_id VARCHAR(10), 
    part_id VARCHAR(10), 
    order_quantity INT, 
    PRIMARY KEY (order_id, part_id), 
    FOREIGN KEY (order_id) REFERENCES job_order(order_id), 
    FOREIGN KEY (part_id) REFERENCES inventory(part_id)
);