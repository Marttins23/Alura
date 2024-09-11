import "./Footer.css";

const Footer  = () => {
    return (
        <section className="footer">
            <div className="column social-icons">
                <img src="img/fb.png" alt="Facebook" />
                <img src="img/tw.png" alt="Twitter" />
                <img src="img/ig.png" alt="Instagram" />
            </div>
            <div className="column">
                <img src="img/logo.png" alt="Logo" />
            </div>
            <div className="column">
                <span>Desenvolvido por Mateus Ferreira.</span>
            </div>
        </section>
    );
}

export default Footer;