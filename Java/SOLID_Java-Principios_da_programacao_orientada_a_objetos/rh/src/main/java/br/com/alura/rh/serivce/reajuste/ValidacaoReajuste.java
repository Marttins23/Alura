package br.com.alura.rh.serivce.reajuste;

import br.com.alura.rh.model.Funcionario;
import java.math.BigDecimal;

/**
 *
 * @author Mateus
 */
interface ValidacaoReajuste {
    
    void validar(Funcionario funcionario, BigDecimal aumento);
    
}
