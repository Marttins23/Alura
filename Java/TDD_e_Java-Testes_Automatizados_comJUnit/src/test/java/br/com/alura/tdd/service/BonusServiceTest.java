package br.com.alura.tdd.service;

import br.com.alura.tdd.modelo.Funcionario;
import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.math.BigDecimal;
import java.time.LocalDate;

public class BonusServiceTest {

    private BonusService service;
    private Funcionario funcionario;

    public void inicializarObjetos(String salario) {
        this.service = new BonusService();
        this.funcionario = new Funcionario(
            "Mateus",
            LocalDate.now(),
            new BigDecimal(salario)
        );
    }

    @Test
    void bonusDeveriaSerZeroParaFuncionarioComSalarioMuitoAlto() {
        this.inicializarObjetos("25000");
        assertThrows(
            IllegalArgumentException.class,
            () -> this.service.calcularBonus(this.funcionario)
        );
    }

    @Test
    void bonusDeveriaSerDezPorCentoDoSalario() {
        this.inicializarObjetos("2500");
        BigDecimal bonus = this.service.calcularBonus(this.funcionario);

        assertEquals(new BigDecimal("250.00"), bonus);
    }

    @Test
    void bonusDeveriaSerDezPorCentoParaSalarioDeExatamentoDezMil() {
        this.inicializarObjetos("10000");
        BigDecimal bonus = this.service.calcularBonus(this.funcionario);

        assertEquals(new BigDecimal("1000.00"), bonus);
    }

}
