package br.com.alura.rh.serivce.reajuste;

import br.com.alura.rh.ValidacaoException;
import br.com.alura.rh.model.Funcionario;
import java.math.BigDecimal;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

/**
 *
 * @author Mateus
 */
public class ValidacaoPeriodicidadeEntreReajustes implements ValidacaoReajuste {
    
    @Override
    public void validar(Funcionario funcionario, BigDecimal aumento) {
        LocalDate dataUltimoReajuste = funcionario.getDataUltimoReajuste();
        LocalDate dataAtual = LocalDate.now();
        long mesesDesdeUltimoReajuste = ChronoUnit.MONTHS.between(dataUltimoReajuste, dataAtual);
        
        if (mesesDesdeUltimoReajuste < 6) {
            throw new ValidacaoException("O reajuste só pode ser feito a cada 6 meses!");
        }
    }
    
}
