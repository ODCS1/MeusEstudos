package com.store.store.model;

import jakarta.persistence.*;

@Entity
@Table
public class Supplier {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer Supplierid;

    @Column
    private String name;

    @Column
    private String address;

    @Column
    private String city;

    @Column
    private String State;

    @Column
    private String PostalCode;

    public Supplier(String name, String address, String city, String state, String postalCode) {
        this.name = name;
        this.address = address;
        this.city = city;
        State = state;
        PostalCode = postalCode;
    }

    public Integer getSupplierid() {
        return Supplierid;
    }

    public String getName() {
        return name;
    }

    public String getAddress() {
        return address;
    }

    public String getCity() {
        return city;
    }

    public String getState() {
        return State;
    }

    public String getPostalCode() {
        return PostalCode;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public void setState(String state) {
        State = state;
    }

    public void setPostalCode(String postalCode) {
        PostalCode = postalCode;
    }
}