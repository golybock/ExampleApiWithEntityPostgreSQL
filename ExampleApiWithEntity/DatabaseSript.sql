create table if not exists public.role
(
    id   serial
        primary key,
    name varchar(100)
        unique
);

create table if not exists public.worker
(
    id      serial
        primary key,
    name    varchar(150),
    role_id integer not null
        constraint role_fk
            references public.role
);

