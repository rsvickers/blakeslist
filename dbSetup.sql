CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS blakes(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name VARCHAR(255) NOT NULL,
        favoriteMovie VARCHAR(255),
        age INT UNSIGNED NOT NULL,
        year INT UNSIGNED NOT NULL,
        isBlake BOOLEAN NOT NULL DEFAULT true,
        isFlexible BOOLEAN NOT NULL DEFAULT false
    ) default charset utf8 COMMENT '';

INSERT INTO
    blakes (
        name,
        favoriteMovie,
        age,
        year,
        isBlake,
        isFlexible
    )
VALUES
(
        "Blake",
        "Dumb and Dumber",
        34,
        1989,
        true,
        false
    );

INSERT INTO
    blakes (
        name,
        favoriteMovie,
        age,
        year,
        isBlake,
        isFlexible
    )
VALUES
(
        "Laura",
        "The Patriot",
        21,
        2002,
        false,
        true
    );

INSERT INTO
    blakes (
        name,
        favoriteMovie,
        age,
        year,
        isBlake,
        isFlexible
    )
VALUES
(
        "Matt",
        "Lord of the Rins",
        32,
        1991,
        false,
        false
    );

INSERT INTO
    blakes (
        name,
        favoriteMovie,
        age,
        year,
        isBlake,
        isFlexible
    )
VALUES
(
        "Daniel",
        "Joker",
        18,
        2005,
        false,
        false
    );

DROP TABLE blakes;

SELECT * FROM blakes WHERE id = 2

DELETE FROM blakes WHERE id = 4